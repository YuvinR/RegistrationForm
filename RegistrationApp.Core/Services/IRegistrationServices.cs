using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApp.Core.Services
{
    public interface IRegistrationServices
    {
        Task<int> GetRegDetails();
    }
}
