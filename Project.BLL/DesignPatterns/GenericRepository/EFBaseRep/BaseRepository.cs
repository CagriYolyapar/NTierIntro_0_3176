using Project.BLL.DesignPatterns.GenericRepository.IntRep;
using Project.BLL.DesignPatterns.SingletonPattern;
using Project.DAL.ContextClasses;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.EFBaseRep
{
    //Entity Framework icin olusturulmus Repository
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        MyContext _db;

        public BaseRepository()
        {
            _db = DBTool.DbInstance;
        }
        public void Add(T item)
        {
          

            _db.Set<T>().Add(item);
            _db.SaveChanges();
        }

        public void Delete(T item)
        {
            item.Status = ENTITIES.Enums.DataStatus.Deleted;
            item.DeletedDate = DateTime.Now;
            _db.SaveChanges();
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
                _db.SaveChanges();
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
            
        }
    }
}
