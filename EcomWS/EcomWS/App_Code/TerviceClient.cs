using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for erviceClient
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class TerviceClient : System.Web.Services.WebService
{
    [WebMethod]
    public AllfleXML.FlexSpec.Specification GenerateSpec(string sku)
    {
        //
        // TODO: Add constructor logic here
        //
        Service svc = new Service();
        return svc.GenerateSpecification(sku);
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }

}
