using LibraryDemo.DesktopClient.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public abstract class BaseSearchViewModel : BaseNotifyPropertyChangedViewModel
    {
        #region Declaration 
        protected ActionCommand searchCommand;
        protected string _keyWord;
        protected UserControl currentView;
        protected string errMasage;
        #endregion

        #region Proparties
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

        public string KeyWord
        {
            get { return _keyWord; }
            set
            {
                _keyWord = value;
            }
        }

        public string SearchButtonContent
        {
            get
            {
                return content.Search();
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
        public abstract void Search(Object o);
        #endregion
    }
}
