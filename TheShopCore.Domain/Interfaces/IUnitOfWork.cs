using System;
using System.Collections.Generic;
using System.Text;

namespace TheShopCore.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();
    }
}
