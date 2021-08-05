using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class DeleteLibraryViewModel : BaseDeleteViewModel
    {
        #region Declaration
        private IEnumerable<Library> libraries;
        private Library _sLibrary;
        #endregion

        #region Constructor
        public DeleteLibraryViewModel(List<Library> libraries)
        {
            this.libraries = libraries;
        }
        #endregion

        #region Proparties
        public IEnumerable<Library> ListOfT
        {
            get
            {
                return libraries;
            }
        }

        public Library Selected
        {
            get { return _sLibrary; }
            set
            {
                _sLibrary = value;
            }
        }

        public string SelectToDeleteContent
        {
            get
            {
                return content.SelectLibrayText();
            }
        }
        #endregion

        #region Methods
        public override void Delete(Object o)
        {
            if (_sLibrary != null)
            {
                if (ErrMasage != null && !ErrMasage.Equals(content.ErrSelectLibrary()))
                {
                    if (context.DeleteLibrary(_sLibrary.Id))
                    {
                        SuccessfulOperationViewModel viewModel = new SuccessfulOperationViewModel(content.SuccesfullyDeletedLibrary());
                        SuccessfulOperationView view = new SuccessfulOperationView();
                        view.DataContext = viewModel;
                        CurentView = view;
                    }
                }
                else
                {
                    ErrMasage = content.WarningLibraryDelete();
                }
            }
            else
            {
                ErrMasage = content.ErrSelectLibrary();
            }
        }
        #endregion
    }
}
