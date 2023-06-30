namespace PracticalTen
{
    public static class Program
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
                //Handle Exceptions
                app.UseExceptionHandler("/Error/500");
            }

            app.UseResponseCaching();

            //Handle Errors
            app.UseStatusCodePagesWithReExecute("/Error/{0}");

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            //Default application route
            app.MapControllerRoute(
                name: "Default",
                pattern: "{controller=TestTwo}/{action=Index}"
            );
            
            app.Run();
        }
    }
}