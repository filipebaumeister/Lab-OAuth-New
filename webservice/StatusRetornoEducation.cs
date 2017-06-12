using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.webservice
{
    public class StatusRetornoEducation : StatusRetorno
    {
        public int id;
        public string nomeInstituicao;
        public string tipoEnsino;
        public DateTime inicio;
        public string strDtInicio;
        public DateTime? fim;
    }
}