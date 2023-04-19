using ProjePersonelModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjePersonelBusiness.Abstract
{
    public interface IPersonnelService:IBaseService<Personnel>
    {
        List<Personnel> GetByMissionID(int missionID);
        List<Personnel> GetByDepartmanID(int departmanID);
        List<Personnel> GetNoIsActivePersonnel();
        List<Personnel> GetAllFull();
        void PersonelDelete(int id);
        List<Personnel> GetIsActivePersonnel();

        int GetirAktifCalisanPersonel();
        int GetirAyrilmisCalisanPersonel();

    }
}
