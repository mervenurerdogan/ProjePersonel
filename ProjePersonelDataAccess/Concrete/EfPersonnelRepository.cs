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
        public List<Personnel> GetAllFull()
        {
            using var context = new ProjePersonelContext();

            return context.Personnel.Include(p => p.Mission).Include(p => p.Departman).Include(p=>p.Gender).Include(p => p.PersonnelPhoneNumbers).Include(p=>p.PersonnelAddresses).ToList();
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

        public int GetirAktifCalisanPersonel()
        {
            using var context = new ProjePersonelContext();
            return context.Personnel.Count(p => p.IsActive == true);
        }

        public int GetirAyrilmisCalisanPersonel()
        {
            using var context = new ProjePersonelContext();
            return context.Personnel.Count(p => p.IsActive == false);
        }

        public List<Personnel> GetIsActivePersonnel()
        {
            using var context = new ProjePersonelContext();
            return context.Personnel.Include(p => p.Gender).Include(p => p.Departman).Include(p => p.Mission).Where(p => p.IsActive == true).OrderByDescending(I => I.CreatedDateTime).ToList();
        }

        public List<Personnel> GetNoIsActivePersonnel()
        {//çalışmayan aktif olmayan personel
            using var context = new ProjePersonelContext();
            return context.Personnel.Include(p=>p.Gender).Include(p=>p.Departman).Include(p=>p.Mission).Where(p=>p.IsActive==false).OrderByDescending(I => I.CreatedDateTime).ToList();
        }

        public void PersonelDelete(int id)
        {
            using var context = new ProjePersonelContext();
            
           var deger = context.Personnel.Update(new Personnel
            {
                PersonnelID= id,
                IsActive = false,
            });
            context.SaveChanges();
            

        }
    }
}
