using ProjePersonelDataAccess.Abstract;
using ProjePersonelCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjePersonelDataAccess.Context;

namespace ProjePersonelDataAccess.Concrete
{
    public class EfEntityFramewrokRepository<Tablo> : IEntityRepository<Tablo>where Tablo:class,IEntity,new()
    {
        public void Add(Tablo tablo)
        {
            using var context = new ProjePersonelContext();
            context.Set<Tablo>().Add(tablo);
            context.SaveChanges();
  
        }

        public void Delete(Tablo tablo)
        {
            using var context = new ProjePersonelContext();
            context.Set<Tablo>().Remove(tablo);
            context.SaveChanges();
        }

        public List<Tablo> GetAll()
        {
            using var context = new ProjePersonelContext();
            return context.Set<Tablo>().ToList();

        }

        public Tablo GetById(int id)
        {
            using var context = new ProjePersonelContext();
            return context.Set<Tablo>().Find(id);

        }

        public void Update(Tablo tablo)
        {
            using var context = new ProjePersonelContext();
            context.Set<Tablo>().Update(tablo);
            context.SaveChanges();
        }
    }
}
