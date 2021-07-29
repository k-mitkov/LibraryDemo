using LibraryDemo.Data;
using LibraryDemo.Data.Models;
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
    public class BooksByAuthorViewModel : INotifyPropertyChanged
    {
        private BusinessContex context;
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public BooksByAuthorViewModel()
        {
            context = new BusinessContex();
        }

        public List<Author> ListOfAuthors
        {
            get
            {
                return context.GetAuthors();
            }
        }

        private Author _sauthor;

        public Author SAuthor
        {
            get { return _sauthor; }
            set 
            { 
                _sauthor = value; 
            }
        }

        private ActionCommand showCommand;

        public ActionCommand ShowCommand
        {
            get
            {
                if (showCommand == null)
                {
                    showCommand = new ActionCommand(Show, CanExecuteShow);
                }
                return showCommand;
            }
        }
        public bool CanExecuteShow(Object o)
        {
            return true;
        }

        public void Show(Object o)
        {
            ShowBooksViewModel viewModel = new ShowBooksViewModel(_sauthor);
            AllBooksView view = new AllBooksView() ;
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
