using TheShopCore.Domain.Interfaces;
using TheShopCore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace TheShopCore.Domain.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TheShopCoreContext _context;
        
        public UnitOfWork(TheShopCoreContext context)
        {
            _context = context;  
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
