using LibraryDemo.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDemo.DesktopClient.Services
{
    public interface IUserService
    {
        public bool AddNewUser(string name, string mail, string password);
        public bool LogIn(string name, string password);
        public bool UpdateUserPassword(string mail);
        public bool ValidateName(string name);
        public bool ValidateMail(string mail);
    }
}
