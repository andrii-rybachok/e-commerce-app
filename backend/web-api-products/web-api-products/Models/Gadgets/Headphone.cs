namespace web_api_products.Models.Gadgets
{
	public enum HeadphoneType
	{
		TWS,
		Wired,
		Wireless
	}
	public class Headphone:Product
	{
		public HeadphoneType HeadphoneType { get; set; }
	}
}
