using System.Collections.Generic;

namespace LibraryDemo.DesktopClient.Resources.AppTextContent
{
    public interface IContent
    {
        public string AllAuthors();
        public string AllLibraries();
        public string AddAuthor();
        public string AddLibrary();
        public string Authors();
        public string Save();
        public string Books();
        public string Libraries();
        public string Add();
        public string Delete();
        public string Search();
        public string ByLibraries();
        public string ByAuthors();
        public string AllBooks();
        public string AddBook();
        public string SearchBook();
        public string DeleteAuthor();
        public string DeleteLibrary();
        public string DeleteBook();
        public string Name();
        public string Gender();
        public string Mail();
        public string Title();
        public string Author();
        public string Price();
        public string Library();
        public string Address();
        public string SelectAuthor();
        public string SelectLibray();
        public string SearchAuthor();
        public string SearchLibrary();
        public string SearchByName();
        public string SelectBook();
        public string SelectLanguage();
        public string SearchTitle();
        public string MainTitle();
        public string ErrSelectTitle();
        public string ErrSelectAuthor();
        public string ErrSelectGender();
        public string ErrSelectName();
        public string ErrSelectMail();
        public string ErrSelectPrice();
        public string ErrSelectLibrary();
        public string ErrSelectBook();
        public string ErrSelectLanguage();
        public string ErrSelectAddress();
        public string ErrAuthorNotFound();
        public string ErrBooksNotFound();
        public string ErrLibrariesNotFound();
        public string SuccessfullyAddedAuthor();
        public string SuccessfullyAddedBook();
        public string SuccessfullyAddedLibrary();
        public string SuccesfullyDeletedAuthor();
        public string SuccesfullyDeletedLibrary();
        public string SuccesfullyDeletedBook();
        public IEnumerable<string> Genders();
        public string GenderTranslate(string gender);
        public string GenderTransformation(char gender);
        public char GenderTransformation(string gender);
        public string WarningAuthorDelete();
        public string WarningLibraryDelete();
    }
}
