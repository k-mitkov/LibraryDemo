using LibraryDemo.Data;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class BaseViewModel
    {
        #region Declaration
        protected IDataService context;
        #endregion

        #region Constructor
        public BaseViewModel()
        {
            context = new BusinessContext();
        }
        #endregion
    }
}
