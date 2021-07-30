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
            AllBooksViewModel viewModel = new AllBooksViewModel();
            AllBooksView view = new AllBooksView();
            view.DataContext = viewModel;
            CurentView = view;

        }

        public void BooksByAuthor(Object o)
        {
            BooksByAuthorViewModel viewModel = new BooksByAuthorViewModel();
            BooksByAuthorView view = new BooksByAuthorView();
            view.DataContext = viewModel;
            CurentView = view;

        }

        public void BooksByLibrary(Object o)
        {
            BooksByLibraryViewModel viewModel = new BooksByLibraryViewModel();
            BooksByLibraryView view = new BooksByLibraryView();
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
            SearchBookView view = new SearchBookView();
            view.DataContext = viewModel;
            CurentView = view;
        }

        public void DeleteBook(Object o)
        {
            SearchBookToDeleteViewModel viewModel = new SearchBookToDeleteViewModel();
            SearchBookView view = new SearchBookView();
            view.DataContext = viewModel;
            CurentView = view;
        }
        #endregion
    }
}
