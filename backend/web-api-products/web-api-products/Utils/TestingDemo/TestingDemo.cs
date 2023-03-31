using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Reflection.Metadata;
using web_api_products.DataBase;
using web_api_products.Models;
using web_api_products.Models.Gadgets;

namespace web_api_products.Utils.TesingDemo
{
	[TestClass]
	public class NonQueryTests
	{
		[TestMethod]
		public void CreateProduct_saves_a_product_via_context()
		{
			var mockSet = new Mock<DbSet<Product>>();

			var mockContext=new Mock<ShopDB>();
			mockContext.Setup(m=>m.Products).Returns(mockSet.Object);

			var service = new ProductService(mockContext.Object);
			service.AddProduct(new Headphone { Name = "SoundBlast", Description = "Premium noise-canceling headphones", Price = 299, Producer = new Producer() { Name="Bose"}, HeadphoneType =HeadphoneType.Wireless });

			mockSet.Verify(m => m.Add(It.IsAny<Product>()), Times.Once());
			mockContext.Verify(m => m.SaveChanges(), Times.Once());
			
		}
	}
}
