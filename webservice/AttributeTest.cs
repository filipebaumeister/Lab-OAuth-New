using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace WebApplication1.webservice
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class AttributeTest : Attribute
    {
        public AttributeTest()
        {

        }

        

        public AttributeTest(HttpSessionState session)
        {
            return;
        }
    }
}