using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using Teste.CrossCutting.DependencyInjection;
using Teste.CrossCutting.Mappings;

namespace Teste.Api
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

            services.ConfigureConexaoRepository(Configuration);

            ConfigureService.ConfigureDependenciesService(services);

            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new EntityToDtoProfile());                
            });

            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Api Core 6.0 DDD - Security",
                        Version = "v1",
                        Description = "API REST Teste Drugovich",
                        Contact = new OpenApiContact
                        {
                            Name = "Jefferson Benites Rabelo"
                        }
                    });
            });

            services.Configure<IdentityOptions>(options =>
            {
                // Default Password settings.
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 2;
                options.Password.RequiredUniqueChars = 1;

            });

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = true;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true
                };
            });

            services.AddRouting(r => r.SuppressCheckForUnhandledSecurityMetadata = true);

            services.AddControllers()
                .AddNewtonsoftJson();
            services.AddMvc(options => options.EnableEndpointRouting = false).SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
                .AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            //services.AddDbContext<MyContext>(
            //   options => options.UseSqlServer(ConnectionStringManager.GetConnectionString())

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Ativando middlewares para uso do Swagger

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = string.Empty;
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api AspNetCore 3.0");
            });

            // Redireciona o Link para o Swagger, quando acessar a rota principal
            var option = new RewriteOptions();
            option.AddRedirect("^$", "swagger");
            app.UseRewriter(option);

            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();

            //app.UseCorsMiddleware();
            app.UseMvc();
        }
    }
}
