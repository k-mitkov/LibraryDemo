using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.Command;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class DeleteBookViewModel : BaseDeleteViewModel
    {
        #region Declaration
        private IEnumerable<Book> books;
        private Book _sbook;
        #endregion

        #region Constructor
        public DeleteBookViewModel(List<Book> books)
        {
            this.books = books;
        }
        #endregion

        #region Proparties
        public IEnumerable<Book> ListOfBooks
        {
            get
            {
                return books;
            }
        }

        public Book SBook
        {
            get { return _sbook; }
            set
            {
                _sbook = value;
            }
        }
       public string SelectToDeleteContent
        {
            get
            {
                return content.SelectBookText();
            }
        }
        #endregion

        #region Methods
        public override void Delete(Object o)
        {
            if (_sbook != null)
            {
                context.DeleteBook(_sbook.Id);
                SuccessfulOperationViewModel viewModel = new SuccessfulOperationViewModel(content.SuccesfullyDeletedBook());
                SuccessfulOperationView view = new SuccessfulOperationView();
                view.DataContext = viewModel;
                CurentView = view;
            }
            else
            {
                ErrMasage = content.ErrSelectBook();
            }
        }
        #endregion
    }
}
