using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class AddLibraryViewModel : BaseNotifyPropertyChangedViewModel
    {
        #region Declaration
        private string _name;
        private string _address;
        private ActionCommand addCommand;
        private UserControl currentView;
        private string errMasage;
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

        public ActionCommand AddCommand
        {
            get
            {
                if (addCommand == null)
                {
                    addCommand = new ActionCommand(Add, CanExecuteShow);
                }
                return addCommand;
            }
        }

        public UserControl CurentView
        {
            get
            {
                return currentView;
            }

            set
            {
                currentView = value;
                OnPropertyChanged();
            }
        }

        public string NameContent
        {
            get
            {
                return content.NameHeader();
            }
        }

        public string AddressContent
        {
            get
            {
                return content.AddressHeader();
            }
        }

        public string AddButtonContent
        {
            get
            {
                return content.AddButton();
            }
        }

        public string ErrMasage
        {
            get
            {
                return errMasage;
            }
            set
            {
                errMasage = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Methods
        public bool CanExecuteShow(Object o)
        {
            return true;
        }

        public void Add(Object o)
        {
            if (ValidateInput())
            {

                var library = new Library()
                {
                    Name = _name,
                    Address = _address
                };

                context.AddNewLibrary(library);
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
