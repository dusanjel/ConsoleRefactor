using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TheShopCore.Business.Interfaces;
using TheShopCore.Business.ServiceModels;
using TheShopCore.Domain.Interfaces;

namespace TheShopCore.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TheShopCoreController : ControllerBase
    {
        private readonly ILogger<TheShopCoreController> _logger;
        private readonly IArticleRepositoryService ArticleService;
        private readonly ISupplierRepositoryService SupplierService;

        public TheShopCoreController(ILogger<TheShopCoreController> logger, IArticleRepositoryService _articleService, ISupplierRepositoryService _supplierService)
        {
            _logger = logger;
            ArticleService = _articleService;
            SupplierService = _supplierService;
        }

        [HttpGet]
        public List<ArticleServiceModel> GetById(int Id)
        {
            return ArticleService.GetById(Id);
        }

        [HttpPost]
        public void OrderAndSellArticle(int id, int maxExpectedPrice, int buyerId)
        {
            ArticleService.OrderAndSellArticle(id, maxExpectedPrice, buyerId);
        }

        [Route("[action]")]
        [HttpPost]
        public void SaveArticle()
        {
            ArticleService.SaveArticle(
                new ArticleServiceModel()
                { 
                    ArticlePrice = 458,
                    BuyerUserId = 1,
                    Id = 1,
                    IsSold = false,
                    Name_of_article = "Article from supplier1",
                    SoldDate = DateTime.Now
                }
            );

            ArticleService.SaveArticle(
               new ArticleServiceModel()
               {
                   ArticlePrice = 459,
                   BuyerUserId = 1,
                   Id = 2,
                   IsSold = false,
                   Name_of_article = "Article from supplier2",
                   SoldDate = DateTime.Now
               }
           );


           ArticleService.SaveArticle(
               new ArticleServiceModel()
               {
                   ArticlePrice = 460,
                   BuyerUserId = 1,
                   Id = 3,
                   IsSold = false,
                   Name_of_article = "Article from supplier3",
                   SoldDate = DateTime.Now
               }
           );
        }
    }
}
