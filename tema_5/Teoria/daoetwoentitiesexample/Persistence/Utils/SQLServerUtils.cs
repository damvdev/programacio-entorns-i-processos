
using Microsoft.Extensions.Configuration;
using System.IO;

namespace daoexample.Persistence.Utils
{
    public class SQLServerUtils
    {
        public static string OpenConnection() {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            return config.GetConnectionString("DefaultConnection");

        }
    }
}
