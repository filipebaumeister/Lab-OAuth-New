using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.SessionState;

namespace WebApplication1.webservice
{
    
    public class StatusRetornoNeedAdminRights : StatusRetorno
    {
        public bool hasAdminRights;
        public StatusRetornoNeedAdminRights()
        {

        }

        public StatusRetornoNeedAdminRights(UserNotLoggedException ex)
        {
            sucesso = false;
            hasAdminRights = false;
            mensagem = "A sua sessão expirou. Por favor logue novamente para realizar esta operação!";
        }

        public StatusRetornoNeedAdminRights(HttpSessionState session)
        {
            if (false)
            {

            }
            else
            {
                sucesso = false;
                hasAdminRights = false;
                mensagem = "A sua sessão expirou. Por favor logue novamente para realizar esta operação!";
                return;
                throw new UserNotLoggedException();
            }
        }
    }
}
