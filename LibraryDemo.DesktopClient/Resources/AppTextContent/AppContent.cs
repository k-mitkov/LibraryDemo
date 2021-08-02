using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDemo.DesktopClient.Resources.AppTextContent
{
    public class AppContent : IContent
    {
        #region Declaration
        private static string language = "bg";
        #endregion

        #region Methods
        public string AddBookButton()
        {
            switch (language)
            {
                case "bg":
                    return "Добави книга";
                default:
                    return "Add book";
            }
        }

        public string AddButton()
        {
            switch (language)
            {
                case "bg":
                    return "Добави";
                default:
                    return "Add";
            }
        }

        public string AddressHeader()
        {
            switch (language)
            {
                case "bg":
                    return "Адрес";
                default:
                    return "Address";
            }
        }

        public string AllBooksButton()
        {
            switch (language)
            {
                case "bg":
                    return "Всички книги";
                default:
                    return "All books";
            }
        }

        public string AuthorHeader()
        {
            switch (language)
            {
                case "bg":
                    return "Автор";
                default:
                    return "Author";
            }
        }

        public string AuthorsButton()
        {
            switch (language)
            {
                case "bg":
                    return "Автори";
                default:
                    return "Authors";
            }
        }

        public string BooksButton()
        {
            switch (language)
            {
                case "bg":
                    return "Книги";
                default:
                    return "Books";
            }
        }

        public string ByAuthorsButton()
        {
            switch (language)
            {
                case "bg":
                    return "Книги по автори";
                default:
                    return "Books by authors";
            }
        }

        public string ByLibrariesButton()
        {
            switch (language)
            {
                case "bg":
                    return "Книги по библиотеки";
                default:
                    return "Books by libraries";
            }
        }

        public string DeleteBookButton()
        {
            switch (language)
            {
                case "bg":
                    return "Изтрий книга";
                default:
                    return "Delete book";
            }
        }

        public string DeleteButton()
        {
            switch (language)
            {
                case "bg":
                    return "Изтрий";
                default:
                    return "Delete";
            }
        }

        public string ErrBooksNotFound()
        {
            switch (language)
            {
                case "bg":
                    return "Не са намерени книги!";
                default:
                    return "No books found!";
            }
        }

        public string ErrSelectAuthor()
        {
            switch (language)
            {
                case "bg":
                    return "Моля изберете автор!";
                default:
                    return "Please select an author!";
            }
        }

        public string ErrSelectBook()
        {
            switch (language)
            {
                case "bg":
                    return "Моля изберете книга!";
                default:
                    return "Please choose a book!";
            }
        }

        public string ErrSelectLibrary()
        {
            switch (language)
            {
                case "bg":
                    return "Моля изберете библиотека!";
                default:
                    return "Please select a library!";
            }
        }

        public string ErrSelectPrice()
        {
            switch (language)
            {
                case "bg":
                    return "Цената тябва да е по-голяма от 0 и изписана с цифри.";
                default:
                    return "The price must be greater than 0 and written in numbers.";
            }
        }

        public string ErrSelectTitle()
        {
            switch (language)
            {
                case "bg":
                    return "Заглавието трябва да е поне 3 символа.";
                default:
                    return "The title must be at least 3 characters.";
            }
        }

        public string GenderHeader()
        {
            switch (language)
            {
                case "bg":
                    return "Пол";
                default:
                    return "Gender";
            }
        }

        public string LibrariesButton()
        {
            switch (language)
            {
                case "bg":
                    return "Библиотеки";
                default:
                    return "Libraries";
            }
        }

        public string LibraryHeader()
        {
            switch (language)
            {
                case "bg":
                    return "Библиотека";
                default:
                    return "Library";
            }
        }

        public string MailHeader()
        {
            switch (language)
            {
                case "bg":
                    return "Имейл";
                default:
                    return "Mail";
            }
        }

        public string MainTitle()
        {
            switch (language)
            {
                case "bg":
                    return "Всички книги на едно място";
                default:
                    return "All books in one place";
            }
        }

        public string NameHeader()
        {
            switch (language)
            {
                case "bg":
                    return "Име";
                default:
                    return "Name";
            }
        }

        public string PriceHeader()
        {
            switch (language)
            {
                case "bg":
                    return "Цена";
                default:
                    return "Price";
            }
        }

        public string SearchBookButton()
        {
            switch (language)
            {
                case "bg":
                    return "Търси книга";
                default:
                    return "Search book";
            }
        }

        public string SearchButton()
        {
            switch (language)
            {
                case "bg":
                    return "Търси";
                default:
                    return "Search";
            }
        }

        public string SearchTitleText()
        {
            switch (language)
            {
                case "bg":
                    return "Търсете заглавие: ";
                default:
                    return "Search title: ";
            }
        }

        public string SelectAuthorText()
        {
            switch (language)
            {
                case "bg":
                    return "Изберете автор: ";
                default:
                    return "Select author: ";
            }
        }

        public string SelectBookText()
        {
            switch (language)
            {
                case "bg":
                    return "Изберете книга: ";
                default:
                    return "Select book: ";
            }
        }

        public string SelectLibrayText()
        {
            switch (language)
            {
                case "bg":
                    return "Изберете библиотека: ";
                default:
                    return "Select library: ";
            }
        }

        public string SuccesfullyDeletedBook()
        {
            switch (language)
            {
                case "bg":
                    return "Книгата е изтрита успешно!";
                default:
                    return "The book has been deleted successfully!";
            }
        }

        public string SuccessfullyAddedBook()
        {
            switch (language)
            {
                case "bg":
                    return "Книгата е добавена успешно!";
                default:
                    return "The book has been added successfully!";
            }
        }

        public string TitleHeader()
        {
            switch (language)
            {
                case "bg":
                    return "Заглавие";
                default:
                    return "Title";
            }
        }

        public string SaveButton()
        {
            switch (language)
            {
                case "bg":
                    return "Запази";
                default:
                    return "Save";
            }
        }

        public string SelectLanguageText()
        {
            switch (language)
            {
                case "bg":
                    return "Изберете език: ";
                default:
                    return "Choose a language: ";
            }
        }

        public string ErrSelectLanguage()
        {
            switch (language)
            {
                case "bg":
                    return "Моля изберете език!";
                default:
                    return "Please select a language!";
            }
        }

        public static void SetLanguage(string language)
        {
            switch (language)
            {
                case "Български":
                    AppContent.language = "bg";
                    break;
                case "English":
                    AppContent.language = "en";
                    break;
                default:
                    AppContent.language = "en";
                    break;
            }
        }
        #endregion
    }
}
