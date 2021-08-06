using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDemo.Data.Models
{
    public class Author
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public char Gender { get; set; }
        public List<Book> Books { get; set; }

        public Author()
        {
            Books = new List<Book>();
        }

        public override string ToString()
        {
            return Name;
        }

        //public override string ToString()
        //{
        //    return String.Format("Author[ Name: {0} Email: {1} Gender: {2} ]", Name, Email, Gender == 'm' ? "Male" : "Female");
        //}
    }
}
