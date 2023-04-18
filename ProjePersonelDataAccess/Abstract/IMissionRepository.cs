using ProjePersonelModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjePersonelDataAccess.Abstract
{
    public interface IMissionRepository:IEntityRepository<Mission>
    {

        List<Mission> GetByDepartmanID(int departmanID);
     
        List<Mission> GetIsActiveAndNonDeletedMissionList();

        List<Mission> GetAllFull();
        
    }
}
