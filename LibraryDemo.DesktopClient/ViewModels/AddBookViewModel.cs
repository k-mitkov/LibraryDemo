using LibraryDemo.Data;
using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class AddBookViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private BusinessContex context;

        public AddBookViewModel()
        {
            context = new BusinessContex();
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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

        public List<Library> ListOfLibraries
        {
            get
            {
                return context.GetLibraries();
            }
        }

        private Library _slibrary;

        public Library SLibrary
        {
            get { return _slibrary; }
            set
            {
                _slibrary = value;
            }
        }

        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _price;

        public string Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private ActionCommand addCommand;

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
        public bool CanExecuteShow(Object o)
        {
            return true;
        }

        public void Add(Object o)
        {
            if (ValidateInput())
            {
                //var book = new Book
                //{
                //    Title = _titel,
                //    Author = _sauthor,
                //    Price = price,
                //    Library = _slibrary
                //};
                //context.AddNewBook(book);
                context.AddNewBook(_title, _sauthor.Name, _slibrary.Name, price);

            }
            //view.DataContext = viewModel;
            //CurentView = view;
        }
        private decimal price;

        private bool ValidateInput()
        {
            if(_title != null&& _title.Length>2&&Decimal.TryParse(_price,out price) && price > 0)
            {
                return true;
            }
            return false;
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
