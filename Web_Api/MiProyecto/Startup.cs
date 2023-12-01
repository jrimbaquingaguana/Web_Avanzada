using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace MiProyecto
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {

            // Configuración de autenticación con tokens JWT
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = "jose",
                    ValidAudience = "jose",
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("jose"))
                };
            });
             services.AddAuthorization(options =>
    {
        options.AddPolicy("RequiereRolAdmin", policy => policy.RequireRole("Admin"));
    });

        }

        public void Configure(IApplicationBuilder app)
        {
            
            app.UseAuthentication();
            app.UseMvc(routes =>
                 {
                    routes.MapRoute(
                        name: "default",
                        template: "{controller=Home}/{action=Index}/{id?}");
                 });
             app.UseMvc(routes =>
                 {
        routes.MapRoute(
            name: "default",
            template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
