using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Script.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RavenMail
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        [System.Web.Services.WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json,UseHttpGet = false)]
        public static bool SandEmail(int idPrestador, int idConsumidor)
        {
            EnviarEmail enviarEmail = new EnviarEmail();

            return enviarEmail.enviarEmail(idPrestador, idConsumidor);
        }
    }
}