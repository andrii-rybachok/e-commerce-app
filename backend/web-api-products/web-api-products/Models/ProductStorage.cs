namespace web_api_products.Models
{
	public class ProductStorage
	{
		public int Id { get; set; }
		public int Count { get; set; }
		public bool IsAvailable { get; set; }
		public int ProductId { get; set; }
		public Product Product { get; set; }
	}
}
