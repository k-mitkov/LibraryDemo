namespace LibraryDemo.DesktopClient.BusinessModels
{
    public class BLibrary
    {
        #region Proparties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        #endregion

        #region Meshods
        public override string ToString()
        {
            return Name;
        }

        //public override string ToString()
        //{
        //    return String.Format("Library[ Name: {0} {1}]", Name, String.Join(" ", Books.Select((b) => b.ToString()).ToList()));
        //}
        #endregion
    }
}
