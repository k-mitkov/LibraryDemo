using LibraryDemo.Data;
using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.ExceptionsLogger;
using LibraryDemo.DesktopClient.Util;
using System;

namespace LibraryDemo.DesktopClient.Services.Impl
{
    public class UserSrvice : IUserService
    {
        #region Declaration
        private IDataService dataService;
        private IMailSender mailSender;
        #endregion

        #region Constructor
        public UserSrvice()
        {
            dataService = new BusinessContext();
            mailSender = new MailSender();
        }
        #endregion

        #region Methods
        public bool AddNewUser(string name, string mail, string password)
        {
            try
            {
                var user = new User
                {
                    Name = name,
                    Mail = mail,
                    Password = EncryptPassword(password)
                };
                dataService.AddNewUser(user);
                return true;
            }
            catch (Exception e)
            {
                ExceptionLogger.LoggException(e);
                return false;
            }
        }

        public bool LogIn(string name, string password)
        {
            try
            {
                var user = dataService.GetUserByName(name);
                if (user != null)
                {
                    if (user.Password.Equals(EncryptPassword(password)))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception e)
            {
                ExceptionLogger.LoggException(e);
                return false;
            }
        }

        public bool UpdateUserPassword(string mail)
        {
            try
            {
                var user = dataService.GetUserByMail(mail);
                if (user != null)
                {
                    mailSender.Send(mail, "aB3!fK5#");
                    user.Password = EncryptPassword("aB3!fK5#");
                    dataService.UpdateUserPassword(user);
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                ExceptionLogger.LoggException(e);
                return false;
            }
        }

        public bool ValidateMail(string mail)
        {
            try
            {
                return dataService.GetUserByMail(mail) == null;
            }
            catch (Exception e)
            {
                ExceptionLogger.LoggException(e);
                return false;
            }
        }

        public bool ValidateName(string name)
        {
            try
            {
                return dataService.GetUserByName(name) == null;
            }
            catch (Exception e)
            {
                ExceptionLogger.LoggException(e);
                return false;
            }
        }

        private string EncryptPassword(string password)
        {
            try
            {
                byte[] data = System.Text.Encoding.ASCII.GetBytes(password);
                data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
                return System.Text.Encoding.ASCII.GetString(data);
            }
            catch (Exception e)
            {
                ExceptionLogger.LoggException(e);
                return null;
            }
        }
        #endregion
    }
}
