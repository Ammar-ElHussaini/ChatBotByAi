
using ChatBotByAi.Co;
using ChatBotByAi.Services;

namespace ChatBotByAi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

          builder.Services.AddControllersWithViews();
            builder.Services.AddSignalR();
            builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));

            var appSettings = builder.Configuration.GetSection("AppSettings").Get<AppSettings>();

            builder.Services.AddSingleton<IAiService, AiService>();
            builder.Services.AddSingleton<RequestApi>();
            builder.Services.AddSingleton<ExternalInformation>();

            var app = builder.Build();

        

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapHub<ChatHub>("/chatHub");

            app.Run();
        }
    }
}
