using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class BookMenuViewModel : BaseMenuViewModel
    {
        #region Declaration
        private ActionCommand booksByAuthorCommand;
        private ActionCommand booksByLibraryCommand;
        #endregion

        #region Proparties
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
        public string ShowAllButtonContent
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

        public string SearchButtonContent
        {
            get
            {
                return content.SearchBookButton();
            }
        }

        public string AddButtonContent
        {
            get
            {
                return content.AddBookButton();
            }
        }

        public string DeleteButtonContent
        {
            get
            {
                return content.DeleteBookButton();
            }
        }
        #endregion

        #region Methods
        public override void ShowAll(Object o)
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

        public override void Add(Object o)
        {
            AddBookViewModel viewModel = new AddBookViewModel();
            AddBookView view = new AddBookView();
            view.DataContext = viewModel;
            CurentView = view;
        }

        public override void Search(Object o)
        {
            SearchBookViewModel viewModel = new SearchBookViewModel();
            SearchView view = new SearchView();
            view.DataContext = viewModel;
            CurentView = view;
        }

        public override void Delete(Object o)
        {
            SearchBookToDeleteViewModel viewModel = new SearchBookToDeleteViewModel();
            SearchView view = new SearchView();
            view.DataContext = viewModel;
            CurentView = view;
        }
        #endregion
    }
}
