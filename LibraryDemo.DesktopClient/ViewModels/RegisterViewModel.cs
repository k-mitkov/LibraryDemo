using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class RegisterViewModel : BaseNotifyPropertyChangedViewModel
    {
        #region Declaration
        private ActionCommand registerCommand;
        private UserControl currentView;
        public event Action RegisterEvent;
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
        #endregion

        #region Methods
        public bool CanExecuteShow(Object o)
        {
            return true;
        }

        public void Register(Object o)
        {
            OnRegister();
        }

        private void OnRegister()
        {
            RegisterEvent.Invoke();
        }
        #endregion
    }
}
