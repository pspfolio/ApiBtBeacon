using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using BTBeaconAPI.Data;
using Microsoft.EntityFrameworkCore;
using BTBeaconAPI.Data.Seed;

namespace BTBeaconAPI
{
	public class Startup
	{
		public Startup(IHostingEnvironment env)
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(env.ContentRootPath)
				.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
				.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

			if (env.IsEnvironment("Development"))
			{
				// This will push telemetry data through Application Insights pipeline faster, allowing you to view results immediately.
				builder.AddApplicationInsightsSettings(developerMode: true);
			}

			builder.AddEnvironmentVariables();
			_config = builder.Build();
		}

		IConfigurationRoot _config;

		// This method gets called by the runtime. Use this method to add services to the container
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddSingleton(_config);
			// Add framework services.
			services.AddApplicationInsightsTelemetry(_config);

			services.AddDbContext<BeaconContext>(options => options.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Beacon;Trusted_Connection=True;MultipleActiveResultSets=true"));
			services.AddTransient<BeaconDbInitializer>();

			services.AddMvc();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline
		public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, BeaconDbInitializer seeder)
		{
			loggerFactory.AddConsole(_config.GetSection("Logging"));
			loggerFactory.AddDebug();

			app.UseApplicationInsightsRequestTelemetry();

			app.UseApplicationInsightsExceptionTelemetry();

			app.UseMvc();

			seeder.Seed().Wait();
		}
	}
}
