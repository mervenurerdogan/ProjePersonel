using Microsoft.EntityFrameworkCore;
using ProjePersonelDataAccess.Abstract;
using ProjePersonelDataAccess.Context;
using ProjePersonelModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjePersonelDataAccess.Concrete
{
    public class EfMissionRepository : EfEntityFramewrokRepository<Mission>, IMissionRepository
    {
        public List<Mission> GetAllFull(Expression<Func<Mission, bool>> filter)
        {
            using var context=new ProjePersonelContext();
            return context.Missions.Include(I=>I.Departman).Where(filter).OrderByDescending(I=>I.CreatedDateTime).ToList();
        }

        public List<Mission> GetByDepartmanID(int departmanID)
        {
            using var context=new ProjePersonelContext();
            return context.Missions.Where(I=>I.DepartmanID==departmanID).ToList();
        }

        public List<Mission> GetIsActiveAndNonDeletedMissionList()
        {
            using var context=new ProjePersonelContext();
            return context.Missions.Where(m => m.IsActive == true && m.IsDeleted == false).ToList();
        }
    }
}
