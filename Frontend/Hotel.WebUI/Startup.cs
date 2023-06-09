using FluentValidation;
using FluentValidation.AspNetCore;
using Hotel.DataAccessLayer.Concrete;
using Hotel.EntityLayer.Concrete;
using Hotel.WebUI.Dtos.GuestDto;
using Hotel.WebUI.ValidationRules.GuestValidationRules;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.WebUI
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
			services.AddDbContext<Context>();
			services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<Context>();

            services.AddAutoMapper(typeof(Startup));

            services.AddHttpClient();
			services.AddTransient<IValidator<GuestCreateDto>, GuestCreateValidator>();
			services.AddTransient<IValidator<GuestUpdateDto>, GuestUpdateValidator>();
			services.AddControllersWithViews().AddFluentValidation();
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
				app.UseExceptionHandler("/Home/Error");
			}
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Register}/{action=Index}/{id?}");
			});
		}
	}
}
