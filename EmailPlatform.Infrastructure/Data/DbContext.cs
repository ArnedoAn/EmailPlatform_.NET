using Microsoft.Extensions.Configuration;
namespace EmailPlatform.Infrastructure.Data
{
    public class DbContext
    {
        private string connectionString = string.Empty;

        public DbContext()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            connectionString = builder.GetConnectionString("dbConnection") ?? string.Empty;
        }

        public string ConnectionString()
        {
            return "Data Source=localhost;Initial Catalog=EmailDB;Integrated Security=True;";
        }

    }
}
