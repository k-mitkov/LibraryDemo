using LibraryDemo.Data.Models;
using System.Collections.Generic;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class ShowBooksByLibraryViewModel : BaseViewModel
    {
        #region Declaration
        private Library library;
        #endregion

        #region Constructor
        public ShowBooksByLibraryViewModel(Library library)
        {
            this.library = library;
        }
        #endregion

        #region Proparties
        public List<Book> ListOfBooks
        {
            get
            {
                return context.GetBooksByLibraryId(library.Id);
            }
        }
        #endregion
    }
}
