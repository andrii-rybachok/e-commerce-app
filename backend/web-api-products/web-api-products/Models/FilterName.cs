namespace web_api_products.Models
{
	public class FilterName
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public int CategoryId { get; set; }
		public  Category Category { get; set; }

		public  IEnumerable<FilterValue> Values { get; set; }	
	}
}
