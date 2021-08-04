using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class DeleteAuthorViewModel : BaseNotifyPropertyChangedViewModel
    {
        #region Declaration
        private IEnumerable<Author> authors;
        private ActionCommand deleteCommand;
        private Author _sAuthor;
        private UserControl currentView;
        private string errMasage;
        #endregion

        #region Constructor
        public DeleteAuthorViewModel(List<Author> authors)
        {
            this.authors = authors;
        }
        #endregion

        #region Proparties
        public ActionCommand DeleteCommand
        {
            get
            {
                if (deleteCommand == null)
                {
                    deleteCommand = new ActionCommand(Delete, CanExecuteShow);
                }
                return deleteCommand;
            }
        }

        public IEnumerable<Author> ListOfAuthors
        {
            get
            {
                return authors;
            }
        }

        public Author SAuthor
        {
            get { return _sAuthor; }
            set
            {
                _sAuthor = value;
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

        public string DeleteButtonContent
        {
            get
            {
                return content.DeleteButton();
            }
        }

        public string SelectToDeleteContent
        {
            get
            {
                return content.SelectAuthorText();
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

        public void Delete(Object o)
        {
            if (_sAuthor != null)
            {
                if (context.DeleteAuthor(_sAuthor.Id))
                {
                    SuccessfulOperationViewModel viewModel = new SuccessfulOperationViewModel(content.SuccesfullyDeletedBook());
                    SuccessfulOperationView view = new SuccessfulOperationView();
                    view.DataContext = viewModel;
                    CurentView = view;
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
