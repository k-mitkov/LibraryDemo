using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDemo.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public decimal Price { get; set; }
        public Library Library { get; set; }


        public override string ToString()
        {
            return String.Format("Book[ Title: {0} {1} Price: {2} ]", Title, Author.ToString(), Price);
        }
    }
}
