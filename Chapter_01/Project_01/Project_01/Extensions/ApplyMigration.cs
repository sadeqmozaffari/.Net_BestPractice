using Microsoft.EntityFrameworkCore;
using Project_01.Data;

namespace Project_01.Extensions
{
    public static class ExtensionApplyMigration
    {
        public static void ApplyMigration(this IApplicationBuilder app)
        {
            using IServiceScope scope = app.ApplicationServices.CreateScope();

            using AppDBContext dbContext = scope.ServiceProvider.GetRequiredService<AppDBContext>();
            dbContext.Database.Migrate();
        }
    }
}
