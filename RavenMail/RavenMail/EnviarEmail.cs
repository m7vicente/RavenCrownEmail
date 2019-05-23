using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Configuration;
using System.Net.Mail;

namespace RavenMail
{
    public class EnviarEmail
    {


        public void enviarEmail()
        {

            MailMessage mail = new MailMessage();

            mail.To.Add("henri.guimaraes2015@gmail.com");

            mail.From = new MailAddress("darkhuntergflad@gmail.com", "Henrique Guimarães", System.Text.Encoding.UTF8);

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