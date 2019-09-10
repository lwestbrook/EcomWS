using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for SearchSku
/// </summary>
[WebService(Namespace = "https://ecomWS.allflexusa.com/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
 [System.Web.Script.Services.ScriptService]
public class SearchSku : System.Web.Services.WebService
{
    [WebMethod]
    public AllfleXML.FlexSpec.Specification GetSku(string sku)
    {
        ServicePointManager.Expect100Continue = true;
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
        Service svc = new Service();
        return svc.GenerateSpecification(sku);

    }

    [WebMethod]
    public AllfleXML.FlexSpec.Specification GetSpecification(string sku)
    {
        ServicePointManager.Expect100Continue = true;
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
        Service svc = new Service();
        return svc.GenerateSpecification(sku);
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }

}
