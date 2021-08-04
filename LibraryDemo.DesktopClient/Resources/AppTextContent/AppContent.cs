

using System.Collections.Generic;

namespace LibraryDemo.DesktopClient.Resources.AppTextContent
{
    public class AppContent : IContent
    {
        #region Declaration
        private static Languages language = Languages.Български;
        #endregion

        #region Methods
        public string AddAuthor()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Добави автор";
                default:
                    return "Add author";
            }
        }

        public string AddBookButton()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Добави книга";
                default:
                    return "Add book";
            }
        }

        public string AddButton()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Добави";
                default:
                    return "Add";
            }
        }

        public string AddressHeader()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Адрес";
                default:
                    return "Address";
            }
        }

        public string AllAuthors()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Всички автори";
                default:
                    return "All authors";
            }
        }

        public string AllBooksButton()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Всички книги";
                default:
                    return "All books";
            }
        }

        public string AuthorHeader()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Автор";
                default:
                    return "Author";
            }
        }

        public string AuthorsButton()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Автори";
                default:
                    return "Authors";
            }
        }

        public string BooksButton()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Книги";
                default:
                    return "Books";
            }
        }

        public string ByAuthorsButton()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Книги по автори";
                default:
                    return "Books by authors";
            }
        }

        public string ByLibrariesButton()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Книги по библиотеки";
                default:
                    return "Books by libraries";
            }
        }
        public string DeleteAuthor()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Изтрий автор";
                default:
                    return "Delete author";
            }
        }

        public string DeleteBookButton()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Изтрий книга";
                default:
                    return "Delete book";
            }
        }

        public string DeleteButton()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Изтрий";
                default:
                    return "Delete";
            }
        }
        public string ErrAuthorNotFound()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Не са намерени автори!";
                default:
                    return "No authors found!";
            }
        }

        public string ErrBooksNotFound()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Не са намерени книги!";
                default:
                    return "No books found!";
            }
        }

        public string ErrSelectAuthor()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Моля изберете автор!";
                default:
                    return "Please select an author!";
            }
        }

        public string ErrSelectBook()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Моля изберете книга!";
                default:
                    return "Please choose a book!";
            }
        }

        public string ErrSelectGender()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Моля изберете пол!";
                default:
                    return "Please choose a gender!";
            }
        }

        public string ErrSelectLibrary()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Моля изберете библиотека!";
                default:
                    return "Please select a library!";
            }
        }

        public string ErrSelectPrice()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Цената тябва да е по-голяма от 0 и изписана с цифри.";
                default:
                    return "The price must be greater than 0 and written in numbers.";
            }
        }

        public string ErrSelectTitle()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Заглавието трябва да е поне 3 символа.";
                default:
                    return "The title must be at least 3 characters.";
            }
        }

        public string ErrSelectName()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Имаето трябва да е поне 3 символа.";
                default:
                    return "The name must be at least 3 characters.";
            }
        }

        public string ErrSelectMail()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Моля въведете валиден имайл.";
                default:
                    return "Please enter valid mail.";
            }
        }

        public string GenderHeader()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Пол";
                default:
                    return "Gender";
            }
        }

        public string LibrariesButton()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Библиотеки";
                default:
                    return "Libraries";
            }
        }

        public string LibraryHeader()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Библиотека";
                default:
                    return "Library";
            }
        }

        public string MailHeader()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Имейл";
                default:
                    return "Mail";
            }
        }

        public string MainTitle()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Всички книги на едно място";
                default:
                    return "All books in one place";
            }
        }

        public string NameHeader()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Име";
                default:
                    return "Name";
            }
        }

        public string PriceHeader()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Цена";
                default:
                    return "Price";
            }
        }
        public string SearchAuthor()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Търси автор";
                default:
                    return "Search author";
            }
        }

        public string SearchBookButton()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Търси книга";
                default:
                    return "Search book";
            }
        }

        public string SearchButton()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Търси";
                default:
                    return "Search";
            }
        }

        public string SearchTitleText()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Търсете заглавие: ";
                default:
                    return "Search title: ";
            }
        }

        public string SearchByName()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Търсете по име: ";
                default:
                    return "Search by name: ";
            }
        }

        public string SelectAuthorText()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Изберете автор: ";
                default:
                    return "Select author: ";
            }
        }

        public string SelectBookText()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Изберете книга: ";
                default:
                    return "Select book: ";
            }
        }

        public string SelectLibrayText()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Изберете библиотека: ";
                default:
                    return "Select library: ";
            }
        }

        public string SuccesfullyDeletedBook()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Книгата е изтрита успешно!";
                default:
                    return "The book has been deleted successfully!";
            }
        }

        public string SuccessfullyAddedBook()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Книгата е добавена успешно!";
                default:
                    return "The book has been added successfully!";
            }
        }

        public string TitleHeader()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Заглавие";
                default:
                    return "Title";
            }
        }

        public string SaveButton()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Запази";
                default:
                    return "Save";
            }
        }

        public string SelectLanguageText()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Изберете език: ";
                default:
                    return "Choose a language: ";
            }
        }

        public string ErrSelectLanguage()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Моля изберете език!";
                default:
                    return "Please select a language!";
            }
        }

        public IEnumerable<string> Genders()
        {
            List<string> genders = new List<string>();
            switch (language)
            {
                case Languages.Български:
                    genders.Add("male");
                    genders.Add("female");
                    return genders;
                default:
                    genders.Add("Male");
                    genders.Add("Female");
                    return genders;
            }
        }

        public char GenderTranslate(string gender)
        {
            if (gender.Equals("Male") || gender.Equals("male")){
                return 'm';
            }
            return 'f';
        }

        public static void SetLanguage(Languages slanguage)
        {
            language = slanguage;
        }
        public static IEnumerable<Languages> GetLanguages()
        {
            List<Languages> languages = new List<Languages>();
            languages.Add(Languages.English);
            languages.Add(Languages.Български);
            return languages;
        }
        #endregion
    }
}
