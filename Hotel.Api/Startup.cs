using Hotel.BusinessLayer.Abstract;
using Hotel.BusinessLayer.Concrete;
using Hotel.DataAccessLayer.Abstract;
using Hotel.DataAccessLayer.Concrete;
using Hotel.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Api
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

			services.AddScoped<IStaffDal, EfStaffDal>();
			services.AddScoped<IStaffService,StaffManager>();

			services.AddScoped<IServiceDal, EfServiceDal>();
			services.AddScoped<IServiceService, ServiceManager>();

			services.AddScoped<IRoomDal, EfRoomDal>();
			services.AddScoped<IRoomService, RoomManager>();

			services.AddScoped<ISubscribeDal, EfSubscribeDal>();
			services.AddScoped<ISubscribeService, SubscribeManager>();

			services.AddScoped<ITestimonialDal, EfTestimonialDal>();
			services.AddScoped<ITestimonialService, TestimonialManager>();

            services.AddScoped<IAboutDal, EfAboutDal>();
            services.AddScoped<IAboutService, AboutManager>();

            services.AddScoped<IBookingDal, EfBookingDal>();
            services.AddScoped<IBookingService, BookingManager>();

            services.AddScoped<IGuestDal, EfGuestDal>();
            services.AddScoped<IGuestService, GuestManager>();

            services.AddAutoMapper(typeof(Startup));

			services.AddCors(opt =>
			{
				opt.AddPolicy("HotelApiCors", opts =>
				{
					opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
				});
			});

			services.AddControllers();
			services.AddSwaggerGen();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			app.UseSwagger();
			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "Employee API V1");
			});

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseRouting();

			app.UseCors("HotelApiCors");

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
