using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Winner
{
     public class SendMail
    {
        public    async Task< string> SendEmailMessage(string body, string subject, List<string> toList)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(ConfigurationManager.AppSettings["MailHost"]);

                mail.From = new System.Net.Mail.MailAddress(ConfigurationManager.AppSettings["winner"], "WINNER HYDRAULICS AUSTRALIA PTY LTD");
                foreach (var emailId in toList)
                {
                    mail.To.Add(emailId);
                }

                mail.Subject = subject;
                mail.Body = body;
                mail.Priority = MailPriority.High;

                mail.IsBodyHtml = true;
                SmtpServer.Port = 25;
                //SmtpServer.Credentials = SmtpServer.Creden
                //SmtpServer.Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["Account"],
                //ConfigurationManager.AppSettings["Password"]);//"PKf7xWx3kNeAoY4"
                //SmtpServer.EnableSsl = false;
                SmtpServer.UseDefaultCredentials = true;
                SmtpServer.Send(mail);
                System.Web.HttpContext.Current.Response.Redirect("/Home/EmailConfirmation");


                return "sent";
                //MailMessage mMailMessage = new MailMessage();

                //// Set the sender address of the mail message
                //mMailMessage.From = new MailAddress("gavin@itsoftserve.com.au");
                //// Set the recepient address of the mail message
                //foreach (var emailId in toList)
                //{
                //    mMailMessage.To.Add(new MailAddress(emailId));
                //}


                //// Check if the bcc value is null or an empty string
                ////if ((bcc != null) && (bcc != string.Empty))
                ////{
                ////    // Set the Bcc address of the mail message
                ////    mMailMessage.Bcc.Add(new MailAddress(bcc));
                ////}      // Check if the cc value is null or an empty value
                ////if ((cc != null) && (cc != string.Empty))
                ////{
                ////    // Set the CC address of the mail message
                ////    mMailMessage.CC.Add(new MailAddress(cc));
                ////}       // Set the subject of the mail message

               
                //mMailMessage.Subject = subject;
                //// Set the body of the mail message
                //mMailMessage.Body = body;
             


                //// Set the format of the mail message body as HTML
                //mMailMessage.IsBodyHtml = true;
                //// Set the priority of the mail message to normal
                //mMailMessage.Priority = MailPriority.Normal;

                //// Instantiate a new instance of SmtpClient
                //SmtpClient mSmtpClient = new SmtpClient();
                //mSmtpClient.UseDefaultCredentials = true;
                //// Send the mail message
                //mSmtpClient.Send(mMailMessage);
                return "sent";
            }
            catch (SmtpException ex)
            { 
                return ex.Message;
            }
        }
    }
}
