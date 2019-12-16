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
        public List<ArticleServiceModel> Get()
        {
            return ArticleService.GetAll();
        }

        [HttpPost]
        public void Post()
        {
            ArticleService.SaveArticle(
                new ArticleServiceModel()
                { 
                    ArticlePrice = 1800,
                    BuyerUserId = 1,
                    Id = 1,
                    IsSold = false,
                    Name_of_article = "Nice article",
                    SoldDate = DateTime.Now
                }
            );
        }
    }
}
