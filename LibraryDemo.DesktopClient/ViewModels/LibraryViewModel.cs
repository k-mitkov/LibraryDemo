using LibraryDemo.Data.Models;
using System.Collections.Generic;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class LibraryViewModel : BaseViewModel
    {
        #region Declaration
        private List<Library> listOfLibraries;
        #endregion

        #region Proparties
        public List<Library> ListOfLibraries
        {
            get
            {
                listOfLibraries = context.GetLibraries();
                return listOfLibraries;
            }
        }
        #endregion
    }
}
