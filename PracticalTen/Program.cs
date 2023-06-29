namespace PracticalTen
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            builder.Services.AddResponseCaching();

            builder.Services.AddRouting();

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error/500");
            }

            app.UseResponseCaching();

            app.UseStatusCodePagesWithReExecute("/Error/{0}");

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapControllers();

            app.MapControllerRoute(
                name: "Default",
                pattern: "{controller=TestTwo}/{action=Index}"
            );
            
            app.Run();
        }
    }
}