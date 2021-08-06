using LibraryDemo.DesktopClient.BusinessModels;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class DeleteBookViewModel : BaseDeleteViewModel
    {
        #region Declaration
        private IEnumerable<BBook> books;
        private BBook _sbook;
        #endregion

        #region Constructor
        public DeleteBookViewModel(List<BBook> books)
        {
            this.books = books;
        }
        #endregion

        #region Proparties
        public IEnumerable<BBook> ListOfBooks
        {
            get
            {
                return books;
            }
        }

        public BBook SBook
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
                return content.SelectBook();
            }
        }
        #endregion

        #region Methods
        public override void Delete(Object o)
        {
            if (_sbook != null)
            {
                bookService.Delete(_sbook.Id);
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
