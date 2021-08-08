namespace LibraryDemo.Data.Models
{
    public class Book
    {
        #region Proparties
        public int Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public decimal Price { get; set; }
        public Library Library { get; set; }
        #endregion
    }
}
