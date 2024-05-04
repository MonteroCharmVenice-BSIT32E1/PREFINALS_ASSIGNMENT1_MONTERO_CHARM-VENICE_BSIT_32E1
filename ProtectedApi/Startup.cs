using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace ProtectedApi
{
    public class Startup
    {
        // Other configurations...

        public void ConfigureServices(IServiceCollection services)
        {
            // Add JWT authentication
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = Configuration["JwtSettings:Issuer"],
                        ValidAudience = Configuration["JwtSettings:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Secret.JwtSigningKey))
                    };
                });

            // Other configurations...
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Other configurations...

            app.UseAuthentication();
            app.UseAuthorization();

            // Other configurations...
        }
    }
}
