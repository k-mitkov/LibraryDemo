using LibraryDemo.Data.Models;
using System.Collections.Generic;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class ShowBooksByKeyWordViewModel : BaseViewModel
    {
        #region Declaration
        private IEnumerable<Book> books;
        #endregion

        #region Constuctor
        public ShowBooksByKeyWordViewModel(List<Book> books)
        {
            this.books = books;
        }
        #endregion
        
        #region Proparties
        public IEnumerable<Book> ListOfBooks
        {
            get
            {
                return books;
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
