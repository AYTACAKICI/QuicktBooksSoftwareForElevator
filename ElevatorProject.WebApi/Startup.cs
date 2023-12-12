using ElevatorProject.BusinessLayer.Abstract;
using ElevatorProject.BusinessLayer.Concrete;
using ElevatorProject.DataAccessLayer.Abstract;
using ElevatorProject.DataAccessLayer.Concrete;
using ElevatorProject.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElevatorProject.WebApi
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
            services.AddScoped<IStaffService, StaffManager>();

            services.AddScoped<IAboutDal, EfAboutDal>();
            services.AddScoped<IAboutService, AboutManager>();

            services.AddScoped<IBreakdownRecordDal, EfBreakdownRecordDal>();
            services.AddScoped<IBreakdownRecordService, BreakdownRecordManager>();

            services.AddScoped<IBuildingManagerDal, EfBuildingManagerDal>();
            services.AddScoped<IBuildingManagerService, BuildManagerManager>();

            services.AddScoped<IElevatorDal, EfElevatorDal>();
            services.AddScoped<IElevatorService, ElevatorManager>();

            services.AddScoped<IPeriodicMaintainceDal, EfPeriodicMaintainceDal>();
            services.AddScoped<IPeriodicMaintainceService, PeriodicMaintainceManager>();

            services.AddScoped<IRevisionDal, EfRevisionDal>();
            services.AddScoped<IRevisionService, RevisionManager>();

            services.AddScoped<IServiceDal, EfServiceDal>();
            services.AddScoped<IServiceService, ServiceManager>();

            services.AddScoped<ITestimonialDal, EfTestimonialDal>();
            services.AddScoped<ITestimonialService, TestimonialManager>();

            services.AddScoped<IGuestDal, EfGuestDal>();
            services.AddScoped<IGuestService, GuestManager>();

            services.AddScoped<IContactDal, EfContactDal>();
            services.AddScoped<IContactService, ContactManager>();

            services.AddScoped<ISendMessageDal, EfSendMessageDal>();
            services.AddScoped<ISendMessageService, SendMessageManager>();

            services.AddScoped<IMessageCategoryDal, EfMessageCategoryDal>();
            services.AddScoped<IMessageCategoryService, MessageCategoryManager>();

            services.AddScoped<IAppUserDal, EfAppUserDal>();
            services.AddScoped<IAppUserService, AppUserManager>();

            services.AddScoped<IOfferDal, EfOfferDal>();
            services.AddScoped<IOfferService, OfferManager>();

            services.AddAutoMapper(typeof(Startup));

            services.AddCors(opt =>
            {
                opt.AddPolicy("ElevatorProject", opts =>
                {
                    opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ElevatorProject.WebApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ElevatorProject.WebApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("ElevatorProject");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
