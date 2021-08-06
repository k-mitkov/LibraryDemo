using LibraryDemo.DesktopClient.BusinessModels;
using System.Collections.Generic;
using System.Linq;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class ShowLibraryViewModel : BaseViewModel
    {
        #region Declaration
        private IEnumerable<BLibrary> listOfLibraries;
        #endregion

        #region Constructor
        public ShowLibraryViewModel() { }

        public ShowLibraryViewModel(IEnumerable<BLibrary> listOfLibraries)
        {
            this.listOfLibraries = listOfLibraries;
        }
        #endregion

        #region Proparties
        public IEnumerable<BLibrary> ListOfLibraries
        {
            get
            {
                if(listOfLibraries == null)
                {
                    listOfLibraries = libraryService.GetLibraries().ToList();
                }
                return listOfLibraries;
            }
        }

        public string NameHeader
        {
            get
            {
                return content.Name();
            }
        }

        public string AddressHeader
        {
            get
            {
                return content.Address();
            }
        }
        #endregion
    }
}
