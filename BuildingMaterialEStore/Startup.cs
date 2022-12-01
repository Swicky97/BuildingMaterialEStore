using BuildingMaterialEStore.Database;
using BuildingMaterialEStore.Infrastructure;
using BuildingMaterialEStore.Models.Shared;
using BuildingMaterialEStore.Repositories;
using BuildingMaterialEStore.Repositories.Implementations;
using BuildingMaterialEStore.Service;
using BuildingMaterialEStore.Service.Implementations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Collections.Generic;

namespace BuildingMaterialEStore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Building Materials E-Store", Version = "v1" });

                c.AddSecurityDefinition("Bearer",
                    new OpenApiSecurityScheme
                    {
                        Description = "JWT Authorization header using the Bearer scheme.",
                        Type = SecuritySchemeType.Http,
                        Scheme = "bearer"
                    });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement{
                    {
                        new OpenApiSecurityScheme{
                            Reference = new OpenApiReference{
                                Id = "Bearer",
                                Type = ReferenceType.SecurityScheme
                            }
                        },
                        new List<string>()
                    }
                });
            });
            services.AddDbContext<BmesDbContext>(options => options.UseSqlite(Configuration["Data:BmesApi:ConnectionString"]));
            services.AddDbContext<BmesIdentityDbContext>(options => options.UseSqlite(Configuration["Data:BmesIdentity:ConnectionString"]));

            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<BmesIdentityDbContext>();

            services.AddJwtAuth(Configuration);

            services.AddTransient<IBrandRepository, BrandRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<ICartRepository, CartRepository>();
            services.AddTransient<ICartItemRepository, CartItemRepository>();
            services.AddTransient<IAddressRepository, AddressRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IOrderItemRepository, OrderItemRepository>();
            services.AddTransient<IAuthRepository, AuthRepository>();

            services.AddTransient<IBrandService, BrandService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<ICatalogueService, CatalogueService>();
            services.AddTransient<ICartService, CartService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<ICheckoutService, CheckoutService>();
            services.AddTransient<IAuthService, AuthService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Building Materials E-Store V1");
            });

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // Create a service scope to get an BmesIdentityDbContext instance using DI
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var dbContext = serviceScope.ServiceProvider.GetService<BmesIdentityDbContext>();
                var roleManager = serviceScope.ServiceProvider.GetService<RoleManager<IdentityRole>>();
                var userManager = serviceScope.ServiceProvider.GetService<UserManager<User>>();
                // Create the Db if it doesn't exist and applies any pending migration.
                //dbContext.Database.Migrate();

                IdentityDbSeeder.Seed(dbContext, roleManager, userManager);
            }
        }
    }
}
