using ProjePersonelBusiness.Abstract;
using ProjePersonelDataAccess.Abstract;
using ProjePersonelModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjePersonelBusiness.Concrete
{
    public class DepartmanManager : IDepartmanService
    {
        private readonly IDepartmanRepsitory _departmanRepsitory;
        public DepartmanManager(IDepartmanRepsitory departmanRepsitory)
        {
            _departmanRepsitory = departmanRepsitory;
            
        }
        public void Add(Departman tablo)
        {
            _departmanRepsitory.Add(tablo);
        }

        public void Delete(Departman tablo)
        {
            _departmanRepsitory.Delete(tablo);  
        }

        public List<Departman> GetAll()
        {
            return _departmanRepsitory.GetAll();
        }

        public Departman GetById(int id)
        {
            return _departmanRepsitory.GetById(id);
        }

        public void Update(Departman tablo)
        {
            _departmanRepsitory.Update(tablo);
        }
    }
}
