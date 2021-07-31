using LibraryDemo.Data.Models;
using System.Collections.Generic;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class ShowBooksByKeyWordViewModel : BaseViewModel
    {
        #region Declaration
        private List<Book> books;
        #endregion

        #region Constuctor
        public ShowBooksByKeyWordViewModel(List<Book> books)
        {
            this.books = books;
        }
        #endregion
        
        #region Proparties
        public List<Book> ListOfBooks
        {
            get
            {
                return books;
            }
        }
        #endregion
    }
}
