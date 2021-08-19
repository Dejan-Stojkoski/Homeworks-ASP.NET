namespace EStoreApp.Web.Models.Domain
{
    public class Review
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
        public string ReviewText { get; set; }
        public int Rate { get; set; }
    }
}
