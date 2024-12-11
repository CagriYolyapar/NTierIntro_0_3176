using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public class CategoryConfiguration : BaseConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            Property(x => x.CategoryName).HasColumnName("Kategori İsmi");
            ToTable("Kategoriler");
            Property(x => x.Description).HasColumnName("Acıklama");

        }
    }
}
