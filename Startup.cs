using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using realmCommander.Repositories;
using realmCommander.Services;

namespace realmCommander
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
      services.AddControllers();

      services.AddScoped<IDbConnection>(x => CreateDbConnection());



      //NOTE Adding those Mangie Transient Services
      services.AddTransient<KnightsService>();
      services.AddTransient<KnightsRepository>();
      services.AddTransient<QuestsService>();
      services.AddTransient<QuestsRepository>();
      services.AddTransient<KnightsQuestsService>();
      services.AddTransient<KnightsQuestsRepository>();

      //NOTE Managed to get my relationships going! Woot Woot! 
    }

    private IDbConnection CreateDbConnection()
    {
      var connectionString = Configuration["db:gearhost"];
      return new MySqlConnection(connectionString);
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseHttpsRedirection();

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
