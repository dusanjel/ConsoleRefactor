using System;
using System.Collections.Generic;
using System.Text;
using TheShopCore.Business.ServiceModels;

namespace TheShopCore.Business.Interfaces
{
    public interface IArticleRepositoryService
    {
        void SaveArticle(ArticleServiceModel model);
        List<ArticleServiceModel> GetAll();
        List<ArticleServiceModel> GetById(int Id);
        void OrderAndSellArticle(int id, int maxExpectedPrice, int buyerId);
    }
}
