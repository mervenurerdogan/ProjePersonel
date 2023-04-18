using ProjePersonelModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjePersonelBusiness.Abstract
{
    public interface IMissionService:IBaseService<Mission>
    {
        List<Mission> GetByDepartmanID(int departmanID);
        List<Mission> GetAllFull(Expression<Func<Mission, bool>> filter);
        List<Mission> GetIsActiveAndNonDeletedMissionList();
    }
}
