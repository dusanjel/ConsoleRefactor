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
            Articles = new ArticleRepository(_context);
            Suppliers = new SupplierRepository(_context);
        }

        public IArticleRepository Articles { get; private set; }
        public ISupplierRepository Suppliers { get; private set; }

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
