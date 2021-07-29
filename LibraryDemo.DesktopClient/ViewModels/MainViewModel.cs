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

        private ActionCommand bookCommand;
        
        public ActionCommand BookCommand
        {
            get
            {
                if (bookCommand == null)
                {
                    bookCommand = new ActionCommand(Books, CanExecuteShow);
                }
                return bookCommand;
            }
        }

        private ActionCommand authorCommand;

        public ActionCommand AuthorCommand
        {
            get
            {
                if (authorCommand == null)
                {
                    authorCommand = new ActionCommand(Authors, CanExecuteShow);
                }
                return authorCommand;
            }
        }

        private ActionCommand libraryCommand;

        public ActionCommand LibraryCommand
        {
            get
            {
                if (libraryCommand == null)
                {
                    libraryCommand = new ActionCommand(Libraries, CanExecuteShow);
                }
                return libraryCommand;
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
