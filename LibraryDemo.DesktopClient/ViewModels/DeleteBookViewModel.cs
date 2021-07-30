using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.Command;
using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class DeleteBookViewModel : BaseNotifyPropertyChangedViewModel
    {
        #region Declaration
        private List<Book> books;
        private ActionCommand deleteCommand;
        private Book _sbook;
        private UserControl currentView;
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

        public List<Book> ListOfBooks
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
        #endregion

        #region Methods
        public bool CanExecuteShow(Object o)
        {
            return true;
        }

        public void Delete(Object o)
        {
            context.DeleteBook(_sbook.Id);
        }
        #endregion
    }
}
