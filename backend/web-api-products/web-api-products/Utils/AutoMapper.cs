using AutoMapper;
using web_api_products.Models;
using web_api_products.Models.DTO.Categories;
using web_api_products.Models.DTO.Products;

namespace web_api_products.Utils
{
	public static class Mappers
	{
		private static string[] getImages(IEnumerable<Image> images)
		{
			string[] names = new string[images.Count()];
			for (int i = 0; i < names.Count(); i++)
			{
				names[i] = images.ElementAt(i).Name;
			}
			return names;
		}
		public static Mapper ProductDTOMapper()
		{

			var config = new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<Product, ProductDTO>()
				.ForMember(x => x.PreviewImage, act =>act.MapFrom(src=>src.ProductImages.FirstOrDefault().Name))
				.ForMember(x => x.SecondImage, act => act.MapFrom(src => src.ProductImages.ElementAtOrDefault(1).Name));
			});
			var mapper = new Mapper(config);
			return mapper;
		}
		public static Mapper PopularCategoryDTOMapper()
		{

			var config = new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<Category, PopularCategoryDTO>();
			});
			var mapper = new Mapper(config);
			return mapper;
		}
	}
}
