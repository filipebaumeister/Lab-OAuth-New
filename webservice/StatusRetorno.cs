using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace WebApplication1.webservice
{
    public class StatusRetorno
    {
        public bool sucesso;
        public string mensagem;

        public StatusRetorno()
        {
        }

        public StatusRetorno(HttpSessionState session)
        {
            Util.WebSession.ResetTimer();
        }
    }
}