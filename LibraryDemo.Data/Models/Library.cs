using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryDemo.Data.Models
{
    public class Library
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Book> Books { get; set; }

        public Library()
        {
            Books = new List<Book>();
        }

        public override string ToString()
        {
            return String.Format("Library[ Name: {0} {1}]", Name, String.Join(" ", Books.Select((b) => b.ToString()).ToList()));
        }
    }
}
