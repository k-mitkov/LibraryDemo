using LibraryDemo.Data.Models;
using LibraryDemo.DesktopClient.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryDemo.DesktopClient.Mappers
{
    interface IBookMapper
    {
        public BBook Map(Book book);
        public Book Map(BBook book);
        public IEnumerable<BBook> Map(IQueryable<Book> books);
    }
}
