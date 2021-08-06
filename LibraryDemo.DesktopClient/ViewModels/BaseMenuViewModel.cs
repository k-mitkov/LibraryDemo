using LibraryDemo.DesktopClient.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public abstract class BaseMenuViewModel : BaseNotifyPropertyChangedViewModel
    {
        #region Declaration
        protected ActionCommand showAllCommand;
        protected ActionCommand searchCommand;
        protected ActionCommand addCommand;
        protected ActionCommand deleteCommand;
        protected UserControl currentView;
        #endregion

        #region Proparties
        public ActionCommand ShowAllCommand
        {
            get
            {
                if (showAllCommand == null)
                {
                    showAllCommand = new ActionCommand(ShowAll, CanExecuteShow);
                }
                return showAllCommand;
            }
        }

        public ActionCommand SearchCommand
        {
            get
            {
                if (searchCommand == null)
                {
                    searchCommand = new ActionCommand(Search, CanExecuteShow);
                }
                return searchCommand;
            }
        }

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
        #endregion

        #region Methods
        public bool CanExecuteShow(Object o)
        {
            return true;
        }

        public abstract void ShowAll(Object o);
        public abstract void Search(Object o);
        public abstract void Add(Object o);
        public abstract void Delete(Object o);
        #endregion
    }
}
