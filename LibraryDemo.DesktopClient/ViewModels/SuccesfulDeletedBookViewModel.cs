using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class SuccesfulDeletedBookViewModel : BaseViewModel
    {
        #region Proparties
        public string Information
        {
            get
            {
                return content.SuccesfullyDeletedBook();
            }
        }
        #endregion
    }
}
