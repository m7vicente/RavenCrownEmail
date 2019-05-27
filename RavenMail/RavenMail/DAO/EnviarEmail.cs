using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Configuration;
using System.Net.Mail;
using System.Configuration;
using RavenMail.Model;
using System.Data.SqlClient;
using System.Data;

namespace RavenMail
{
    public class EnviarEmail
    {
        public static String emailDoUsuario(int id)
        {
            SqlConnection conn = new SqlConnection(@"Server=tcp:robertocadillac.database.windows.net,1433;Initial Catalog=DANTE;Persist Security Info=False;User ID=orei;Password=3u.t3.4amo;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            using (conn)
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(@"SELECT email_usuario FROM tbd_usuario 
                                                    WHERE id_usuario = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        dr.Read();
                        return dr["email_usuario"].ToString();
                    }
                }
            }
        }

        [System.Web.Services.WebMethod]
        public static void enviarEmail(int idPrestador, int idContratante)
        {

            MailMessage mail = new MailMessage();

            //mail.To.Add("henri.guimaraes2015@gmail.com");
            mail.To.Add(emailDoUsuario(idPrestador));
            mail.To.Add(emailDoUsuario(idContratante));

            mail.From = new MailAddress("ravencrownteste@gmail.com", "Ranve Crown", System.Text.Encoding.UTF8);

            mail.Subject = "Assunto:Este e-mail é um teste do Asp.Net";

            mail.SubjectEncoding = System.Text.Encoding.UTF8;

            mail.Body = "O henrique é foda";

            mail.BodyEncoding = System.Text.Encoding.UTF8;

            mail.IsBodyHtml = true;

            mail.Priority = MailPriority.High; //Prioridade do E-Mail



            SmtpClient client = new SmtpClient();  //Adicionando as credenciais do seu e-mail e senha:

            client.UseDefaultCredentials = false;

            client.EnableSsl = true; //Gmail trabalha com Server Secured Layer

            client.Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["login"], ConfigurationManager.AppSettings["senha"]);


            client.Port = 587; // Esta porta é a utilizada pelo Gmail para envio

            client.Host = "smtp.gmail.com"; //Definindo o provedor que irá disparar o e-mail

            try

            {

                client.Send(mail);

                //respostaEnvioLabel.Text = "Envio do E-mail com sucesso";

            }

            catch (Exception ex)

            {

                //respostaEnvioLabel.Text = "Ocorreu um erro ao enviar:" + ex.Message;

            }

        }

    }
}