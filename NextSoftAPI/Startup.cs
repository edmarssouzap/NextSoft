using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.OpenApi.Models;
using NextSoftAPI.Data;

namespace NextSoftAPI
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
            var caminhoProjeto = PlatformServices.Default.Application.ApplicationBasePath;
            var NomeProjeto = $"{PlatformServices.Default.Application.ApplicationName}.xml";
            var ArquivoXMLSwagger = caminhoProjeto + NomeProjeto;

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {    
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "NextSoftAPI", Version = "v1" });
                c.IncludeXmlComments(ArquivoXMLSwagger);
            });

            services.AddDbContext<NextSoftAPIDataContext>(opt =>
                opt.UseSqlServer(Configuration.GetConnectionString("NextSoftAPIDataContext")));
           }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "NextSoftAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            // Habilitando acesso a API - Limitar o acesso
            app.UseCors(
                x => x.AllowAnyHeader()
                .AllowAnyMethod()
                .AllowAnyOrigin()
            );

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
