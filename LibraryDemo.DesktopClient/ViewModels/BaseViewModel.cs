using LibraryDemo.Data;
using LibraryDemo.DesktopClient.Resources.AppTextContent;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class BaseViewModel
    {
        #region Declaration
        protected IDataService context;
        protected IContent content;
        #endregion

        #region Constructor
        public BaseViewModel()
        {
            context = new BusinessContext();
            content = new AppContent();
        }
        #endregion
    }
}
