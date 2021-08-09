using System;
using System.IO;

namespace LibraryDemo.DesktopClient.ExceptionsLogger
{
    public class ExceptionLogger
    {
        #region Methods
        public static void LoggException(Exception e)
        {
            try
            {
                using (StreamWriter file = new StreamWriter("C:\\ProgramData\\Microinvest\\LibraryDemo\\Exceptions.txt", append: true))
                {
                    file.WriteLine(string.Format("DataTime: {1}\nException: {0}\n", e, DateTime.Now));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        #endregion
    }
}
