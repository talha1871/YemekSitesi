using BL_YemekSitesi.Managers.Abstract;
using BL_YemekSitesi.Managers.Concreate;
using DAL_YemekSitesi.Context;
using DAL_YemekSitesi.Repositories.Abstract;
using DAL_YemekSitesi.Repositories.Concreate;
using System.Reflection;
using YemekSitesiApi.Hubs;

var builder = WebApplication.CreateBuilder(args);
//Cors Policy ve AddSignalR
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", builder =>
    {
        builder.AllowAnyHeader()
        .AllowAnyMethod()
        .SetIsOriginAllowed((host) => true)
        .AllowCredentials();
    });
});
builder.Services.AddSignalR();


// Add services to the container.
// --- AUTOMAPPPER

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());


// --- IOC KATMANLARI ---
builder.Services.AddDbContext<SignalRContext>();
// --- IOC-ABOUT_MANAGER
builder.Services.AddScoped<IAboutManager, AboutManager>();
builder.Services.AddScoped<IAboutRepository, AboutRepository>();
// --- IOC-BOOKING_MANAGER
builder.Services.AddScoped<IBookingManager, BookingManager>();
builder.Services.AddScoped<IBookingRepository, BookingRepository>();
// --- IOC-CATEGORY-MANAGER - AUTOMAPPER
builder.Services.AddScoped<ICategoryManager, CategoryManager>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
// --- IOC-CONTACT-MANAGER - AUTOMAPPER
builder.Services.AddScoped<IContactManager, ContactManager>();
builder.Services.AddScoped<IContactRepository, ContactRepository>();
// --- IOC-DISCOUNT-MANAGER - AUTOMAPPER
builder.Services.AddScoped<IDiscountManager, DiscountManager>();
builder.Services.AddScoped<IDiscountRepository, DiscountRepository>();
// --- IOC-FEATURE-MANAGER - AUTOMAPPER
builder.Services.AddScoped<IFeatureManager, FeatureManager>();
builder.Services.AddScoped<IFeatureRepository, FeatureRepository>();
// --- IOC-PRODUCT-MANAGER - AUTOMAPPER
builder.Services.AddScoped<IProductManager, ProductManager>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
// --- IOC-SOCIALMEDIA-MANAGER - AUTOMAPPER
builder.Services.AddScoped<ISocialMediaManager, SocialMediaManager>();
builder.Services.AddScoped<ISocialMediaRepository, SocialMediaRepository>();
// --- IOC-FEATURE-MANAGER - AUTOMAPPER
builder.Services.AddScoped<ITestimonialManager, TestimonialManager>();
builder.Services.AddScoped<ITestimonialRepository, TestimonialRepository>();
// -- IOC-ORDER AND ORDER DETAILS -AUTOMAPPER
builder.Services.AddScoped<IOrderDetailManager, OrderDetailManager>();
builder.Services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
builder.Services.AddScoped<IOrderManager, OrderManager>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
// -- IOC-// -- IOC-MoneyCase -AUTOMAPPER -AUTOMAPPER
builder.Services.AddScoped<IMoneyCaseManager, MoneyCaseManager>();
builder.Services.AddScoped<IMoneyCaseRepository, MoneyCaseRepository>();
// -- IOC-// -- IOC-MoneyCase -AUTOMAPPER -AUTOMAPPER
builder.Services.AddScoped<IRestaurantTableManager, RestaurantTableManeger>();
builder.Services.AddScoped<IRestaurantTableRepository, RestaurantTableRepository>();
// -- IOC-// -- IOC-SLIDER -AUTOMAPPER -AUTOMAPPER
builder.Services.AddScoped<ISliderManager, SliderManager>();
builder.Services.AddScoped<ISliderRepository, SliderRepository>();
//// --- IOC-PRODUCTWITHCATEGORIES-MANAGER - AUTOMAPPER
//builder.Services.AddScoped<IPROD, TestimonialManager>();
//builder.Services.AddScoped<ITestimonialRepository, TestimonialRepository>();




builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
// endpoint yazmam gereken kýsým SignalR için
app.MapHub<SignalRHub>("/signalrhub"); 
app.Run();
