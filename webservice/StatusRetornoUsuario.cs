using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.webservice
{
    public class StatusRetornoUsuario : StatusRetorno
    {
        public bool userExisting;
        public List<Ensino> lstEducations;
    }
}