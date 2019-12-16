using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TheShopCore.Domain.Models
{
    public class TheShopCoreContext : DbContext
    {
        public TheShopCoreContext(DbContextOptions<TheShopCoreContext> options)
            : base(options)
        { }
    }
}
