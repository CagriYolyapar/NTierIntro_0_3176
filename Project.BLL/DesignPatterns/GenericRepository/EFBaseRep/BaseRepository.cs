using Project.BLL.DesignPatterns.GenericRepository.IntRep;
using Project.BLL.DesignPatterns.SingletonPattern;
using Project.DAL.ContextClasses;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.EFBaseRep
{
    //Entity Framework icin olusturulmus Repository
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
       MyContext _db;

        public BaseRepository()
        {
            _db = DBTool.DbInstance;

            
        }
        public  void Add(T item)
        {


            _db.Set<T>().Add(item);
            Save();
        }

        void Save()
        {
            _db.SaveChanges();
        }

        public void Delete(T item)
        {
            item.Status = ENTITIES.Enums.DataStatus.Deleted;
            item.DeletedDate = DateTime.Now;
            Save();
        }

        public string Destroy(T item)
        {
            if(item.Status != ENTITIES.Enums.DataStatus.Deleted)
            {
                return "Lütfen önce silmek istediginiz veriyi pasif hale getiriniz";
            }
            else
            {
                _db.Set<T>().Remove(item);
                Save();
                return "Veri silinmiştir";
            }
        }

        public List<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public void Update(T item)
        {
            T originalEntity = GetById(item.Id);
            item.ModifiedDate = DateTime.Now;
            item.Status = ENTITIES.Enums.DataStatus.Updated;


            //_db.Entry'deki Entry metodu Veritabanında direkt bir modifikasyon icin giriş bildirir...Neye göre giriş yapacagını söylemek icin direkt bir Entity'den bahsetmemiz gerekir...
            _db.Entry(originalEntity).CurrentValues.SetValues(item);
            Save();
        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
           return _db.Set<T>().Where(exp).ToList();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Any(exp);
        }

        public List<T> GetActives()
        {
            return Where(x => x.Status != ENTITIES.Enums.DataStatus.Deleted);
        }

        public List<T> GetPassives()
        {
            return Where(x => x.Status == ENTITIES.Enums.DataStatus.Deleted);

        }

        public List<T> GetModifieds()
        {
            return Where(x => x.Status == ENTITIES.Enums.DataStatus.Updated);

        }
    }
}
