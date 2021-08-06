using LibraryDemo.DesktopClient.BusinessModels;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class DeleteAuthorViewModel : BaseDeleteViewModel
    {
        #region Declaration
        private IEnumerable<BAuthor> authors;
        private BAuthor _sAuthor;
        #endregion

        #region Constructor
        public DeleteAuthorViewModel(List<BAuthor> authors)
        {
            this.authors = authors;
        }
        #endregion

        #region Proparties
        public IEnumerable<BAuthor> ListOfT
        {
            get
            {
                return authors;
            }
        }

        public BAuthor Selected
        {
            get { return _sAuthor; }
            set
            {
                _sAuthor = value;
            }
        }

        public string SelectToDeleteContent
        {
            get
            {
                return content.SelectAuthor();
            }
        }
        #endregion

        #region Methods
        public override void Delete(Object o)
        {
            if (_sAuthor != null)
            {
                if (ErrMasage != null && !ErrMasage.Equals(content.ErrSelectAuthor()))
                {
                    if (authorService.Delete(_sAuthor.Id))
                    {
                        SuccessfulOperationViewModel viewModel = new SuccessfulOperationViewModel(content.SuccesfullyDeletedAuthor());
                        SuccessfulOperationView view = new SuccessfulOperationView();
                        view.DataContext = viewModel;
                        CurentView = view;
                    }
                }
                else
                {
                    ErrMasage = content.WarningAuthorDelete();
                }
            }
            else
            {
                ErrMasage = content.ErrSelectAuthor();
            }
        }
        #endregion
    }
}
