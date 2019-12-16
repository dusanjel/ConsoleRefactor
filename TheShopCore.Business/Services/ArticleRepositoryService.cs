using System;
using System.Collections.Generic;
using System.Text;
using TheShopCore.Business.Interfaces;
using TheShopCore.Domain.Interfaces;

namespace TheShopCore.Business.Services
{
    public class ArticleRepositoryService : IArticleRepositoryService
    {
        private readonly IUnitOfWork unitOfWork;

        public ArticleRepositoryService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}
