using LibraryDemo.Data.Models;
using System.Collections.Generic;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class AllBooksViewModel : BaseViewModel
    {
        #region Proparties
        public List<Book> ListOfBooks
        {
            get
            {
                return context.GetBooks();
            }
        }
        #endregion
    }
}
