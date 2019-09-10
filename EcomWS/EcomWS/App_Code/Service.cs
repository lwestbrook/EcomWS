using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;



// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{


    public string GetData(int value)
    {
        return string.Format("You entered: {0}", value);
    }

    public CompositeType GetDataUsingDataContract(CompositeType composite)
    {
        if (composite == null)
        {
            throw new ArgumentNullException("composite");
        }
        if (composite.BoolValue)
        {
            composite.StringValue += "Suffix";
        }
        return composite;
    }

    
    //***********************************************************************************
    public AllfleXML.FlexSpec.Specification GenerateSpecificationByID(int MarkingId)
    {
        //WriteToLog("GenerateSpecification(MarkingID) : starting................");

        using (var db = new Allflex.Server.MarkingProgramDataContext(Allflex.Common.Configuration.idOneConnection))
        {
            //int ID = 0;
            if (db.Connection.State.ToString() == "Closed")
            {
                db.Connection.ConnectionString = "Data Source=vsdalsql08r.dallas.allflex-group.com;Trusted_Connection=yes;Integrated Security =false;Initial Catalog=idOneUsa;User Id=intranetuser;Password=!ntr4n3tU5erL!v3";
                //db.Connection.ConnectionString = "Data Source=vsdevsql01.dallas.allflex-group.com;Trusted_Connection=yes;Integrated Security =false;Initial Catalog=idOneUsa;User Id=intranetuser;Password=!ntr4n3tU5erL!v3";
                db.Connection.Open();
            }

            //ID = db.MarkingBooks.SingleOrDefault(o => o.SCHMARKINGNAME == SKU).SCHMARKINGPRG;
            var markingBook = db.MarkingBooks.SingleOrDefault(o => o.SCHMARKINGPRG == MarkingId);
            return new AllfleXML.FlexSpec.Specification
            {
                Id = markingBook.SCHMARKINGPRG.ToString(),
                Name = markingBook.SCHMARKINGNAME.Trim(),
                Components = BuildComponents(markingBook).ToList(),
            };
        }
    }

    
    public  AllfleXML.FlexSpec.Specification GenerateSpecification(string SKU)
    {
        //WriteToLog("GenerateSpecification : starting................");
        //ServicePointManager.Expect100Continue = true;
        //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        using (var db = new Allflex.Server.MarkingProgramDataContext(Allflex.Common.Configuration.idOneConnection))
        {
            int ID = 0;
            try
            {
                //int ID = 0;
                if (db.Connection.State.ToString() == "Closed")
                {
                    db.Connection.ConnectionString = "Data Source=vsdalsql08r.dallas.allflex-group.com;Trusted_Connection=no;Integrated Security =false;Initial Catalog=idOneUsa;User Id=intranetuser;Password=!ntr4n3tU5erL!v3";
                    //db.Connection.ConnectionString = "Data Source=vsdevsql01.dallas.allflex-group.com;Trusted_Connection=yes;Integrated Security =false;Initial Catalog=idOneUsa;User Id=intranetuser;Password=!ntr4n3tU5erL!v3";
                    db.Connection.Open();
                }
                var MB = db.MarkingBooks.SingleOrDefault(o => o.SCHMARKINGNAME == SKU.Trim());
                //The real SKU is ITEMNMBR
                //var MBB = db.MarkingItems.SingleOrDefault(o => o.ITEMNMBR == SKU.Trim());
                if (MB != null)
                {
                    ID = MB.SCHMARKINGPRG;
                }
                if (ID == 0)
                {
                    return new AllfleXML.FlexSpec.Specification
                    {
                        Id = "0",
                        Name = SKU,
                        MarkingCode = "The SKU " + SKU + " is not a valid SKU. Please try again.",

                        Components = null
                    };
                }
                else
                {
                    var markingBook = db.MarkingBooks.SingleOrDefault(o => o.SCHMARKINGPRG == ID);
                    //db.Connection.Close();

                    return new AllfleXML.FlexSpec.Specification
                    {

                        Id = markingBook.SCHMARKINGPRG.ToString(),
                        Name = markingBook.SCHMARKINGNAME.Trim(),
                        Components = BuildComponents(markingBook).ToList()

                    };
                }
            }
            catch (Exception ex)
            {
                WriteToLog("GenerateSpecification Exception: SKU: " + SKU.Trim().ToString() + "; ID: " + ID + " ; Message :" + ex.Message.ToString());

                return new AllfleXML.FlexSpec.Specification
                {
                    MarkingCode = ex.Message.ToString()
                };
            }
        }
    }

    public IEnumerable<AllfleXML.FlexSpec.Component> BuildComponents(Allflex.Server.MarkingBook markingBook)
    {
        

        using (var db = new Allflex.Server.MarkingProgramDataContext(Allflex.Common.Configuration.idOneConnection))
        {
            if (db.Connection.State.ToString() == "Closed")
            {
                db.Connection.ConnectionString = "Data Source=vsdalsql08r.dallas.allflex-group.com;Trusted_Connection=no;Integrated Security =false;Initial Catalog=idOneUsa;User Id=intranetuser;Password=!ntr4n3tU5erL!v3";
                //db.Connection.ConnectionString = "Data Source=vsdevsql01.dallas.allflex-group.com;Trusted_Connection=yes;Integrated Security =false;Initial Catalog=idOneUsa;User Id=intranetuser;Password=!ntr4n3tU5erL!v3";
                db.Connection.Open();
            }
            foreach (var markingItem in markingBook.MarkingItems)
            {
                var tag = db.SchemeTags.SingleOrDefault(o => o.TAGID == markingItem.TAGID);
                var colors = db.SchemeItemTags.Where(o => o.TAGID == markingItem.TAGID).Select(o => o.SchemaItemColor);
                //***********************************************************************
                //If I need the Destron color code I can use this
                DestronColorCode code = new DestronColorCode();
                Dictionary<string, string> Dcode = code.CreateDestronDictionary();
                foreach (KeyValuePair<string, string> color in Dcode)
                {
                    //Console.WriteLine("Key: {0}, Value: {1}", color.Key, color.Value);
                }
                //***********************************************************************
                yield return new AllfleXML.FlexSpec.Component
                {
                    Index = markingItem.SCHITMSEQ,
                    Name = markingItem.TAGID.Trim(),
                    Description = tag.TAGCOMMDESC.Trim(),
                    ProductLine = Enum.GetName(typeof(Allflex.DataContract.ComponentBrand), (Allflex.DataContract.ComponentBrand)tag.BRAND),
                    Silhouette = markingItem.TAGID.Trim() + "-Silhouette.png", // TODO: Get from API
                    Outline = markingItem.TAGID.Trim() + "-Outline.png", // TODO: Get from API

                    Color = markingItem.ISFIXEDCOLOR ? markingItem.COLORID.Trim() : null,
                    FixedColor = markingItem.COLORID.Trim().Length > 0 && markingItem.COLORID.Trim() != null ? true : false,

                    Faces = BuildFaces(markingItem).ToList(),
                    Colors = colors.Select(BuildColor).ToList()
                };



            }
        }
    }

    public string DestronColor()
    {
        string dc = "";


        return dc;
    }

    public AllfleXML.FlexSpec.Color BuildColor(Allflex.Server.SchemaItemColor color)
    {
        DestronColorCode code = new DestronColorCode();
        Dictionary<string, string> Dcode = code.CreateDestronDictionary();
        //var T = Dcode.ContainsKey(color.COLORDESC.Trim().ToString());

        return new AllfleXML.FlexSpec.Color
        {
            Name = color.COLORDESC.Trim(),
            ColorCode = color.COLORID.Trim(),
            HexCode = color.RGB.Trim(),
            DestronCode = Dcode.ContainsKey(color.COLORDESC.Trim().ToString()) ? Dcode[color.COLORDESC.Trim().ToString()] : "NA",
        };
    }

    public IEnumerable<AllfleXML.FlexSpec.Face> BuildFaces(Allflex.Server.MarkingItem markingItem)
    {
        var tagVars = markingItem.MarkingBook.MarkingBookVars.Where(o => o.VarStyles.VARTABINDEX == markingItem.SCHITMSEQ);
        var nonRfids = tagVars
            .Where(o => o.SCHVTMPLTYPE.Trim() != Allflex.DataContract.MarkingPartsType.OTP.ToString().Trim())
            .GroupBy(o => o.SCHSIDE);
        foreach (var face in nonRfids)
        {            
            yield return new AllfleXML.FlexSpec.Face
            {
                Name = face.Key.Trim(),
                Variables = ConsolidateCutoffs(face.Select(o => o)).Select(BuildVariables).ToList()
                //Variables = ConsolidateCutoffs(face.Select(o => o)).ToList().Select(BuildVariables).ToList()
            };
        }

        var rfids = tagVars
            .Where(o => o.SCHVTMPLTYPE.Trim() == Allflex.DataContract.MarkingPartsType.OTP.ToString().Trim())
            .GroupBy(o => o.SCHSIDE);
        foreach (var face in rfids)
        {
            yield return new AllfleXML.FlexSpec.Face
            {
                Name = "RFID",
                Variables = ConsolidateCutoffs(face.Select(o => o)).Select(BuildVariables).ToList()
            };
        }
    }

    public AllfleXML.FlexSpec.Variable BuildVariables(Allflex.Server.MarkingBookVar markingBookVar)
    {
        using (var db = new Allflex.Server.MarkingProgramDataContext(Allflex.Common.Configuration.idOneConnection))
        {

            if (db.Connection.State.ToString() == "Closed")
            {
                db.Connection.ConnectionString = "Data Source=vsdalsql08r.dallas.allflex-group.com;Trusted_Connection=no;Integrated Security =false;Initial Catalog=idOneUsa;User Id=intranetuser;Password=!ntr4n3tU5erL!v3";
                //db.Connection.ConnectionString = "Data Source=vsdevsql01.dallas.allflex-group.com;Trusted_Connection=yes;Integrated Security =false;Initial Catalog=idOneUsa;User Id=intranetuser;Password=!ntr4n3tU5erL!v3";
                db.Connection.Open();
            }
            var markingBook = db.MarkingBooks.SingleOrDefault(o => o.SCHMARKINGPRG == markingBookVar.SCHMARKINGPRG);
            var desc = markingBook.SCHMARKINGNAME;
            //This list is hard coded because this value does niot exist in IdOne.*************************************************
            List<CurvedTextLst> CurvedText = new List<CurvedTextLst>();
            CurvedText.Add(new CurvedTextLst
            {
                SKUname = "GSM3",
                CurveType = 1
            });
            CurvedText.Add(new CurvedTextLst
            {
                SKUname = "GSM6",
                CurveType = 3
            });
            CurvedText.Add(new CurvedTextLst
            {
                SKUname = "GSM9",
                CurveType = 2
            });
            CurvedText.Add(new CurvedTextLst
            {
                SKUname = "GESM3",
                CurveType = 1
            });
            CurvedText.Add(new CurvedTextLst
            {
                SKUname = "GESM6",
                CurveType = 3
            });
            CurvedText.Add(new CurvedTextLst
            {
                SKUname = "GESM9",
                CurveType = 2
            });
            CurvedText.Add(new CurvedTextLst
            {
                SKUname = "GSF1",
                CurveType = 1
            });
            CurvedText.Add(new CurvedTextLst
            {
                SKUname = "GSF2",
                CurveType = 3
            });
            CurvedText.Add(new CurvedTextLst
            {
                SKUname = "GSTF1",
                CurveType = 1
            });
            CurvedText.Add(new CurvedTextLst
            {
                SKUname = "GSTF2",
                CurveType = 3
            });
            CurvedText.Add(new CurvedTextLst
            {
                SKUname = "GSTF3",
                CurveType = 1
            });
            CurvedText.Add(new CurvedTextLst
            {
                SKUname = "HSM_M_1RT_SETS",
                CurveType = 1
            });
            CurvedText.Add(new CurvedTextLst
            {
                SKUname = "HSM_TW_2RT_SETS",
                CurveType = 4
            });
            CurvedText.Add(new CurvedTextLst
            {
                SKUname = "HSM_M_1RT",
                CurveType = 1
            });
            CurvedText.Add(new CurvedTextLst
            {
                SKUname = "HSM_M_2RT",
                CurveType = 4
            });
            CurvedText.Add(new CurvedTextLst
            {
                SKUname = "HSM_TW_2RT",
                CurveType = 4
            });
            CurvedText.Add(new CurvedTextLst
            {
                SKUname = "SF_T12",
                CurveType = 3
            });
            CurvedText.Add(new CurvedTextLst
            {
                SKUname = "SF_T2",
                CurveType = 2
            });
            //This list is hard coded because this value CurvedText does niot exist in IdOne.*************************************************                       
            //string[] CurvedTxt = Enum.GetNames(typeof(SkuWithCurvedText.CurvedTextSKU));
            //var typ = CurvedTxt[0].GetType();
            //var enumList = Enum.GetValues(typeof(SkuWithCurvedText.CurvedTextSKU)).OfType<SkuWithCurvedText.CurvedTextSKU>().ToList();

            int curve = 0;
            for (int x = 0; x < CurvedText.Count(); x++)
            {
                if (desc.Trim() == CurvedText[x].SKUname.ToString())
                {
                    curve = Convert.ToInt32(CurvedText[x].CurveType);
                    break;
                }
                //Console.WriteLine();
            }
            var txt = "";
            if (curve != 0)
            {
                txt = "CurvedText";
            }
                        
            return new AllfleXML.FlexSpec.Variable
            {
                Index = markingBookVar.SCHORDER,
                Name = GetVariableName(markingBookVar.SCHMARKINGPRG, markingBookVar.SCHVARLINEMAP),//markingBookVar.VarStyles.SCHVARCAPTION,
                Description = markingBookVar.VarStyles.SCHVARCAPTION.Trim(),
                //Role = markingBookVar.SCHVTMPLTYPE.Trim()=="OTP" || markingBookVar.SCHVTMPLTYPE.Trim()=="Serial" || markingBookVar.SCHVTMPLTYPE.Trim()=="TSU"  ? markingBookVar.SCHVTMPLTYPE + " " + markingBookVar.SCHVTYPEVALUE : markingBookVar.SCHVTMPLTYPE.Trim() ,
                Role = markingBookVar.SCHVTMPLTYPE.Trim(),
                Type = curve != 0 ? txt : markingBookVar.SCHVTYPE.Trim(),
                Width = markingBookVar.VarStyles.VARWIDTH,
                Height = markingBookVar.VarStyles.VARHEIGHT,
                PositionX = markingBookVar.VarStyles.VARLEFT,
                PositionY = markingBookVar.VarStyles.VARTOP,
                DefaultValue = GetVariableDefaultValue(markingBookVar),
                ValueFormat = markingBookVar.SCHVFORMAT.Trim(),
                MaxLength = markingBookVar.SCHVARLENGTH,
                FontSize = markingBookVar.VarStyles.SCHVARFONT.ToString(),
                IsFixed = markingBookVar.SCHVARFIXED, 
                IsInk = markingBookVar.ISINK,
                IsLaser = true,
                LogoImageLocation = "",// TODO: Get from API
                //Radius = 51,
                //CurveTextAttachTo = string.Empty,
                CopyValueFrom = markingBookVar.SCHVARFORMULA.Trim(), // @{SCHORDER}
            };
        }
    }

    private static IEnumerable<Allflex.Server.MarkingBookVar> ConsolidateCutoffs(IEnumerable<Allflex.Server.MarkingBookVar> vars)
    {
        var cutOffs = vars.Where(o => o.SCHVARGROUP != 0).GroupBy(o => o.SCHVARGROUP);
        if (!cutOffs.Any()) return vars;
        foreach (var cutOff in cutOffs)
        {
            
            var maxLength = cutOff.Max(o => o.SCHVARLENGTH);
            //var removals = cutOff.Where(o => o != cutOff.SingleOrDefault(c => c.SCHVARLENGTH == maxLength));
            //var removals = cutOff.Where(o => o != cutOff.Select(c => c.SCHVARLENGTH == maxLength));
            //LDW 6/27/2019
            //I added the second criteria isInk==false but I'm not sure if this is correct, but the query above throws an exception because it retruns more than one row on some products.
            //LDW 8/15/19... I took the isInk criteria out and changed the SingleorDefault to FirstorDefault because there are more than one most of the time. I still dont understand what this is doing.
            
            var removals = cutOff.Where(o => o != cutOff.FirstOrDefault(c => c.SCHVARLENGTH == maxLength ));
            vars = vars.Except(removals);
        }

        return vars;
    }

    internal static string GetVariableName(int SCHMARKINGPRG, int VARLINE)
    {
        using (var db = new Allflex.Server.MarkingProgramDataContext(Allflex.Common.Configuration.idOneConnection))
        {
            if (db.Connection.State.ToString() == "Closed")
            {
                db.Connection.ConnectionString = "Data Source=vsdalsql08r.dallas.allflex-group.com;Trusted_Connection=no;Integrated Security =false;Initial Catalog=idOneUsa;User Id=intranetuser;Password=!ntr4n3tU5erL!v3";
                //db.Connection.ConnectionString = "Data Source=vsdevsql01.dallas.allflex-group.com;Trusted_Connection=yes;Integrated Security =false;Initial Catalog=idOneUsa;User Id=intranetuser;Password=!ntr4n3tU5erL!v3";
                db.Connection.Open();
            }
            var variables = db.MarkingBookVars.Where(o => o.SCHMARKINGPRG == SCHMARKINGPRG);
            var variable = variables.SingleOrDefault(o => o.SCHVARLINEMAP == VARLINE);
            var similars = variables.Where(o => o.SCHVTMPLTYPE.Trim() == variable.SCHVTMPLTYPE.Trim());
            if (!similars.Any()) return variable?.SCHVTMPLTYPE.Trim();
            return $"{variable.SCHVTMPLTYPE.Trim()}{variable.SCHORDER}";
        }
    }

    internal static string GetVariableDefaultValue(Allflex.Server.MarkingBookVar markingBookVar)
    {
        if (markingBookVar.SCHVTYPE.Trim() == Allflex.DataContract.VariableDisplayType.Image.ToString())
        {
            if (!string.IsNullOrWhiteSpace(markingBookVar.SCHVARIMAGE))
                return markingBookVar.SCHVARIMAGE.Trim();
        }

        return markingBookVar.SCHVARVALUE.Trim();
    }

    public static void WriteToLog(object sActivity)
    {
        string sLogFileName = "EcomWSLog_" + DateTime.Now.ToString("yyyyMMdd") + ".txt";

        string LogFile = "C:\\CIS\\Logs\\" + sLogFileName;
        if (!string.IsNullOrEmpty(LogFile))
        {
            System.IO.StreamWriter StringWriter = null;
            if (File.Exists(LogFile))
            {
                StringWriter = new System.IO.StreamWriter(LogFile, true);
            }
            else
            {
                StringWriter = new System.IO.StreamWriter(LogFile, false);
            }
            StringWriter.WriteLine("Event Log " + "\t" + DateTime.Now.ToString() + "\t" + sActivity);
            StringWriter.WriteLine("*******************************************************");
            StringWriter.Close();
            StringWriter.Dispose();
            StringWriter = null;
        }
    }

}
