using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDemo.DesktopClient.Util
{
    public interface IMailSender
    {
        public void Send(string mail, string password);
    }
}
