using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDemo.DesktopClient.BusinessModels
{
    public class BBook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public BAuthor Author { get; set; }
        public decimal Price { get; set; }
        public BLibrary Library { get; set; }
    }
}
