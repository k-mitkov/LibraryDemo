using System.Net;
using System.Net.Mail;

namespace LibraryDemo.DesktopClient.Util
{
    class MailSender : IMailSender
    {
        #region Declaration
        private const string myMail = "no.reply.library.demo@gmail.com";
        private const string myPassword = "Library.demo";
        private const string host = "smtp.gmail.com";
        private const string summary = "New passwor";
        private const string masage = "Your new password :";
        #endregion

        #region Methods
        public void Send(string mail, string password)
        {
            var smtpClient = new SmtpClient(host)
            {
                Port = 587,
                Credentials = new NetworkCredential(myMail, myPassword),
                EnableSsl = true,
            };

            smtpClient.Send(myMail, mail, summary,masage + password);
        }
        #endregion
    }
}
