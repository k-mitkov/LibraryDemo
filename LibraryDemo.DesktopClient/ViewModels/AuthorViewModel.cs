using LibraryDemo.Data.Models;
using System.Collections.Generic;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class AuthorViewModel : BaseViewModel
    {
        #region Declaration
        private List<Author> listOfAuthors;
        #endregion

        #region Proparties
        public List<Author> ListOfAuthors
        {
            get
            {
                listOfAuthors = context.GetAuthors();
                return listOfAuthors;
            }
        }
        #endregion
    }
}
