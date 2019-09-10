using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SkuWithCurvedText
/// </summary>
public class SkuWithCurvedText
{
    public enum CurvedTextSKU
    {
        //1=Top, 2=Bottom, 3=Top and Bottom

        GSM3            = 1,
        GSM6            = 3,
        GSM9            = 2,
        GESM3           = 1,
        GESM6           = 3,
        GESM9           = 2,
        GSF1            = 1,
        GSF2            = 3,
        GSTF1           = 1,
        GSTF2           = 3,
        GSTF3           = 1,
        HSM_M_1RT_SETS  = 1,
        HSM_TW_2RT_SETS = 4,    //(2 lines on top of each other) top
        HSM_M_1RT       = 1,    // top
        HSM_M_2RT       = 4,    // (2 lines on top of each other) top
        HSM_TW_2RT      = 4,    // (2 lines on top of each other) top
        SF_T12          = 3,    //– top & bottom
        SF_T2           = 2     //- bottom
                                //
                                // TODO: Add constructor logic here
                                //
    }

   
    
}