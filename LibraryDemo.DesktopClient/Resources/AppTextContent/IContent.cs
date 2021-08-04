using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDemo.DesktopClient.Resources.AppTextContent
{
    public interface IContent
    {
        public string AllAuthors();
        public string AddAuthor();
        public string AuthorsButton();
        public string SaveButton();
        public string BooksButton();
        public string LibrariesButton();
        public string AddButton();
        public string DeleteButton();
        public string SearchButton();
        public string ByLibrariesButton();
        public string ByAuthorsButton();
        public string AllBooksButton();
        public string AddBookButton();
        public string SearchBookButton();
        public string DeleteAuthor();
        public string DeleteBookButton();
        public string NameHeader();
        public string GenderHeader();
        public string MailHeader();
        public string TitleHeader();
        public string AuthorHeader();
        public string PriceHeader();
        public string LibraryHeader();
        public string AddressHeader();
        public string SelectAuthorText();
        public string SelectLibrayText();
        public string SearchAuthor();
        public string SearchByName();
        public string SelectBookText();
        public string SelectLanguageText();
        public string SearchTitleText();
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
        public string ErrAuthorNotFound();
        public string ErrBooksNotFound();
        public string SuccessfullyAddedBook();
        public string SuccesfullyDeletedBook();
        public IEnumerable<string> Genders();
        public char GenderTranslate(string gender);
    }
}
