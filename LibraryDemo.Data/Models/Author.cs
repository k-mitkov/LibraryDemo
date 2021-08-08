using System.Collections.Generic;

namespace LibraryDemo.Data.Models
{
    public class Author
    {

        #region Proparties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public char Gender { get; set; }
        public List<Book> Books { get; set; }
        #endregion
    }
}
