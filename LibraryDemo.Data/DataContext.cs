using LibraryDemo.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryDemo.Data
{
    public class DataContext : DbContext
    {
        #region Proparties
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Library> Libraries { get; set; }
        #endregion

        #region Methods
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost; Database = Library; User = sa; Password = Micr0!nvest; Trusted_Connection = true; Integrated Security=False");
            base.OnConfiguring(optionsBuilder);
        }
        #endregion
    }
}
