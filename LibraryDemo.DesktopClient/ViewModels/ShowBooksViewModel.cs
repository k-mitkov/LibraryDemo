using LibraryDemo.DesktopClient.BusinessModels;
using System.Collections.Generic;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class ShowBooksViewModel : BaseNotifyPropertyChangedViewModel
    {
        #region Declaration
        private IEnumerable<BBook> books;
        #endregion

        #region Constuctor
        public ShowBooksViewModel() { }

        public ShowBooksViewModel(IEnumerable<BBook> books)
        {
            this.books = books;
        }
        #endregion

        #region Proparties
        public IEnumerable<BBook> ListOfBooks
        {
            get
            {
                if (books == null)
                {
                    books = bookService.GetBooks();
                }
                return books;
            }
        }

        public string TitleHeader
        {
            get
            {
                return content.Title();
            }
        }
        public string AuthorHeader
        {
            get
            {
                return content.Author();
            }
        }
        public string PriceHeader
        {
            get
            {
                return content.Price();
            }
        }
        public string LibraryHeader
        {
            get
            {
                return content.Library();
            }
        }
        #endregion
    }
}
