using Microsoft.EntityFrameworkCore;
using ProjePersonelDataAccess.Abstract;
using ProjePersonelDataAccess.Context;
using ProjePersonelModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjePersonelDataAccess.Concrete
{
    public class EfDepartmanRepository : EfEntityFramewrokRepository<Departman>, IDepartmanRepsitory
    {
        public List<Departman> GetirDepartmanCalisanPersonel(int departmanID)
        {
            using var context = new ProjePersonelContext();
            return context.Departmen.Include(d=>d.Personnels).Where(d=>d.DepartmanID==departmanID).ToList();
        }

        public int GetirToplamDepartmanSayisi()
        {
            using var context = new ProjePersonelContext();
            return context.Departmen.Count(m => m.IsActive == true);
        }
    }
}
