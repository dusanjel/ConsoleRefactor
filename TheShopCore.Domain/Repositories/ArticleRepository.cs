using System;
using System.Collections.Generic;
using System.Text;
using TheShopCore.Domain.Interfaces;
using TheShopCore.Domain.Models;

namespace TheShopCore.Domain.Repositories
{
    public class ArticleRepository : GenericRepository<Article>, IArticleRepository
    {
        public ArticleRepository(TheShopCoreContext context) : base(context)
        {
        }

        public TheShopCoreContext ApplicationDbContext
        {
            get { return Context as TheShopCoreContext; }
        }
    }
}
