namespace web_api_products.Models
{
	public class Image
	{
		public int Id { get; set; }
		public string Name { get; set; }


		public int? CategoryId { get; set; }
		public  Category Category { get; set; }

		public int? ProductId { get; set; }
		public  Product Product { get; set; }
	}
}
	