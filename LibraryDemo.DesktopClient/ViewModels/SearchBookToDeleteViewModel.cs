using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class SearchBookToDeleteViewModel : BaseNotifyPropertyChangedViewModel
    {
        #region Declaration 
        private ActionCommand searchCommand;
        private string _keyWord;
        private UserControl currentView;
        private string errMasage;
        #endregion

        #region Proparties 
        public ActionCommand SearchCommand
        {
            get
            {
                if (searchCommand == null)
                {
                    searchCommand = new ActionCommand(SearchToDelete, CanExecuteShow);
                }
                return searchCommand;
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
        public string KeyWord
        {
            get { return _keyWord; }
            set
            {
                _keyWord = value;
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

        public void SearchToDelete(Object o)
        {
            List<Book> books = context.SearchForBooks(_keyWord);
            if (books.Count!=0)
            {
                ErrMasage = "";
                DeleteBookViewModel viewModel = new DeleteBookViewModel(books);
                DeleteBookView view = new DeleteBookView();
                view.DataContext = viewModel;
                CurentView = view;
            }
            else
            {
                ErrMasage = "Не е намерена книга!";
                CurentView = null;
            }

        }
        #endregion
    }
}
