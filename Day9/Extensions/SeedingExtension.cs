using Day9.Data;
namespace Day9.Extensions
{
    public static class SeedingExtension
    {
        public static WebApplication SeedData(this WebApplication host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                PersonContext context = services.GetService<PersonContext>();
                new PersonSeeder(context).SeedData();
            }

            return host;
        }
    }
}