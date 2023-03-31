namespace web_api_products.Models
{
	public class FilterValue
	{

		public int Id { get; set; }
		public string Value { get; set; }
		public bool IsActive { get; set; }

		public int FilterNameId { get; set; }
		public  FilterName FilterName { get; set; }

		
	}
}
