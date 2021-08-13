using LibraryDemo.DesktopClient.Command;
using System;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class ResetPasswordViewModel : BaseNotifyPropertyChangedViewModel
    {
        #region Declaration
        private ActionCommand resetPasswordCommand;
        private ActionCommand loginFormCommand;
        public event Action SomeEvent;
        private bool isMailFound = true;
        private string mail;
        #endregion

        #region Proparties
        public ActionCommand ResetPasswordCommand
        {
            get
            {
                if (resetPasswordCommand == null)
                {
                    resetPasswordCommand = new ActionCommand(ResetPassword, CanExecuteShow);
                }
                return resetPasswordCommand;
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

        public bool IsMailFound
        {
            get
            {
                return isMailFound;
            }
            set
            {
                isMailFound = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Methods
        public bool CanExecuteShow(object o)
        {
            return true;
        }

        public void ResetPassword(object o)
        {
            if (userService.UpdateUserPassword(mail))
            {
                OnEvent();
            }
            else
            {
                IsMailFound = false;
            }
        }

        public void BackToLogin(object o)
        {
            OnEvent();
        }

        private void OnEvent()
        {
            SomeEvent.Invoke();
        }
        #endregion
    }
}
