using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using web_api_products.DataBase;
using web_api_products.Models;
using web_api_products.Utils;

var MyAllowSpecificOrigins = "LocalHostPolicy";
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
	options.AddPolicy(name: MyAllowSpecificOrigins,
					  policy =>
					  {
						  policy.WithOrigins("http://localhost:3000");
					  });
});


builder.Services.AddControllers();
var connectionString = builder.Configuration.GetConnectionString("ShopApi") ?? throw new InvalidOperationException("No such a connection string");
builder.Services.AddDbContext<ShopDB>(options =>
	options.UseSqlServer(connectionString));
builder.Services.AddDefaultIdentity<ShopUser>(options => options.SignIn.RequireConfirmedAccount = false)
	.AddRoles<IdentityRole<int>>()
	.AddEntityFrameworkStores<ShopDB>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(MapperConfig));
var app = builder.Build();

if (File.Exists(@"BaseProductImages/Headphones/1_1.jpg"))
{
	Console.WriteLine("123");
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseStaticFiles(new StaticFileOptions
{
	FileProvider = new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath, "ProductImages")),
	RequestPath = "/images"
});

app.UseHttpsRedirection();

app.UseCors();
app.UseAuthorization();

app.MapControllers();

app.Run();
