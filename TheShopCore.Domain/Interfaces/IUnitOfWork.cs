using System;
using System.Collections.Generic;
using System.Text;

namespace TheShopCore.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IArticleRepository Articles { get; }
        ISupplierRepository Suppliers { get; }
        int SaveChanges();
    }
}
