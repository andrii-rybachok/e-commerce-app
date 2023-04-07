using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web_api_products.DataBase;
using web_api_products.Models.DTO.Categories;
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
		const int maxPopularProducts = 10;
		public ShopController(ShopDB context)
		{
			_context = context;
		}

		[HttpGet("promoted")]
		public async Task<ActionResult<IEnumerable<ProductDTO>>> GetPromotedProducts()
		{
			//Imitation of getting promoted products
			var rand = new Random();
			int productsCount = await _context.Products.CountAsync() + 1;
			List<int> randProductIds = new List<int>();
			do
			{
				int randomIndex = rand.Next(1, productsCount);
				if (!randProductIds.Contains(randomIndex))
				{
					randProductIds.Add(randomIndex);
				}
			} while (randProductIds.Count != 4);

			List<ProductDTO> products = new List<ProductDTO>();
			foreach (int productId in randProductIds)
			{
				products.Add(Mappers.ProductDTOMapper().Map<ProductDTO>(await _context.Products.Include(x => x.ProductImages).FirstOrDefaultAsync(x => x.Id == productId)));
			}
			return products;
		}
		[HttpGet("popularCategories")]
		public async Task<ActionResult<IEnumerable<PopularCategoryDTO>>> GetPopularcategories()
		{
			//You can implement method to get popular categories, but for now it takes firsst 4 categories
			var popularCategories = await _context.Categories.Take(4).ToListAsync();
			return Mappers.PopularCategoryDTOMapper().Map<List<PopularCategoryDTO>>(popularCategories);
		}
		[HttpGet("popular")]
		public async Task<ActionResult<IEnumerable<ProductDTO>>> GetPopularProducts(string categoryName)
		{
			//Same with pop. categories

			var popularProducts = await _context.Products.Include(x => x.Category).Include(x => x.ProductImages)
				.Where(x => x.Category.Name.Equals(categoryName))
				.Take(maxPopularProducts)
				.ToListAsync();
			return Mappers.ProductDTOMapper().Map<List<ProductDTO>>(popularProducts);
		}

	}
}
