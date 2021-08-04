using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class SearchAuthorViewModel : BaseNotifyPropertyChangedViewModel
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

        public string SelectContent
        {
            get
            {
                return content.SearchByName();
            }
        }

        public string SearchButtonContent
        {
            get
            {
                return content.SearchButton();
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
        public void Search(Object o)
        {
            List<Author> authors = context.SearchForAutors(_keyWord).ToList();
            if (authors.Count == 0)
            {
                ErrMasage = content.ErrAuthorNotFound();
                CurentView = null;
            }
            else
            {
                ErrMasage = "";
                ShowAuthorsViewModel viewModel = new ShowAuthorsViewModel(authors);
                ShowAuthorsView view = new ShowAuthorsView();
                view.DataContext = viewModel;
                CurentView = view;
            }
        }
        #endregion
    }
}
