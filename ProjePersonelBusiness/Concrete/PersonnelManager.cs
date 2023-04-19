using ProjePersonelBusiness.Abstract;
using ProjePersonelDataAccess.Abstract;
using ProjePersonelModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjePersonelBusiness.Concrete
{
    public class PersonnelManager : IPersonnelService
    {
        private readonly IPersonnelRepository _personnelRepository;
        public PersonnelManager(IPersonnelRepository personnelRepository)
        {
            _personnelRepository = personnelRepository;
        }
        public void Add(Personnel tablo)
        {
            _personnelRepository.Add(tablo);
        }

        public void Delete(Personnel tablo)
        {
            _personnelRepository.Delete(tablo);
        }

        public List<Personnel> GetAll()
        {
            return _personnelRepository.GetAll();
        }

        public List<Personnel> GetAllFull()
        {
            return _personnelRepository.GetAllFull();
        }

        public List<Personnel> GetByDepartmanID(int departmanID)
        {
            return _personnelRepository.GetByDepartmanID(departmanID);
        }

        public Personnel GetById(int id)
        {
            return _personnelRepository.GetById(id);
        }

        public List<Personnel> GetByMissionID(int missionID)
        {
           return _personnelRepository.GetByMissionID(missionID);
        }

        public int GetirAktifCalisanPersonel()
        {
           return _personnelRepository.GetirAktifCalisanPersonel();
        }

        public int GetirAyrilmisCalisanPersonel()
        {
            return _personnelRepository.GetirAyrilmisCalisanPersonel();
        }

        public List<Personnel> GetIsActivePersonnel()
        {
            return _personnelRepository.GetIsActivePersonnel();
        }

        public List<Personnel> GetNoIsActivePersonnel()
        {
            return _personnelRepository.GetNoIsActivePersonnel();
        }

        public void PersonelDelete(int id)
        {
             _personnelRepository.PersonelDelete(id);
        }

        public void Update(Personnel tablo)
        {
            _personnelRepository.Update(tablo);
        }
    }
}
