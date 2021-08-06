

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

        public string AddBook()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Добави книга";
                default:
                    return "Add book";
            }
        }

        public string AddLibrary()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Добави библиотека";
                default:
                    return "Add library";
            }
        }

        public string Add()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Добави";
                default:
                    return "Add";
            }
        }

        public string Address()
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

        public string AllBooks()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Всички книги";
                default:
                    return "All books";
            }
        }
        public string AllLibraries()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Всички библиотеки";
                default:
                    return "All libraries";
            }
        }

        public string Author()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Автор";
                default:
                    return "Author";
            }
        }

        public string Authors()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Автори";
                default:
                    return "Authors";
            }
        }

        public string Books()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Книги";
                default:
                    return "Books";
            }
        }

        public string ByAuthors()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Книги по автори";
                default:
                    return "Books by authors";
            }
        }

        public string ByLibraries()
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

        public string DeleteBook()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Изтрий книга";
                default:
                    return "Delete book";
            }
        }

        public string DeleteLibrary()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Изтрий библиотека";
                default:
                    return "Delete library";
            }
        }

        public string Delete()
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

        public string ErrLibrariesNotFound()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Не са намерени библиотеки!";
                default:
                    return "No libraries found!";
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
        public string ErrSelectAddress()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Моля въведете валиден адрес.";
                default:
                    return "Please enter valid address.";
            }
        }

        public string Gender()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Пол";
                default:
                    return "Gender";
            }
        }

        public string Libraries()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Библиотеки";
                default:
                    return "Libraries";
            }
        }

        public string Library()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Библиотека";
                default:
                    return "Library";
            }
        }

        public string Mail()
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

        public string Name()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Име";
                default:
                    return "Name";
            }
        }

        public string Price()
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

        public string SearchBook()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Търси книга";
                default:
                    return "Search book";
            }
        }

        public string SearchLibrary()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Търси библиотека";
                default:
                    return "Search library";
            }
        }

        public string Search()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Търси";
                default:
                    return "Search";
            }
        }

        public string SearchTitle()
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

        public string SelectAuthor()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Изберете автор: ";
                default:
                    return "Select author: ";
            }
        }

        public string SelectBook()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Изберете книга: ";
                default:
                    return "Select book: ";
            }
        }

        public string SelectLibray()
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
        public string SuccesfullyDeletedAuthor()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Автора е изтрит успешно!";
                default:
                    return "The author has been deleted successfully!";
            }
        }

        public string SuccesfullyDeletedLibrary()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Библиотеката е изтрита успешно!";
                default:
                    return "The library has been deleted successfully!";
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

        public string SuccessfullyAddedAuthor()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Авторът е добавен успешно!";
                default:
                    return "The author has been added successfully!";
            }
        }

        public string SuccessfullyAddedLibrary()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Библиотеката е добавена успешно!";
                default:
                    return "The library has been added successfully!";
            }
        }

        public string Title()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Заглавие";
                default:
                    return "Title";
            }
        }

        public string Save()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Запази";
                default:
                    return "Save";
            }
        }

        public string SelectLanguage()
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
        public string WarningAuthorDelete()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Сигурни ли сте че искате да изтриете този автор? Така ще изтриете и всички негови книги!!!";
                default:
                    return "Are you sure you want to delete this author? This will delete all his books!!!";
            }
        }
        public string WarningLibraryDelete()
        {
            switch (language)
            {
                case Languages.Български:
                    return "Сигурни ли сте че искате да изтриете тази библиотека? Така ще изтриете и всички книги в нея!!!";
                default:
                    return "Are you sure you want to delete this library? This will delete all books in it!!!";
            }
        }

        public IEnumerable<string> Genders()
        {
            List<string> genders = new List<string>();
            switch (language)
            {
                case Languages.Български:
                    genders.Add("Мъж");
                    genders.Add("Жена");
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
