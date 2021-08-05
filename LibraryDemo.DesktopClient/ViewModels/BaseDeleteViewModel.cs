using LibraryDemo.DesktopClient.Command;
using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public abstract class BaseDeleteViewModel : BaseNotifyPropertyChangedViewModel
    {
        #region Declaration
        protected ActionCommand deleteCommand;
        protected UserControl currentView;
        protected string errMasage;
        #endregion

        #region Proparties
        public ActionCommand DeleteCommand
        {
            get
            {
                if (deleteCommand == null)
                {
                    deleteCommand = new ActionCommand(Delete, CanExecuteShow);
                }
                return deleteCommand;
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

        public string DeleteButtonContent
        {
            get
            {
                return content.DeleteButton();
            }
        }

        public string ErrMasage
        {
            get
            {
                return errMasage;
            }
            set
            {
                errMasage = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Methods
        public bool CanExecuteShow(Object o)
        {
            return true;
        }

        public abstract void Delete(Object o);
        #endregion
    }
}
