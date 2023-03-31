using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web_api_products.DataBase;
using web_api_products.Models;

namespace web_api_products.Controllers
{
	[Route("api/shop")]
	[ApiController]
	public class ShopController : Controller
	{
		private readonly ShopDB _context;

		public ShopController(ShopDB context)
		{
			_context = context;
		}
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Product>>> GetTodoItems()
		{
			return await _context.Products.ToListAsync();
		}

	}
}
