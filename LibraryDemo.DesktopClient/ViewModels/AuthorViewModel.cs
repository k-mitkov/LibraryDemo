using LibraryDemo.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class AuthorViewModel : BaseViewModel
    {
        #region Declaration
        private IEnumerable<Author> listOfAuthors;
        #endregion

        #region Proparties
        public IEnumerable<Author> ListOfAuthors
        {
            get
            {
                if (listOfAuthors == null)
                {
                    listOfAuthors = context.GetAuthors().ToList();
                }
                return listOfAuthors;
            }
        }

        public string NameHeader
        {
            get
            {
                return content.NameHeader();
            }
        }

        public string GenderHeader
        {
            get
            {
                return content.GenderHeader();
            }
        }

        public string MailHeader
        {
            get
            {
                return content.MailHeader();
            }
        }
        #endregion
    }
}
