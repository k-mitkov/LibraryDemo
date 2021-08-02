using LibraryDemo.Data.Models;
using System.Collections.Generic;
using System.Linq;

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
        public IEnumerable<Book> ListOfBooks
        {
            get
            {
                return context.GetBooksByLibraryId(library.Id).ToList();
            }
        }

        public string TitleHeader
        {
            get
            {
                return content.TitleHeader();
            }
        }
        public string AuthorHeader
        {
            get
            {
                return content.AuthorHeader();
            }
        }
        public string PriceHeader
        {
            get
            {
                return content.PriceHeader();
            }
        }
        public string LibraryHeader
        {
            get
            {
                return content.LibraryHeader();
            }
        }
        #endregion
    }
}
