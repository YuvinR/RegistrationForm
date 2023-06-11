using Microsoft.EntityFrameworkCore;

namespace RegistratioApp.Api.Controllers
{
    public class EmpContext : DbContext
    {
        public EmpContext(DbContextOptions options) : base(options) { }
        DbSet<Employees> Employees
        {
            get;
            set;
        }
    }
}
