using LibraryDemo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class ShowBooksViewModel : BaseNotifyPropertyChangedViewModel
    {
        #region Declaration
        private IEnumerable<Book> books;
        #endregion

        #region Constuctor
        public ShowBooksViewModel() { }

        public ShowBooksViewModel(IEnumerable<Book> books)
        {
            this.books = books;
        }
        #endregion

        #region Proparties
        public IEnumerable<Book> ListOfBooks
        {
            get
            {
                if (books == null)
                {
                    books = context.GetBooks().ToList();
                }
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
