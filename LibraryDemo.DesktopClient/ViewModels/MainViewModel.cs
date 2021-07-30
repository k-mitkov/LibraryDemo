using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class MainViewModel : BaseNotifyPropertyChangedViewModel
    {
        #region Declaration
        private ActionCommand bookCommand;
        private ActionCommand authorCommand;
        private ActionCommand libraryCommand;
        private UserControl currentView;
        #endregion

        #region Proparties
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
        #endregion
    }
}
