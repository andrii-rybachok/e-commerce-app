
namespace web_api_products.Models
{
	public class Category
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public Image Image { get; set; }

		public IEnumerable<Producer> ProductsProducers { get; set; }	
		public IEnumerable<FilterName> Filters { get; set; }
		public IEnumerable<Product> Products { get; set; }

	}
}	
