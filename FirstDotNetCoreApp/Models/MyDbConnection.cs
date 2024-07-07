using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using FirstDotNetCoreApp.Models;

namespace FirstDotNetCoreApp.Models
{
    public class MyDbConnection :DbContext
    {
        //public MyDbConnection(DbContextOptions<MyDbConnection> Options) : base(Options)
        //{

        //}
        //public DbSet<Employee> Employees { get; set; } = default!;
    }
}
