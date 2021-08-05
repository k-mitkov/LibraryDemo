using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class DeleteAuthorViewModel : BaseDeleteViewModel
    {
        #region Declaration
        private IEnumerable<Author> authors;
        private Author _sAuthor;
        #endregion

        #region Constructor
        public DeleteAuthorViewModel(List<Author> authors)
        {
            this.authors = authors;
        }
        #endregion

        #region Proparties
        public IEnumerable<Author> ListOfT
        {
            get
            {
                return authors;
            }
        }

        public Author Selected
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
                return content.SelectAuthorText();
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
                    if (context.DeleteAuthor(_sAuthor.Id))
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
