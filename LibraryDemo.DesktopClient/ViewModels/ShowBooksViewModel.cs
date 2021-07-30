using LibraryDemo.Data.Models;
using System.Collections.Generic;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class ShowBooksViewModel : BaseViewModel
    {
        #region Declaration
        private Author author;
        #endregion

        #region Constructor
        public ShowBooksViewModel(Author author)
        {
            this.author = author;
        }
        #endregion

        #region Proparties
        public List<Book> ListOfBooks
        {
            get
            {
                return context.GetBooksByAuthorId(author.Id);
            }
        }
        #endregion
    }
}
