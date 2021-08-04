using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class SuccessfulOperationViewModel : BaseViewModel
    {
        #region Declaration
        private string masage;
        #endregion

        #region Constructor
        public SuccessfulOperationViewModel (string masage)
        {
            this.masage = masage;
        }
        #endregion

        #region Proparties
        public string Information
        {
            get
            {
                if (masage != null)
                {
                    return masage;
                }
                return "";
            }
        }
        #endregion
    }
}
