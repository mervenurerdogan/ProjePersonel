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
    public class EfPersonnelAddressRepository : EfEntityFramewrokRepository<PersonnelAddress>, IPersonnelAddressRepository
    {
        public List<PersonnelAddress> GetByPersonelID(int personnelID)
        {
            using var context = new ProjePersonelContext();
            return context.Addresses.Include(p=>p.Personnel).Where(p=>p.PersonnelID== personnelID).ToList();
        }

        public List<PersonnelAddress> GetFullAll()
        {
            using var context = new ProjePersonelContext();
            return context.Addresses.Include(p => p.Personnel).ToList();
        }
    }
        

        
}

