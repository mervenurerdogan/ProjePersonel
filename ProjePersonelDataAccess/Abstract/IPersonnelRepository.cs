using ProjePersonelModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjePersonelDataAccess.Abstract
{
    public interface IPersonnelRepository:IEntityRepository<Personnel>
    {
        List<Personnel> GetByMissionID(int missionID);
        List<Personnel> GetByDepartmanID(int departmanID);
        List<Personnel> GetNoIsActivePersonnel();
        List<Personnel> GetIsActivePersonnel();
        List<Personnel> GetAllFull();
        void PersonelDelete(int id);

        int GetirAktifCalisanPersonel();
        int GetirAyrilmisCalisanPersonel();




    }
}
