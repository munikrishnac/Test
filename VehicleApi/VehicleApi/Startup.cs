// -------------------------------------------------------------------------------------------------
// Copyright (c) Johan Boström. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
// -------------------------------------------------------------------------------------------------

//namespace VehicleApi
//{
//    using Microsoft.AspNetCore.Builder;
//    using Microsoft.AspNetCore.Hosting;
//    using Microsoft.AspNetCore.Rewrite;
//    using Microsoft.Extensions.Configuration;
//    using Microsoft.Extensions.DependencyInjection;
//    using Middlewares;
//    using VehicleApi.Data;
//    using VehicleApi.Interfaces;

//    public class Startup
//    {
//        public Startup(IConfiguration configuration)
//        {
//            Configuration = configuration;
//        }

//        public IConfiguration Configuration { get; }

//        // This method gets called by the runtime. Use this method to add services to the container.
//        public void ConfigureServices(IServiceCollection services)
//        {
//            services.AddMvc();
//            services.AddTransient<IVehicleRepository, VehicleRepository>();
//        }

//        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
//        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
//        {
//            app.UseCors("CorsPolicy");

//            if (env.IsDevelopment())
//            {
//                app.UseDeveloperExceptionPage();
//            }
//            app.UseAuthentication();
//            app.UseMvc();
//            app.UseSwagger(c => { c.RouteTemplate = "api/swagger/{documentName}/swagger.json"; }); app.UseSwaggerUI(c => { c.SwaggerEndpoint("v1/swagger.json", "Some API"); c.RoutePrefix = "api/swagger"; });

//            app.Map("/middelware", b =>
//            {
//                b.UseMiddleware<BasicAuthMiddleware>("example.com");
//                b.UseMvc();
//            });

//            //if (env.IsDevelopment())
//            //{
//            //    app.UseDeveloperExceptionPage();
//            //}

//            //app.UseMvc();

//        }
//    }
//}

using AppApi.Model;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Swagger;
using System.Text;
using VehicleApi.Data;
using VehicleApi.Interfaces;
using VehicleApi.Middlewares;

namespace VehicleApi
{
    public class Startup
    {
        //private static readonly string secretKey = "mysupersecret_secretkey!123";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });

            //services.AddMvc(options =>
            //{
            //    // All endpoints need authentication
            //    // Custom auth filter
            //    options.Filters.Add(new CustomAuthorizeFilter(new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build()));
            //});
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(cfg =>
                {
                    cfg.RequireHttpsMetadata = false;
                    cfg.SaveToken = true;

                    cfg.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidIssuer = "me",
                        ValidAudience = "you",
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("rlyaKithdrYVl6Z80ODU350md")) //Secret
                    };

                });

            services.AddMvc();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "API", Version = "v1" });
            });
            services.Configure<Settings>(options =>
            {
                options.ConnectionString = Configuration.GetSection("MongoConnection:ConnectionString").Value;
                options.Database = Configuration.GetSection("MongoConnection:Database").Value;
            });

            services.AddTransient<IVehicleRepository, VehicleRepository>();
            services.AddTransient<Iechallan, eChallanRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors("CorsPolicy");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseAuthentication();
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Generate Random Data API V1");
            });

            var redirectRootToSwagger = new RewriteOptions()
                .AddRedirect("^$", "swagger");
            app.UseRewriter(redirectRootToSwagger);
            app.Map("/middelware", b =>
            {
                b.UseMiddleware<BasicAuthMiddleware>("example.com");
                b.UseMvc();
            });
            // app.UseMiddleware<AuthenticationMiddleware>();
        }
    }
}