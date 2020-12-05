using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using School.Management.Core.Repository;
using School.Management.Data;
using School.Management.Services;



namespace School.Management.MVC
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

            services.AddControllersWithViews();
            // adding DI for the services. 


            services.AddTransient<ISubjectRepository, SubjectRepository>();
            services.AddTransient<ISubjectService, SubjectService>();

            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<IStudentService,StudentService>();

            services.AddTransient<IClassService, ClassService>();
            services.AddTransient<IClassRepository, ClassRepository>();
        
            services.AddTransient<ITeacherService, TeacherService>();
            services.AddTransient<ITeacherRepository, TeacherRepository>();

            // Add application services.s

         
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
   
            app.UseCors();
   

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
          
        }
    }
}
