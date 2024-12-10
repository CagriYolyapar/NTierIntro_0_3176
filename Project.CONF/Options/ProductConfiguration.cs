using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public class ProductConfiguration: BaseConfiguration<Product>
    {
        public ProductConfiguration()
        {
            ToTable("Ürünler");
            Property(x => x.ProductName).HasColumnName("Ürün ismi");
            Property(x => x.UnitPrice).HasColumnType("money").HasColumnName("Fiyat");
            
        }
    }
}
