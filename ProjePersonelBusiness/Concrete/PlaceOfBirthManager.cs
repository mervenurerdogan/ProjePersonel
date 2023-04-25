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
    public class PlaceOfBirthManager : IPlaceOfBirthService
    {
        private readonly IPlaceOfBirthRepository _placeOfBirthRepository;
        public PlaceOfBirthManager(IPlaceOfBirthRepository placeOfBirthRepository)
        {
            _placeOfBirthRepository = placeOfBirthRepository;
        }

        public void Add(PlaceOfBirth tablo)
        {
            _placeOfBirthRepository.Add(tablo);
        }

        public void Delete(PlaceOfBirth tablo)
        {
            _placeOfBirthRepository.Delete(tablo);
        }

        public List<PlaceOfBirth> GetAll()
        {
            return _placeOfBirthRepository.GetAll();
        }

        public PlaceOfBirth GetById(int id)
        {
            return _placeOfBirthRepository.GetById(id);
        }

        public void Update(PlaceOfBirth tablo)
        {
            _placeOfBirthRepository.Update(tablo);
        }
    }
}
