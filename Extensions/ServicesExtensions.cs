
using System.Text;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

namespace API.Extensions;

public static class ServicesExtensions
{
    public static void ConfigureIdentity(this IServiceCollection services)
    {
        var builder = services.AddIdentityCore<User>(q =>
        {
            q.User.RequireUniqueEmail = true;
            q.Password.RequireNonAlphanumeric = false;
        });
        builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole), services);
        builder.AddEntityFrameworkStores<CommerceDataContext>().AddDefaultTokenProviders();
    }

    public static void ConfigureJWT(this IServiceCollection services, IConfiguration config)
    {
        services.AddAuthentication(opts =>
        {
            opts.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            opts.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(opts =>
        {
            opts.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                ValidateLifetime = true,
                ValidateIssuer = true,
                ValidIssuer = config["Token:Issuer"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Token:Key"])),
                ValidateAudience = false
            };
        });
    }

    public static void ConfigureSwaggerDoc(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Furniture API", Description = "Furniture API", Version = "v1" });
            c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Description = @"JWT Authorization header using the Bearer scheme. 
                      Enter 'Bearer' [space] and then your token in the text input below.
                      Example: 'Bearer 12345abcdef'",
                Name = "Authorization",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.ApiKey,
                Scheme = "Bearer"
            });

            c.AddSecurityRequirement(new OpenApiSecurityRequirement() {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "0auth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header
                        },
                        new List<string>()
                    }
            });
        });
    }
}