using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{

    //Generic sınıflar iclerindeki tanımlanmıs olan görevleri tetiklendikleri yerde hangi tipe göre yapacaklarını bildirdigimiz sınıflardır...

    //Generic sınıflardaki where kısıtlaması generic sınıf bir yerden cagrıldıgı zaman (instance veya miras verme durumunda) alacagı argüman tipinin nasıl olacagını belirler... Bu bize bir güvenlik saglar(cagrıldıgı yerdeki tip uyumlulugu sayesinde istemedigimiz bir tip oraya verilemez) hem de Generic argümanın aldıgı tip kısıtlamasına göre o tipin özelliklerini getirir...
    public abstract class BaseConfiguration<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {
        public BaseConfiguration()
        {
            Property(x => x.CreatedDate).HasColumnName("Yaratılma tarihi");
            Property(x => x.DeletedDate).HasColumnName("Silme tarihi");
            Property(x => x.ModifiedDate).HasColumnName("Güncelleme tarihi");
            Property(x => x.Status).HasColumnName("Veri Durumu");

        }
    }
}
