namespace WebsiteKh.Models
{
    public class Car
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortDesc { get; set; }
        public string description { get; set; }
        public string img {  get; set; }
        public ushort price { get; set; }
        public bool isFavorite { get; set; }
        public bool available { get; set; }
        public int categoryId { get; set; }
        public virtual Category сategory { get; set; }
    }
}
