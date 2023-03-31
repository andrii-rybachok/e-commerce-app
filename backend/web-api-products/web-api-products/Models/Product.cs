namespace web_api_products.Models
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public bool IsAvailable { get; set; }
		public double Price { get; set; }

		public int CategoryId { get; set; }
		public Category Category { get; set; }

		public Producer Producer { get; set; }
		public int ProducerId { get; set; }

		public IEnumerable<Color> Colors { get; set; }

		public IEnumerable<Image> ProductImages { get; set; }=new List<Image>();



	}
}	
