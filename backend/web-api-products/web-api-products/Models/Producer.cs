namespace web_api_products.Models
{
    public class Producer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
