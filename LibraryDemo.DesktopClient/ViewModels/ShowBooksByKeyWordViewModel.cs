using LibraryDemo.Data.Models;
using System.Collections.Generic;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class ShowBooksByKeyWordViewModel : BaseViewModel
    {
        #region Declaration
        private string keyWord;
        #endregion

        #region Constuctor
        public ShowBooksByKeyWordViewModel(string keyWord)
        {
            this.keyWord = keyWord;
        }
        #endregion
        
        #region Proparties
        public List<Book> ListOfBooks
        {
            get
            {
                return context.SearchForBooks(keyWord);
            }
        }
        #endregion
    }
}
