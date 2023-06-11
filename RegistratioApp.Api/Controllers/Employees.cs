using System.ComponentModel.DataAnnotations;

namespace RegistratioApp.Api.Controllers
{
    public class Employees
    {
        [Key]
        public int EmployeeId
        {
            get;
            set;
        }
        public string EmployeeFirstName
        {
            get;
            set;
        }
        public string EmployeeLastName
        {
            get;
            set;
        }
        public decimal Salary
        {
            get;
            set;
        }
        public string Designation
        {
            get;
            set;
        }
    }
}
