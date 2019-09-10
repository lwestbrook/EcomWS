using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DataList
/// </summary>
public class DataList 
{
    public DataList()
    {
        //
        // TODO: Add constructor logic here
        //

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


    }
}