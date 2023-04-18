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
    public class PersonnelAddressManager : IPersonnelAddressService
    {
        private readonly IPersonnelAddressRepository _personnelAddressRepository;
        public PersonnelAddressManager(IPersonnelAddressRepository personnelAddressRepository)
        {
            _personnelAddressRepository=personnelAddressRepository;
        }
        public void Add(PersonnelAddress tablo)
        {
            _personnelAddressRepository.Add(tablo);
        }

        public void Delete(PersonnelAddress tablo)
        {
            _personnelAddressRepository.Delete(tablo);
        }

        public List<PersonnelAddress> GetAll()
        {
            return _personnelAddressRepository .GetAll();
        }

        public PersonnelAddress GetById(int id)
        {
          return _personnelAddressRepository.GetById(id);
        }

        public void Update(PersonnelAddress tablo)
        {
             _personnelAddressRepository.Update(tablo);
        }
    }
}
