﻿using LibraryDemo.Data;
using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class DeleteBookViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private BusinessContex context;
        private List<Book> books;

        public DeleteBookViewModel(List<Book> books)
        {
            this.books = books;
            context = new BusinessContex();
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        private ActionCommand deleteCommand;

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

        public List<Book> ListOfBooks
        {
            get
            {
                return books;
            }
        }

        private Book _sbook;

        public Book SBook
        {
            get { return _sbook; }
            set
            {
                _sbook = value;
            }
        }
        public bool CanExecuteShow(Object o)
        {
            return true;
        }


        public void Delete(Object o)
        {
            context.DeleteBook(_sbook.Id);
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
