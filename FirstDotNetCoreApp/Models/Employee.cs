using System.ComponentModel.DataAnnotations;

namespace FirstDotNetCoreApp.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Designation { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
    }
}
