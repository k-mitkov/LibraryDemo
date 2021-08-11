using System;
using System.IO;

namespace LibraryDemo.DesktopClient.ExceptionsLogger
{
    public class ExceptionLogger
    {
        #region Methods
        public static void LoggException(Exception e)
        {
            string path = "C:\\ProgramData\\Microinvest\\LibraryDemo";
            string fileName = "Exceptions.txt";
            if (!Directory.Exists(path)){
                Directory.CreateDirectory(path);
            }
            try
            {
                using (StreamWriter file = new StreamWriter(path + "\\" + fileName, append: true))
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
