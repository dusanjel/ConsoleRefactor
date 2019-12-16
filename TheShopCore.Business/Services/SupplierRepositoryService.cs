using System;
using System.Collections.Generic;
using System.Text;
using TheShopCore.Business.Interfaces;
using TheShopCore.Domain.Interfaces;

namespace TheShopCore.Business.Services
{
    public class SupplierRepositoryService : ISupplierRepositoryService
    {
        private readonly IUnitOfWork unitOfWork;

        public SupplierRepositoryService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}
