using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class BookViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private ActionCommand allBooksCommand;

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

        private ActionCommand booksByAuthorCommand;

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

        private ActionCommand booksByLibraryCommand;

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

        private ActionCommand addBookCommand;

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

        private ActionCommand searchBookCommand;

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

        private ActionCommand deleteBookCommand;

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
            DeleteBookViewModel viewModel = new DeleteBookViewModel();
            DeleteBookView view = new DeleteBookView();
            view.DataContext = viewModel;
            CurentView = view;

        }


        private UserControl currentView;
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
    }
}
