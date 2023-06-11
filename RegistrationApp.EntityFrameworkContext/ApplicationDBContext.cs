using Microsoft.EntityFrameworkCore;
using RegistrationApp.Core;
using RegistrationApp.Core.Entity;
using System.Collections.Generic;

namespace RegistrationApp.EntityFrameworkContext
{
    public class ApplicationDBContext : DbContext, IApplicationDBContext
    {
        #region Ctor
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
         : base(options)
        {
        }
        #endregion
        #region DbSet
        public DbSet<Registration> Registration { get; set; }
       
        #endregion
        #region Methods
        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }
        #endregion

    }
    
}