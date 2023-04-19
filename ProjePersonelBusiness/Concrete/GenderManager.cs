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
    public class GenderManager : IGenderService
    {
        private readonly IGenderRepository _genderRepository;
        public GenderManager(IGenderRepository genderRepository)
        {
            _genderRepository = genderRepository;
        }
        public void Add(Gender tablo)
        {
            _genderRepository.Add(tablo);
        }

        public void Delete(Gender tablo)
        {
            _genderRepository.Delete(tablo);   
        }

        public List<Gender> GetAll()
        {
            return _genderRepository.GetAll();  
        }

        public Gender GetById(int id)
        {
            return _genderRepository.GetById(id);
        }

        public void Update(Gender tablo)
        {
            _genderRepository.Update(tablo);
        }
    }
}
