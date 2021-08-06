using LibraryDemo.DesktopClient.BusinessModels;
using LibraryDemo.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryDemo.DesktopClient.ViewModels
{
    class SearchAuthorViewModel : BaseSearchViewModel
    {
        #region Proparties 
        public string SelectContent
        {
            get
            {
                return content.SearchByName();
            }
        }
        #endregion

        #region Methods
        public override void Search(Object o)
        {
            List<BAuthor> authors = authorService.SearchForAutors(_keyWord).ToList();
            if (authors.Count == 0)
            {
                ErrMasage = content.ErrAuthorNotFound();
                CurentView = null;
            }
            else
            {
                ErrMasage = "";
                ShowAuthorsViewModel viewModel = new ShowAuthorsViewModel(authors);
                ShowAuthorsView view = new ShowAuthorsView();
                view.DataContext = viewModel;
                CurentView = view;
            }
        }
        #endregion
    }
}
