using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class SearchBookViewModel : BaseNotifyPropertyChangedViewModel
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
                    searchCommand = new ActionCommand(Search, CanExecuteShow);
                }
                return searchCommand;
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

        public string SelectContent
        {
            get
            {
                return content.SearchTitleText();
            }
        }

        public string SearchButtonContent
        {
            get
            {
                return content.SearchButton();
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
        public void Search(Object o)
        {
            List<Book> books = context.SearchForBooks(_keyWord).ToList();
            if (books.Count == 0)
            {
                ErrMasage = content.ErrBooksNotFound();
                CurentView = null;
            }
            else
            {
                ErrMasage = "";
                ShowBooksViewModel viewModel = new ShowBooksViewModel(books);
                ShowBooksView view = new ShowBooksView();
                view.DataContext = viewModel;
                CurentView = view;
            }
        }
        #endregion
    }
}
