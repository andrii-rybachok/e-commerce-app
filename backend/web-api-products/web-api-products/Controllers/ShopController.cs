using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web_api_products.DataBase;
using web_api_products.Models;
using web_api_products.Models.DTO.Products;
using web_api_products.Utils;

namespace web_api_products.Controllers
{
	[Route("api/shop")]
	[ApiController]
	[EnableCors("LocalHostPolicy")]
	public class ShopController : ControllerBase
	{
		private readonly ShopDB _context;
		private readonly Mapper mapper;

		public ShopController(ShopDB context)
		{
			_context = context;
			mapper = MapperConfig.InitializeAutomapper();
		}
		//[HttpGet]
		//public async Task<ActionResult<IEnumerable<ProductDTO>>> GetAllProducts()
		//{
		//	return mapper.Map<List<ProductDTO>>(await _context.Products.ToListAsync());
		//}

		[HttpGet("promoted")]
		public async Task<ActionResult<IEnumerable<ProductDTO>>> GetPromotedProducts()
		{
			//Imitation of getting promoted products
			var rand = new Random();
			int productsCount = await _context.Products.CountAsync()+1;
			List<int> randProductIds = new List<int>();
			do
			{
				int randomIndex = rand.Next(1, productsCount);
				if (!randProductIds.Contains(randomIndex))
				{
					randProductIds.Add(randomIndex);
				}
			} while (randProductIds.Count!=3);

			List<ProductDTO> products = new List<ProductDTO>();
			foreach (int productId in randProductIds)
			{
				products.Add(mapper.Map<ProductDTO>(await _context.Products.Include(x=>x.ProductImages).FirstOrDefaultAsync(x=>x.Id==productId)));
			}
			return products;
		}
	}
}
