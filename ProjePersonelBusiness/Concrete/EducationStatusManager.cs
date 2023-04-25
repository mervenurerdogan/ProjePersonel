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
    public class EducationStatusManager : IEducationStatusService
    {
        private readonly IEducationStatusRepository _educationStatusRepository;
        public EducationStatusManager(IEducationStatusRepository educationStatusRepository)
        {
            _educationStatusRepository = educationStatusRepository;
        }
        public void Add(EducationStatus tablo)
        {
            _educationStatusRepository.Add(tablo);
        }

        public void Delete(EducationStatus tablo)
        {
            _educationStatusRepository.Delete(tablo);
        }

        public List<EducationStatus> GetAll()
        {
           return _educationStatusRepository.GetAll();  
        }

        public EducationStatus GetById(int id)
        {
            return _educationStatusRepository.GetById(id);
        }

        public void Update(EducationStatus tablo)
        {
            _educationStatusRepository.Update(tablo);
        }
    }
}
