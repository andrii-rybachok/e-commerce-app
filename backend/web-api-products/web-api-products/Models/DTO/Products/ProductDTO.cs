namespace web_api_products.Models.DTO.Products
{
	public class ProductDTO
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string PreviewImage { get; set; }
		public string SecondImage { get; set; }
		public double Rating { get; set; }
		public double Price { get; set; }

	}
}
