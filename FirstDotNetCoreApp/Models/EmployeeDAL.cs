using Microsoft.Data.SqlClient;
using System.Data;

namespace FirstDotNetCoreApp.Models
{
    public class EmployeeDAL
    {
        public string conStr = MyConnectionString.ConnectionString;

        public EmployeeDAL() { }
        public List<Employee> GetAllEmployees()
        {

            List<Employee> employees = new List<Employee>();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("spGetAllEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Employee emp = new Employee();
                while (dr.Read())
                {
                    emp.Id =Convert.ToInt32(dr["Id"]);
                    emp.Name =dr["Name"].ToString() ?? "";
                    emp.Gender = dr["Gender"].ToString() ?? "";
                    emp.Age = Convert.ToInt32(dr["Age"]);
                    emp.Designation = dr["Designation"].ToString() ?? "";
                    emp.City = dr["City"].ToString() ?? "";
                    employees.Add(emp);
                }
            }
            return employees;
        }
    }
}
