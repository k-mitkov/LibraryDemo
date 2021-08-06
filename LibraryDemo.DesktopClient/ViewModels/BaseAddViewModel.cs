using LibraryDemo.DesktopClient.Command;
using System;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public abstract class BaseAddViewModel : BaseNotifyPropertyChangedViewModel
    {
        #region Declaration
        protected ActionCommand addCommand;
        protected UserControl currentView;
        protected string errMasage;
        #endregion

        #region Proparties
        public ActionCommand AddCommand
        {
            get
            {
                if (addCommand == null)
                {
                    addCommand = new ActionCommand(Add, CanExecuteShow);
                }
                return addCommand;
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

        public abstract void Add(Object o);
        #endregion
    }
}
