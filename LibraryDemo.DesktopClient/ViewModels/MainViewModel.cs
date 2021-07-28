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
    class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private ActionCommand bookComand;
        
        public ActionCommand BookCommand
        {
            get
            {
                if (bookComand == null)
                {
                    bookComand = new ActionCommand(Books, CanExecuteShow);
                }
                return bookComand;
            }
        }

        private ActionCommand authorComand;

        public ActionCommand AuthorCommand
        {
            get
            {
                if (authorComand == null)
                {
                    authorComand = new ActionCommand(Authors, CanExecuteShow);
                }
                return authorComand;
            }
        }

        private ActionCommand libraryComand;

        public ActionCommand LibraryCommand
        {
            get
            {
                if (libraryComand == null)
                {
                    libraryComand = new ActionCommand(Libraries, CanExecuteShow);
                }
                return libraryComand;
            }
        }

        public bool CanExecuteShow(Object o)
        {
            return true;
        }

        public void Books(Object o)
        {
            BookViewModel viewModel = new BookViewModel();
            BookView view = new BookView();
            view.DataContext = viewModel;
            CurentView = view;

        }

        public void Authors(Object o)
        {
            AuthorViewModel viewModel = new AuthorViewModel();
            AuthorView view = new AuthorView();
            view.DataContext = viewModel;
            CurentView= view;

        }

        public void Libraries(Object o)
        {
            LibraryViewModel viewModel = new LibraryViewModel();
            LibraryView view = new LibraryView();
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
