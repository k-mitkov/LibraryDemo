using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class SearchBookViewModel : BaseNotifyPropertyChangedViewModel
    {
        #region Declaration 
        private ActionCommand searchCommand;
        private string _keyWord;
        private UserControl currentView;
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
        public void Search(Object o)
        {
            ShowBooksByKeyWordViewModel viewModel = new ShowBooksByKeyWordViewModel(_keyWord);
            AllBooksView view = new AllBooksView();
            view.DataContext = viewModel;
            CurentView = view;
        }
        #endregion
    }
}
