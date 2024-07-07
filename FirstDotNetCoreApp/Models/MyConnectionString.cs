using Microsoft.EntityFrameworkCore;

namespace FirstDotNetCoreApp.Models
{
    public static class MyConnectionString 
    {
        private static readonly string _connectionString = "Server = DESKTOP-MKVNNS0; Database = myAppDB; Trusted_Connection=true; TrustServerCertificate = true; MultipleActiveResultSets = true";
        public static string ConnectionString { get { return _connectionString; } }
    }
}
