using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class SuccessfulAddedBookViewModel : BaseViewModel
    {
        #region Proparties
        public string Information
        {
            get
            {
                return content.SuccessfullyAddedBook();
            }
        }
        #endregion
    }
}
