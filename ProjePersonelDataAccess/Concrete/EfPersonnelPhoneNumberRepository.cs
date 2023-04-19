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
    public class EfPersonnelPhoneNumberRepository : EfEntityFramewrokRepository<PersonelPhoneNumber>, IPersonnelNumberRepository
    {
        public List<PersonelPhoneNumber> GetFullAll()
        {
            using var context =new  ProjePersonelContext();
            return context.PersonelPhoneNumbers.Include(p => p.Personnel).ToList();
        }
    }
}
