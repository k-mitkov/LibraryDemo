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
        private ActionCommand settingsCommand;
        private UserControl currentView;
        private bool isLogged;
        #endregion

        #region Constructor
        public MainViewModel()
        {
            LoginViewModel viewModel = new LoginViewModel();
            LoginView view = new LoginView();
            view.DataContext = viewModel;
            viewModel.LoginEvent += LoginHandler;
            CurentView = view;
        }
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

        public ActionCommand SettingsCommand
        {
            get
            {
                if (settingsCommand == null)
                {
                    settingsCommand = new ActionCommand(Settings, CanExecuteShow);
                }
                return settingsCommand;
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

        public string AuthorButtonContent
        {
            get
            {
                return content.Authors();
            }
        }

        public string BookButtonContent
        {
            get
            {
                return content.Books();
            }
        }

        public string LibraryButtonContent
        {
            get
            {
                return content.Libraries();
            }
        }
        public string WindowTitle
        {
            get
            {
                return content.MainTitle();
            }
        }

        public bool IsLogged
        {
            get
            {
                return isLogged;
            }
            set
            {
                isLogged = true;
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
            BookMenuViewModel viewModel = new BookMenuViewModel();
            BookView view = new BookView();
            view.DataContext = viewModel;
            CurentView = view;

        }

        public void Authors(Object o)
        {
            AuthorMenuViewModel viewModel = new AuthorMenuViewModel();
            SecondMenuView view = new SecondMenuView();
            view.DataContext = viewModel;
            CurentView= view;

        }

        public void Libraries(Object o)
        {
            LibrayMenuViewModel viewModel = new LibrayMenuViewModel();
            SecondMenuView view = new SecondMenuView();
            view.DataContext = viewModel;
            CurentView = view;
        }

        public void Settings(Object o)
        {
            SettingsViewModel viewModel = new SettingsViewModel();
            SettingsView view = new SettingsView();
            view.DataContext = viewModel;
            CurentView = view;
        }

        public void LoginHandler()
        {
            IsLogged = true;
            CurentView = null;
        }
        #endregion
    }
}
