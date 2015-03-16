using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfRest.Model;

namespace WcfRest
{    
    [ServiceContract]
    public interface ITesteService
    {
        [OperationContract]
        [WebInvoke(Method = "POST",
        UriTemplate = "/TestePOST",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ClasseErro))]
        string TestePOST();

        [OperationContract]
        [WebInvoke(Method = "GET",
        UriTemplate = "/TesteGET",
        RequestFormat = WebMessageFormat.Json,        
        ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(ClasseErro))]
        string TesteGET();
    }
}
