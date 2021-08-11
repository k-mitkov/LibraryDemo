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
            OnLogin();
            CurentView = null;
        }

        public void ShowRegisterForm(Object o)
        {
            RegisterViewModel viewModel = new RegisterViewModel();
            viewModel.RegisterEvent += RegistrationHandler;
            RegisterView view = new RegisterView();
            view.DataContext = viewModel;
            CurentView = view;
        }

        public void ShowForgottenPasswordForm(Object o)
        {
            IMailSender mailSender = new MailSender();
            mailSender.Send("kasi0m0@gmail.com", "raboti 123");
            CurentView = new ResetPasswordView();
        }

        public void RegistrationHandler()
        {
            CurentView = null;
        }
        #endregion
    }
}
