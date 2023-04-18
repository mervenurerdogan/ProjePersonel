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
    public class PhoneNumberManager : IPersonnelPhoneNumberService
    {
        private readonly IPersonnelNumberRepository _personnelNumberRepository;
        public PhoneNumberManager(IPersonnelNumberRepository personnelNumberRepository)
        {
            _personnelNumberRepository = personnelNumberRepository;
        }
        public void Add(PersonelPhoneNumber tablo)
        {
           _personnelNumberRepository.Add(tablo);   
        }

        public void Delete(PersonelPhoneNumber tablo)
        {
            _personnelNumberRepository .Delete(tablo);
        }

        public List<PersonelPhoneNumber> GetAll()
        {
            return _personnelNumberRepository.GetAll();
        }

        public PersonelPhoneNumber GetById(int id)
        {
            return _personnelNumberRepository.GetById(id);
        }

        public void Update(PersonelPhoneNumber tablo)
        {
            _personnelNumberRepository.Update(tablo);
        }
    }
}
