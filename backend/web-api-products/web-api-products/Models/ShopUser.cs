using Microsoft.AspNetCore.Identity;

namespace web_api_products.Models
{
    public class ShopUser : IdentityUser<int>
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
