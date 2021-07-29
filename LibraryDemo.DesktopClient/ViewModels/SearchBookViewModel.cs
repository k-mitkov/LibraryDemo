using LibraryDemo.Data;
using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class SearchBookViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private BusinessContex context;

        public SearchBookViewModel()
        {
            context = new BusinessContex();
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        private ActionCommand searchCommand;

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
        public bool CanExecuteShow(Object o)
        {
            return true;
        }

        private string _keyWord;

        public string KeyWord
        {
            get { return _keyWord; }
            set
            {
                _keyWord = value;
            }
        }

        public void Search(Object o)
        {
            ShowBooksByKeyWordViewModel viewModel = new ShowBooksByKeyWordViewModel(_keyWord);
            AllBooksView view = new AllBooksView();
            view.DataContext = viewModel;
            CurentView = view;

        }

        private UserControl currentView;
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

    }
}
