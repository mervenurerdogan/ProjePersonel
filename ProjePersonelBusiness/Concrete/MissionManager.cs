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
    public class MissionManager : IMissionService
    {
        private readonly IMissionRepository _missionRepository;
        public MissionManager(IMissionRepository missionRepository)
        {
            _missionRepository = missionRepository;
        }
        public void Add(Mission tablo)
        {
           _missionRepository.Add(tablo);
        }

        public void Delete(Mission tablo)
        {
            _missionRepository.Delete(tablo);
        }

        public List<Mission> GetAll()
        {
            return _missionRepository.GetAll();
        }

        public List<Mission> GetAllFull()
        {
            return _missionRepository.GetAllFull();
        }

        public List<Mission> GetByDepartmanID(int departmanID)
        {
            return _missionRepository.GetByDepartmanID((int)departmanID);
        }

        public Mission GetById(int id)
        {
            return _missionRepository.GetById(id);  
        }

      

        public List<Mission> GetIsActiveAndNonDeletedMissionList()
        {
            return _missionRepository.GetIsActiveAndNonDeletedMissionList();
        }

        public void Update(Mission tablo)
        {
            _missionRepository.Update(tablo);   
        }
    }
}
