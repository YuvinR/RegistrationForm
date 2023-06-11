using Microsoft.EntityFrameworkCore;
using RegistrationApp.Core.Entity;
using System.Collections.Generic;

namespace RegistrationApp.Core
{
   
        public interface IApplicationDBContext
        {
            DbSet<Registration> Registration { get; set; }
            Task<int> SaveChangesAsync();
        }
}