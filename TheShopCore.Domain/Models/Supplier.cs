using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TheShopCore.Domain.Models
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }
        public List<Article> Articles { get; set; }
    }
}
