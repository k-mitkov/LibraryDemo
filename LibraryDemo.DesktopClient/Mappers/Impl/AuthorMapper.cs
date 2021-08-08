using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.BusinessModels;
using LibraryDemo.DesktopClient.Resources.AppTextContent;
using System.Collections.Generic;
using System.Linq;

namespace LibraryDemo.DesktopClient.Mappers.Impl
{
    class AuthorMapper : IAuthorMapper
    {
        #region Declaration
        private IContent content;
        #endregion

        #region Constructor
        public AuthorMapper()
        {
            content = new AppContent();
        }
        #endregion

        #region Methods
        public BAuthor Map(Author author)
        {
            return new BAuthor
            {
                Id = author.Id,
                Name = author.Name,
                Gender = content.GenderTransformation(author.Gender),
                Email = author.Email
            };
        }

        public Author Map(BAuthor author)
        {
            return new Author
            {
                Id = author.Id,
                Name = author.Name,
                Gender = content.GenderTransformation(author.Gender),
                Email = author.Email,
                Books = new List<Book>()
            };
        }

        public IEnumerable<BAuthor> Map(IQueryable<Author> authors)
        {
            authors.ToList();
            List<BAuthor> bAutors = new List<BAuthor>();
            foreach(Author author in authors)
            {
                bAutors.Add(Map(author));
            }
            return bAutors;
        }
        #endregion
    }
}
