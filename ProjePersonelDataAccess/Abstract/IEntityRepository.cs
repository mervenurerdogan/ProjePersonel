using ProjePersonelCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjePersonelDataAccess.Abstract
{
    public interface IEntityRepository<Tablo> where Tablo : class,IEntity,new()
    {
        void Add(Tablo tablo);
        void Update(Tablo tablo);
        void Delete(Tablo tablo);
        Tablo GetById(int id);
        List<Tablo> GetAll();

    }
}
