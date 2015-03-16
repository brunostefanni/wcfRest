using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfRest.Model
{
    [DataContract]
    public class ClasseErro
    {
        [DataMember]
        public int CodError { get; set; }
        [DataMember]
        public string ErrorMessage { get; set; }
        [DataMember]
        public string ErrorDetails { get; set; }
    }
}