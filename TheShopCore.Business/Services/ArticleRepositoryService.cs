using System;
using System.Collections.Generic;
using System.Text;
using TheShopCore.Business.Interfaces;
using TheShopCore.Business.ServiceModels;
using TheShopCore.Domain.Interfaces;
using TheShopCore.Domain.Models;

namespace TheShopCore.Business.Services
{
    public class ArticleRepositoryService : IArticleRepositoryService
    {
        private readonly IUnitOfWork unitOfWork;

        public ArticleRepositoryService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void SaveArticle(ArticleServiceModel model)
        {
            var article = new Article()
            {
                Id = model.Id,
                ArticlePrice = model.ArticlePrice,
                BuyerUserId = model.BuyerUserId,
                IsSold = model.IsSold,
                Name_of_article = model.Name_of_article,
                SoldDate =model.SoldDate
            };

            unitOfWork.Articles.Add(article);
            unitOfWork.SaveChanges();
        }

        public List<ArticleServiceModel> GetAll()
        {
            var articles = unitOfWork.Articles.GetAll();
            List<ArticleServiceModel> result = new List<ArticleServiceModel>();

            foreach (Article item in articles)
            {
                ArticleServiceModel articleSm = new ArticleServiceModel()
                {
                    ArticlePrice = item.ArticlePrice,
                    BuyerUserId = item.BuyerUserId,
                    Id = item.Id,
                    IsSold = item.IsSold,
                    Name_of_article = item.Name_of_article,
                    SoldDate = item.SoldDate
                };

                result.Add(articleSm);
            }
            return result;
        }
    }
}
