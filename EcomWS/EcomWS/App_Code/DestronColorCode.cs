using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/// <summary>
/// Summary description for DestronColorCode
/// </summary>
public class DestronColorCode
{
    public Dictionary<string, string> CreateDestronDictionary()
    {
        Dictionary<string, string> DestronColorCode = new Dictionary<string, string>();
        DestronColorCode.Add("PINK", "00");
        DestronColorCode.Add("ORANGE", "01");
        DestronColorCode.Add("YELLOW", "02");
        DestronColorCode.Add("WHITE", "03"); ;
        DestronColorCode.Add("PURPLE", "04");
        DestronColorCode.Add("RED", "05");
        DestronColorCode.Add("BLUE", "06");
        DestronColorCode.Add("GREEN", "07");
        DestronColorCode.Add("BLACK", "08");
        DestronColorCode.Add("GRAY", "09");
        DestronColorCode.Add("TAN", "10");
        DestronColorCode.Add("AQUA", "11");
        DestronColorCode.Add("GOLD", "12");
        DestronColorCode.Add("NEONGREEN", "31");


        return DestronColorCode;
    }

}

