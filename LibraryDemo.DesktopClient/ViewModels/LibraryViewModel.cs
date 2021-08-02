using LibraryDemo.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class LibraryViewModel : BaseViewModel
    {
        #region Declaration
        private IEnumerable<Library> listOfLibraries;
        #endregion

        #region Proparties
        public IEnumerable<Library> ListOfLibraries
        {
            get
            {
                if(listOfLibraries == null)
                {
                    listOfLibraries = context.GetLibraries().ToList();
                }
                return listOfLibraries;
            }
        }

        public string NameHeader
        {
            get
            {
                return content.NameHeader();
            }
        }

        public string AddressHeader
        {
            get
            {
                return content.AddressHeader();
            }
        }
        #endregion
    }
}
