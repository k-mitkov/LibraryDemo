using LibraryDemo.DesktopClient.BusinessModels;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class DeleteLibraryViewModel : BaseDeleteViewModel
    {
        #region Declaration
        private IEnumerable<BLibrary> libraries;
        private BLibrary _sLibrary;
        #endregion

        #region Constructor
        public DeleteLibraryViewModel(List<BLibrary> libraries)
        {
            this.libraries = libraries;
        }
        #endregion

        #region Proparties
        public IEnumerable<BLibrary> ListOfT
        {
            get
            {
                return libraries;
            }
        }

        public BLibrary Selected
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
                return content.SelectLibray();
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
                    if (libraryService.Delete(_sLibrary.Id))
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
