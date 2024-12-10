using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public class ProfileConfiguration : BaseConfiguration<AppUserProfile>
    {
        public ProfileConfiguration()
        {
            ToTable("Kullanıcı Profilleri");
            Property(x => x.FirstName).HasColumnName("Isim");
            Property(x => x.LastName).HasColumnName("SoyIsim");
        }
    }
}
