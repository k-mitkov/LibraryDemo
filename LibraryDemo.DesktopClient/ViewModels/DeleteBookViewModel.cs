using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class DeleteBookViewModel : BaseNotifyPropertyChangedViewModel
    {
        #region Declaration
        private IEnumerable<Book> books;
        private ActionCommand deleteCommand;
        private Book _sbook;
        private UserControl currentView;
        private string errMasage;
        #endregion

        #region Constructor
        public DeleteBookViewModel(List<Book> books)
        {
            this.books = books;
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

        public IEnumerable<Book> ListOfBooks
        {
            get
            {
                return books;
            }
        }

        public Book SBook
        {
            get { return _sbook; }
            set
            {
                _sbook = value;
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
                return content.SelectBookText();
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
            if (_sbook != null)
            {
                context.DeleteBook(_sbook.Id);
                SuccessfulOperationViewModel viewModel = new SuccessfulOperationViewModel(content.SuccesfullyDeletedBook());
                SuccessfulOperationView view = new SuccessfulOperationView();
                view.DataContext = viewModel;
                CurentView = view;
            }
            else
            {
                ErrMasage = content.ErrSelectBook();
            }
        }
        #endregion
    }
}
