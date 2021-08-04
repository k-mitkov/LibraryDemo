using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class AuthorViewModel : BaseNotifyPropertyChangedViewModel
    {
        #region Declaration
        private ActionCommand allAuthorsCommand;
        private ActionCommand searchAuthorCommand;
        private ActionCommand addAuthorCommand;
        private ActionCommand deleteAuthorCommand;
        private UserControl currentView;
        #endregion

        #region Proparties
        public ActionCommand AllAuthorsCommand
        {
            get
            {
                if (allAuthorsCommand == null)
                {
                    allAuthorsCommand = new ActionCommand(AllAuthors, CanExecuteShow);
                }
                return allAuthorsCommand;
            }
        }

        public ActionCommand SearchAuthorCommand
        {
            get
            {
                if (searchAuthorCommand == null)
                {
                    searchAuthorCommand = new ActionCommand(Search, CanExecuteShow);
                }
                return searchAuthorCommand;
            }
        }

        public ActionCommand AddAuthorCommand
        {
            get
            {
                if (addAuthorCommand == null)
                {
                    addAuthorCommand = new ActionCommand(Add, CanExecuteShow);
                }
                return addAuthorCommand;
            }
        }

        public ActionCommand DeleteAuthorCommand
        {
            get
            {
                if (deleteAuthorCommand == null)
                {
                    deleteAuthorCommand = new ActionCommand(Delete, CanExecuteShow);
                }
                return deleteAuthorCommand;
            }
        }

        public string AllAuthorsButtonContent
        {
            get
            {
                return content.AllAuthors();
            }
        }

        public string SearchAuthorButtonContent
        {
            get
            {
                return content.SearchAuthor();
            }
        }

        public string AddAuthorButtonContent
        {
            get
            {
                return content.AddAuthor();
            }
        }

        public string DeleteAuthorButtonContent
        {
            get
            {
                return content.DeleteAuthor();
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

        public void AllAuthors(Object o)
        {
            ShowAuthorsViewModel viewModel = new ShowAuthorsViewModel();
            ShowAuthorsView view = new ShowAuthorsView();
            view.DataContext = viewModel;
            CurentView = view;
        }
        public void Search(Object o)
        {
            SearchAuthorViewModel viewModel = new SearchAuthorViewModel();
            SearchView view = new SearchView();
            view.DataContext = viewModel;
            CurentView = view;
        }
        public void Add(Object o)
        {
            AddAuthorViewModel viewModel = new AddAuthorViewModel();
            AddAuthorView view = new AddAuthorView();
            view.DataContext = viewModel;
            CurentView = view;
        }
        public void Delete(Object o)
        {
            SearchAuthorToDeleteViewModel viewModel = new SearchAuthorToDeleteViewModel();
            SearchView view = new SearchView();
            view.DataContext = viewModel;
            CurentView = view;
        }
        #endregion
    }
}
