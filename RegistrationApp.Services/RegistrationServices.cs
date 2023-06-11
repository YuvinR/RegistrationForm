using Microsoft.EntityFrameworkCore.Internal;
using RegistrationApp.Core.DataAccess;
using RegistrationApp.Core.Entity;
using RegistrationApp.Core.Services;
using System;

namespace RegistrationApp.Services
{
    public class RegistrationServices : IRegistrationServices
    {
        private readonly IUnitOfWork _unitOfWork;
        public RegistrationServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> GetRegDetails()
        {
            var res =_unitOfWork.Repository<Registration>().GetAll();
            return 1;
        }
    }
}