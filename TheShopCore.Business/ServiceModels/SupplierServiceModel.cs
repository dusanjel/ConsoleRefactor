using System;
using System.Collections.Generic;
using System.Text;
using TheShopCore.Domain.Models;

namespace TheShopCore.Business.ServiceModels
{
    class SupplierServiceModel
    {
        public int Id { get; set; }
        public List<ArticleServiceModel> Articles { get; set; }
    }
}
