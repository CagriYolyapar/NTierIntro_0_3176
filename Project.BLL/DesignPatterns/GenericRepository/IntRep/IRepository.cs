using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.IntRep
{
    public interface IRepository<T> where T: BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T item);

        /// <summary>
        /// Bu metot veriyi pasife cekmek icin vardır
        /// </summary>
        /// <param name="item"></param>
        void Delete(T item);
        void Update(T item);

        /// <summary>
        /// Bu metot veriyi yok eder
        /// </summary>
        /// <param name="item"></param>
        string Destroy(T item);

        List<T> Where(Expression<Func<T,bool>> exp);
        bool Any(Expression<Func<T, bool>> exp);

        List<T> GetActives();
        List<T> GetPassives();
        List<T> GetModifieds();
    }
}
