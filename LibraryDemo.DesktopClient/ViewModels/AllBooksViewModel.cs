using LibraryDemo.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class AllBooksViewModel : BaseViewModel
    {
        #region Declarition
        #endregion

        #region Proparties
        public IEnumerable<Book> ListOfBooks
        {
            get
            {
                return context.GetBooks().ToList();
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
