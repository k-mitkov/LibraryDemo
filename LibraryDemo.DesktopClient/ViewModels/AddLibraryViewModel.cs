using LibraryDemo.DesktopClient.Views;
using System;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class AddLibraryViewModel : BaseAddViewModel
    {
        #region Declaration
        private string _name;
        private string _address;
        #endregion

        #region Proparties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string NameContent
        {
            get
            {
                return content.Name();
            }
        }

        public string AddressContent
        {
            get
            {
                return content.Address();
            }
        }

        public string AddButtonContent
        {
            get
            {
                return content.Add();
            }
        }
        #endregion

        #region Methods
        public override void Add(Object o)
        {
            if (ValidateInput())
            {
                libraryService.Add(_name, _address);

                SuccessfulOperationViewModel viewModel = new SuccessfulOperationViewModel(content.SuccessfullyAddedLibrary());
                SuccessfulOperationView view = new SuccessfulOperationView();
                view.DataContext = viewModel;
                CurentView = view;
            }
            else
            {
                ErrMasage = errMasage;
            }
        }

        private bool ValidateInput()
        {
            if (_name != null && _name.Length > 2)
            {
                if (_address != null && _address.Length > 5)
                {
                    return true;
                }
                errMasage = content.ErrSelectAddress();
                return false;
            }
            errMasage = content.ErrSelectName();
            return false;
        }
        #endregion
    }
}
