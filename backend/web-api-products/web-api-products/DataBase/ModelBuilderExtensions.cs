using Microsoft.EntityFrameworkCore;
using web_api_products.Models;
using web_api_products.Models.Gadgets;
using web_api_products.Utils;

namespace web_api_products.DataBase
{
	public static class ModelBuilderExtensions
	{
		public static void Seed(this ModelBuilder modelBuilder)
		{
			List<Category> categories = new List<Category>()
			{
				new Category { Id=1,Name = "Headphones" },
				new Category { Id=2,Name = "Laptops" },
			};
			modelBuilder.Entity<Category>().HasData(categories);

			modelBuilder.Entity<FilterName>().HasData(
				new FilterName() { Id=1, CategoryId=1, Name="HeadphoneType"},
				new FilterName() { Id = 2, CategoryId = 2, Name = "GraphicCard" }

				);
			List<FilterValue> filters = new List<FilterValue>()
			{
				new FilterValue (){ Id=1, Value=HeadphoneType.TWS.ToString(), FilterNameId=1, IsActive=false },
				new FilterValue (){ Id=2, Value=HeadphoneType.Wired.ToString(), FilterNameId=1, IsActive=false },
				new FilterValue (){ Id=3, Value=HeadphoneType.Wireless.ToString(), FilterNameId=1, IsActive=false },
				new FilterValue (){ Id=4, Value="RTX 3060", FilterNameId=2, IsActive=false },
				new FilterValue (){ Id=5, Value="RTX 3070", FilterNameId=2, IsActive=false },

			};
			modelBuilder.Entity<FilterValue>().HasData(filters);

			List<Producer> producer =new List<Producer>() 
			{
				new Producer {Id=1, Name = "Sony" },
				new Producer {Id=2, Name = "Bose" },
				new Producer {Id=3, Name = "Sennheiser" },
				new Producer {Id=4, Name = "Audio-Technica" },
				new Producer {Id=5,Name="Apple"},
				new Producer {Id=6,Name="Asus"},
			};
			modelBuilder.Entity<Producer>().HasData(producer);

			List<Headphone> headphones = new List<Headphone>()
			{
				new Headphone { Id=1,Name = "Bose QuietComfort 35 II", Description = "Noise cancelling headphones", Price = 349.99,ProducerId=1, HeadphoneType = HeadphoneType.TWS , CategoryId=1},
				new Headphone { Id=2,Name = "Sony WH-1000XM4", Description = "Noise cancelling headphones", Price = 349.99,ProducerId=2, HeadphoneType = HeadphoneType.Wireless , CategoryId=1},
				new Headphone { Id=3,Name = "Apple AirPods Pro", Description = "Wireless earbuds with noise cancelling", Price = 249.99, ProducerId=3, HeadphoneType= HeadphoneType.Wired , CategoryId=1},
				new Headphone { Id=4,Name = "Samsung Galaxy Buds Pro", Description = "Wireless earbuds with noise cancelling", Price = 199.99, ProducerId=4, HeadphoneType = HeadphoneType.Wireless, CategoryId=1},
				new Headphone { Id=5,Name = "Sonos Beam", Description = "Smart soundbar for TV", Price = 399.99,ProducerId=1, HeadphoneType= HeadphoneType.TWS, CategoryId=1},
				new Headphone { Id=6,Name = "Bose Soundbar 700", Description = "Smart soundbar for TV", Price = 799.99,ProducerId=2, HeadphoneType= HeadphoneType.Wired, CategoryId=1},
				new Headphone { Id=7,Name = "Vizio Elevate", Description = "Dolby Atmos soundbar for TV", Price = 999.99,ProducerId=3, HeadphoneType= HeadphoneType.Wireless, CategoryId=1},
				new Headphone { Id=8,Name = "LG SK10Y", Description = "Dolby Atmos soundbar for TV", Price = 749.9,ProducerId=4, HeadphoneType= HeadphoneType.TWS, CategoryId=1}
			};
			modelBuilder.Entity<Headphone>().HasData(headphones);
			var laptops = new List<Laptop>
			{
				new Laptop
				{
					Id=9,
					Name = "MacBook Air",
					Description = "The MacBook Air is a thin and light laptop with a Retina display and Touch ID.",
					Price = 999.99,
					ProducerId=5,
					GraphicCard = "Intel Iris Plus Graphics",
					CategoryId=2
				},
				new Laptop
				{
					Id=10,
					Name = "Asus ZenBook UX425",
					Description = "The Asus ZenBook UX425 is a sleek and powerful laptop with an OLED display.",
					Price = 1199.99,
					ProducerId=6,
					GraphicCard = "Intel Iris Xe Graphics",
					CategoryId=2
				}
			};
			modelBuilder.Entity<Laptop>().HasData(laptops);


			List<string> headphoneSrcs = new List<string>() {
				"1_1.jpg" ,
				"1_2.jpg" ,
				"1_3.jpg" ,
				"2_1.jpg" ,
				"2_2.jpg" ,
				"3_1.jpg" ,
				"4_1.jpg" ,
				"5_1.jpg" ,
				"6_1.jpg" ,
				"7_1.jpg" ,
				"8_1.jpg" ,
			};
			List<Image>	images = new List<Image>();
			for (int i = 0; i < headphoneSrcs.Count; i++)
			{
				images.Add(new Image { Id = i + 1, Name = headphoneSrcs[i] });
			}
			for (int i = 0; i < 3; i++)
			{
				images[i].ProductId = 1;
			}
			for (int i = 3; i < 5; i++)
			{
				images[i].ProductId = 2;
			}
			for (int i = 5,id=3; i < 11; i++,id++)
			{
				images[i].ProductId = id;
			}

			List<Image>	laptopImgs = new List<Image>()
			{
				new Image() { Id= 12, CategoryId=1,Name = "headphone_category.jpg" },
				new Image() { Id= 13,ProductId=9,Name ="9_1.jpg"},
				new Image() { Id= 14,ProductId=9,Name = "9_2.jpg"},
				new Image() { Id= 15,ProductId=10,Name = "10_1.jpg"},
			};
			images.AddRange(laptopImgs);
			modelBuilder.Entity<Image>().HasData(images);

		}
	}
}
