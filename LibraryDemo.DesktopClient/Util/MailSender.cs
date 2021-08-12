using System.Net;
using System.Net.Mail;

namespace LibraryDemo.DesktopClient.Util
{
    class MailSender : IMailSender
    {
        #region Methods
        public void Send(string mail, string password)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("no.reply.library.demo@gmail.com", "Library.demo"),
                EnableSsl = true,
            };

            smtpClient.Send("no.reply.library.demo@gmail.com", mail, "New passwor", password);
        }
        #endregion
    }
}
