using System;

namespace LibraryDemo.DesktopClient.BusinessModels
{
    public class BBook
    {
        #region Proparties
        public int Id { get; set; }
        public string Title { get; set; }
        public BAuthor Author { get; set; }
        public decimal Price { get; set; }
        public BLibrary Library { get; set; }
        #endregion

        #region Meshods
        public override string ToString()
        {
            return String.Format("Book[ Title: {0} {1} Price: {2} ]", Title, Author.ToString(), Price);
        }
        #endregion
    }
}
