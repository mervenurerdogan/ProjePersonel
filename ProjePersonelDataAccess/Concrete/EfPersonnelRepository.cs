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
    public class EfPersonnelRepository : EfEntityFramewrokRepository<Personnel>, IPersonnelRepository
    {
        public List<Personnel> GetAllFull(Expression<Func<Personnel, bool>> filter)
        {
            using var context=new ProjePersonelContext();
            return context.Personnel.Include(p => p.Departman).Include(p => p.Mission).Include(p=>p.PersonnelPhoneNumbers).Include(p=>p.PersonnelAddresses).ToList();
        }

        public List<Personnel> GetByDepartmanID(int departmanID)
        {
            using var context = new ProjePersonelContext();

            return context.Personnel.Where(p=>p.DepartmanID== departmanID).ToList();    
        }

        public List<Personnel> GetByMissionID(int missionID)
        {
            using var context = new ProjePersonelContext();
            return context.Personnel.Where(p=>p.MissionID==missionID).ToList(); 
        }

        public List<Personnel> GetNoIsActivePersonnel()
        {//çalışmayan aktif olmayan personel
            using var context = new ProjePersonelContext();
            return context.Personnel.Where(p=>p.IsActive==false).OrderByDescending(I => I.CreatedDateTime).ToList();
        }
    }
}
