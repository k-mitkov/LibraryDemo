using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class BookViewModel : BaseNotifyPropertyChangedViewModel
    {
        #region Declaration
        private ActionCommand allBooksCommand;
        private ActionCommand booksByAuthorCommand;
        private ActionCommand booksByLibraryCommand;
        private ActionCommand addBookCommand;
        private ActionCommand searchBookCommand;
        private ActionCommand deleteBookCommand;
        private UserControl currentView;
        #endregion

        #region Proparties
        public ActionCommand AllBooksCommand
        {
            get
            {
                if (allBooksCommand == null)
                {
                    allBooksCommand = new ActionCommand(AllBooks, CanExecuteShow);
                }
                return allBooksCommand;
            }
        }

        public ActionCommand BooksByAuthorCommand
        {
            get
            {
                if (booksByAuthorCommand == null)
                {
                    booksByAuthorCommand = new ActionCommand(BooksByAuthor, CanExecuteShow);
                }
                return booksByAuthorCommand;
            }
        }

        public ActionCommand BooksByLibraryCommand
        {
            get
            {
                if (booksByLibraryCommand == null)
                {
                    booksByLibraryCommand = new ActionCommand(BooksByLibrary, CanExecuteShow);
                }
                return booksByLibraryCommand;
            }
        }

        public ActionCommand AddBookCommand
        {
            get
            {
                if (addBookCommand == null)
                {
                    addBookCommand = new ActionCommand(AddBook, CanExecuteShow);
                }
                return addBookCommand;
            }
        }

        public ActionCommand SearchBookCommand
        {
            get
            {
                if (searchBookCommand == null)
                {
                    searchBookCommand = new ActionCommand(SearchBook, CanExecuteShow);
                }
                return searchBookCommand;
            }
        }

        public ActionCommand DeleteBookCommand
        {
            get
            {
                if (deleteBookCommand == null)
                {
                    deleteBookCommand = new ActionCommand(DeleteBook, CanExecuteShow);
                }
                return deleteBookCommand;
            }
        }

        public string AllBooksButtonContent
        {
            get
            {
                return content.AllBooksButton();
            }
        }

        public string BooksByAuthorButtonContent
        {
            get
            {
                return content.ByAuthorsButton();
            }
        }

        public string BooksByLibraryButtonContent
        {
            get
            {
                return content.ByLibrariesButton();
            }
        }

        public string SearchBookButtonContent
        {
            get
            {
                return content.SearchBookButton();
            }
        }

        public string AddBookButtonContent
        {
            get
            {
                return content.AddBookButton();
            }
        }

        public string DeleteBookButtonContent
        {
            get
            {
                return content.DeleteBookButton();
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

        public void AllBooks(Object o)
        {
            ShowBooksViewModel viewModel = new ShowBooksViewModel();
            ShowBooksView view = new ShowBooksView();
            view.DataContext = viewModel;
            CurentView = view;

        }

        public void BooksByAuthor(Object o)
        {
            BooksByAuthorViewModel viewModel = new BooksByAuthorViewModel();
            BooksByView view = new BooksByView();
            view.DataContext = viewModel;
            CurentView = view;

        }

        public void BooksByLibrary(Object o)
        {
            BooksByLibraryViewModel viewModel = new BooksByLibraryViewModel();
            BooksByView view = new BooksByView();
            view.DataContext = viewModel;
            CurentView = view;
        }

        public void AddBook(Object o)
        {
            AddBookViewModel viewModel = new AddBookViewModel();
            AddBookView view = new AddBookView();
            view.DataContext = viewModel;
            CurentView = view;
        }

        public void SearchBook(Object o)
        {
            SearchBookViewModel viewModel = new SearchBookViewModel();
            SearchView view = new SearchView();
            view.DataContext = viewModel;
            CurentView = view;
        }

        public void DeleteBook(Object o)
        {
            SearchBookToDeleteViewModel viewModel = new SearchBookToDeleteViewModel();
            SearchView view = new SearchView();
            view.DataContext = viewModel;
            CurentView = view;
        }
        #endregion
    }
}
