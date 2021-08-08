using LibraryDemo.DesktopClient.Resources.AppTextContent;
using LibraryDemo.DesktopClient.Services;
using LibraryDemo.DesktopClient.Services.Impl;

namespace LibraryDemo.DesktopClient.ViewModels
{
    public class BaseViewModel
    {
        #region Declaration
        protected IAuthorService authorService;
        protected IBookService bookService;
        protected ILibraryService libraryService;
        protected IContent content;
        #endregion

        #region Constructor
        public BaseViewModel()
        {
            content = new AppContent();
            authorService = new AuthorService();
            libraryService = new LibraryService();
            bookService = new BookService();
        }
        #endregion
    }
}
