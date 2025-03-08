namespace AssetServer.models
{
    public class Category
    {
        public string id { get; set; }
        public string icon { get; set; }
        public string gender { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string parentCategoryId { get; set; }
        public List<Category> SubCategory { get; set; }
        public List<Asset> Assets { get; set; }
    }
}
