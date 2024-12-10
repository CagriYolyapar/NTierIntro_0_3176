using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public class OrderConfiguration:BaseConfiguration<Order>
    {
        public OrderConfiguration()
        {
            ToTable("Siparisler");
            Property(x => x.ShippingAddress).HasColumnName("Gonderim Adresi");
          
        }
    }
}
