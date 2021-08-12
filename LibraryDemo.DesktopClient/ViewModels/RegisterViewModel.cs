using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class RegisterViewModel : BaseNotifyPropertyChangedViewModel
    {
        #region Declaration
        private ActionCommand registerCommand;
        private ActionCommand loginFormCommand;
        private UserControl currentView;
        public event Action SomeEvent;
        private string name;
        private string password;
        private string mail;
        private bool isNameValid = true;
        private bool isPasswordValid = true;
        private bool isMailValid = true;
        private bool isNameAvailable = true;
        private bool isMailAvailable = true;
        #endregion

        #region Proparties
        public ActionCommand RegisterCommand
        {
            get
            {
                if (registerCommand == null)
                {
                    registerCommand = new ActionCommand(Register, CanExecuteShow);
                }
                return registerCommand;
            }
        }

        public ActionCommand LoginFormCommand
        {
            get
            {
                if (loginFormCommand == null)
                {
                    loginFormCommand = new ActionCommand(BackToLogin, CanExecuteShow);
                }
                return loginFormCommand;
            }
        }

        public UserControl CurrentView
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

        public string Mail
        {
            get
            {
                return mail;
            }
            set
            {
                mail = value;
            }
        }
        public bool IsNameValid
        {
            get
            {
                return isNameValid;
            }
            set
            {
                isNameValid = value;
                OnPropertyChanged();
            }
        }

        public bool IsNameAvailable
        {
            get
            {
                return isNameAvailable;
            }
            set
            {
                isNameAvailable = value;
                OnPropertyChanged();
            }
        }

        public bool IsPasswordValid
        {
            get
            {
                return isPasswordValid;
            }
            set
            {
                isPasswordValid = value;
                OnPropertyChanged();
            }
        }

        public bool IsMailValid
        {
            get
            {
                return isMailValid;
            }
            set
            {
                isMailValid = value;
                OnPropertyChanged();
            }
        }

        public bool IsMailAvailable
        {
            get
            {
                return isMailAvailable;
            }
            set
            {
                isMailAvailable = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Methods
        public bool CanExecuteShow(Object o)
        {
            return true;
        }

        public void Register(Object o)
        {
            PasswordBox passwordBox = (PasswordBox)o;
            Password = passwordBox.Password;
            if (ValidateInput())
            {
                if(isNameAvailable && isMailAvailable)
                {
                    if (userService.AddNewUser(name, mail, password))
                    {
                        OnEvent();
                    }
                }
            }
        }

        public void BackToLogin(Object o)
        {
            OnEvent();
        }

        private void OnEvent()
        {
            SomeEvent.Invoke();
        }

        private bool ValidateInput()
        {
            IsNameValid = name != null && name.Length > 0;
            IsPasswordValid = password != null && Regex.IsMatch(password, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,20}$");
            IsMailValid = mail != null && Regex.IsMatch(mail, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
            if(isNameValid && isPasswordValid && isMailValid)
            {
                IsNameAvailable = userService.ValidateName(name);
                IsMailAvailable = userService.ValidateMail(mail);
            }
            return isNameValid && isPasswordValid && isMailValid;
        }
        #endregion
    }
}
