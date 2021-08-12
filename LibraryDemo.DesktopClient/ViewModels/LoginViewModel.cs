using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Util;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class LoginViewModel : BaseNotifyPropertyChangedViewModel
    {
        #region Declaration
        private ActionCommand loginCommand;
        private ActionCommand registerFormCommand;
        private ActionCommand forgottenPasswordCommand;
        private UserControl currentView;
        private string name;
        private string password;
        private bool isInputValid = true;
        public event Action LoginEvent;
        #endregion

        #region Proparties
        public ActionCommand LoginCommand
        {
            get
            {
                if (loginCommand == null)
                {
                    loginCommand = new ActionCommand(Login, CanExecuteShow);
                }
                return loginCommand;
            }
        }

        public ActionCommand RegisterFormCommand
        {
            get
            {
                if (registerFormCommand == null)
                {
                    registerFormCommand = new ActionCommand(ShowRegisterForm, CanExecuteShow);
                }
                return registerFormCommand;
            }
        }

        public ActionCommand ForgottenPasswordCommand
        {
            get
            {
                if (forgottenPasswordCommand == null)
                {
                    forgottenPasswordCommand = new ActionCommand(ShowForgottenPasswordForm, CanExecuteShow);
                }
                return forgottenPasswordCommand;
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

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public bool IsInputValid
        {
            get
            {
                return isInputValid;
            }
            set
            {
                isInputValid = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Methods
        private void OnLogin()
        {
            LoginEvent.Invoke();
        }

        public bool CanExecuteShow(Object o)
        {
            return true;
        }

        public void Login(Object o)
        {
            PasswordBox passwordBox = (PasswordBox) o;
            Password = passwordBox.Password;
            if (userService.LogIn(name, password))
            {
                IsInputValid = true;
                CurentView = null;
                OnLogin();
            }
            else
            {
                IsInputValid = false;
            }
        }

        public void ShowRegisterForm(Object o)
        {
            RegisterViewModel viewModel = new RegisterViewModel();
            viewModel.SomeEvent += ReturnLoginPage;
            RegisterView view = new RegisterView();
            view.DataContext = viewModel;
            CurentView = view;
        }

        public void ShowForgottenPasswordForm(Object o)
        {
            ResetPasswordViewModel viewModel = new ResetPasswordViewModel();
            viewModel.SomeEvent += ReturnLoginPage;
            ResetPasswordView view = new ResetPasswordView();
            view.DataContext = viewModel;
            CurentView = view;
        }

        public void ReturnLoginPage()
        {
            CurentView = null;
            IsInputValid = true;
        }
        #endregion
    }
}
