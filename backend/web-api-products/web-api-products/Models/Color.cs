namespace web_api_products.Models
{
	public class Color
	{
		public int Id { get; set; }
		public string ColorName { get; set; }
		public string ColorHex { get; set; }

		public int ProductId { get; set; }
		public Product Product { get; set; }
	}
}
