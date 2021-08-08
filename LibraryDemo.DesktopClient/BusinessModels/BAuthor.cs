using LibraryDemo.DesktopClient.Resources.AppTextContent;

namespace LibraryDemo.DesktopClient.BusinessModels
{
    public class BAuthor
    {
        #region Declaration
        private IContent content;
        private string gender;
        #endregion

        #region Constructor
        public BAuthor()
        {
            content = new AppContent();
        }
        #endregion

        #region Proparties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender {
            get
            {
                return content.GenderTranslate(gender);
            }
            set
            {
                gender = value;
            }
        }
        #endregion

        #region Meshods
        public override string ToString()
        {
            return Name;
        }

        //public override string ToString()
        //{
        //    return String.Format("Author[ Name: {0} Email: {1} Gender: {2} ]", Name, Email, Gender == 'm' ? "Male" : "Female");
        //}
        #endregion
    }
}
