using BLL_Shared.DAL;
using DevExpress.Blazor;
using ShopFloorBlazorWebApp.Components;
using Syncfusion.Blazor;

namespace ShopFloorBlazorWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents()
                .AddInteractiveWebAssemblyComponents();

            builder.Services.AddDevExpressBlazor(configure => configure.BootstrapVersion = BootstrapVersion.v5);
            builder.Services.AddSingleton<IDBService, DapperDBService>();

            builder.Services.AddSyncfusionBlazor();

            builder.Configuration.AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json");

            builder.Services.AddSingleton(p => new DBConnectionConfiguration()
            {
                ConnectionString = builder.Configuration.GetConnectionString("DefaultConnection")
                    ?? throw new Exception("Connection string was not found!")
            });


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode()
                .AddInteractiveWebAssemblyRenderMode()
                .AddAdditionalAssemblies(typeof(Client._Imports).Assembly);

            app.Run();
        }
    }
}
