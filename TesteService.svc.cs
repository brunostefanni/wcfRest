using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfRest
{
    public class TesteService : ITesteService
    {
        public string TestePOST()
        {
            try
            {
                return "Testado POST";
            }
            catch (Exception ex)
            {
                Model.ClasseErro classeErro = new Model.ClasseErro() { 
                                                            CodError = 1, 
                                                            ErrorMessage = "Erro ao executar serviço. Tente novamente mais tarde.",
                                                            ErrorDetails = ex.Message};                
                throw new WebFaultException<Model.ClasseErro>(classeErro, System.Net.HttpStatusCode.BadRequest);
            }
        }

        public string TesteGET()
        {
            try
            {
                return "Testado GET";
            }
            catch (Exception ex)
            {
                Model.ClasseErro classeErro = new Model.ClasseErro()
                {
                    CodError = 1,
                    ErrorMessage = "Erro ao executar serviço. Tente novamente mais tarde.",
                    ErrorDetails = ex.Message
                };
                throw new WebFaultException<Model.ClasseErro>(classeErro, System.Net.HttpStatusCode.BadRequest);
            }
        }
    }
}
