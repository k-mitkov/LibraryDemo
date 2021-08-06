using LibraryDemo.DesktopClient.BusinessModels;
using System.Collections.Generic;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class ShowAuthorsViewModel : BaseViewModel
    {
        #region Declaration
        private IEnumerable<BAuthor> listOfAuthors;
        #endregion

        #region Constructor
        public ShowAuthorsViewModel() { }

        public ShowAuthorsViewModel(IEnumerable<BAuthor> listOfAuthors)
        {
            this.listOfAuthors = listOfAuthors;
        }
        #endregion

        #region Proparties
        public IEnumerable<BAuthor> ListOfAuthors
        {
            get
            {
                if (listOfAuthors == null)
                {
                    listOfAuthors = authorService.GetAuthors();
                }
                return listOfAuthors;
            }
        }

        public string NameHeader
        {
            get
            {
                return content.Name();
            }
        }

        public string GenderHeader
        {
            get
            {
                return content.Gender();
            }
        }

        public string MailHeader
        {
            get
            {
                return content.Mail();
            }
        }
        #endregion
    }
}
