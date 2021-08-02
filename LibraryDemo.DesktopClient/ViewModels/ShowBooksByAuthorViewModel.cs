using LibraryDemo.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class ShowBooksByAuthorViewModel : BaseViewModel
    {
        #region Declaration
        private Author author;
        #endregion

        #region Constructor
        public ShowBooksByAuthorViewModel(Author author)
        {
            this.author = author;
        }
        #endregion

        #region Proparties
        public IEnumerable<Book> ListOfBooks
        {
            get
            {
                return context.GetBooksByAuthorId(author.Id).ToList();
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
