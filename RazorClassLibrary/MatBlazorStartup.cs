using Microsoft.AspNetCore.Hosting;
using MatBlazor;

namespace RazorClassLibrary
{
    public class MatBlazorStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            //builder.ConfigureServices((context, services) => {
            //    services.AddMatToaster(config =>
            //    {
            //        config.Position = MatToastPosition.BottomRight;
            //        config.PreventDuplicates = true;
            //        config.NewestOnTop = true;
            //        config.ShowCloseButton = true;
            //        config.MaximumOpacity = 95;
            //        config.VisibleStateDuration = 3000;
            //    });
            //});
        }
    }
}