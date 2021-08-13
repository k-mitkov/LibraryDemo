using LibraryDemo.Data;
using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.ExceptionsLogger;
using LibraryDemo.DesktopClient.Util;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

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
                    string password = GeneratePassword();
                    mailSender.Send(mail, password);
                    user.Password = EncryptPassword(password);
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
                byte[] data = Encoding.ASCII.GetBytes(password);
                data = new SHA256Managed().ComputeHash(data);
                return Encoding.ASCII.GetString(data);
            }
            catch (Exception e)
            {
                ExceptionLogger.LoggException(e);
                return null;
            }
        }

        private string GeneratePassword()
        {
            const string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            const string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numbers = "1234567890";
            const string specialSymbols = "#?!@$%^&*-";
            const string allChars = lowerCase + upperCase + numbers + specialSymbols;
            List<string> strings = new List<string>();
            strings.Add(lowerCase);
            strings.Add(upperCase);
            strings.Add(numbers);
            strings.Add(specialSymbols);
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (strings.Count > 0)
            {
                string s = strings[rnd.Next(strings.Count)];
                res.Append(s[rnd.Next(s.Length)]);
                strings.Remove(s);
            }
            for(int i = 0; i < 4; i++)
            {
                res.Append(allChars[rnd.Next(allChars.Length)]);
            }
            return res.ToString();
        }
        #endregion
    }
}
