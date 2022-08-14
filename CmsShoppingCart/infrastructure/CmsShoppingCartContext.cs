using Microsoft.EntityFrameworkCore;
using CmsShoppingCart.Models;

namespace CmsShoppingCart.infrastructure
{
    public class CmsShoppingCartContext :DbContext 
    {
        public CmsShoppingCartContext(DbContextOptions<CmsShoppingCartContext> options)
            :base(options)
        {
             
        }
        public DbSet<Page> Pages
        { get; set; }

    }
}
