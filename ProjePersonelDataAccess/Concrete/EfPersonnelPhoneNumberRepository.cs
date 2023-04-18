using ProjePersonelDataAccess.Abstract;
using ProjePersonelModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjePersonelDataAccess.Concrete
{
    public class EfPersonnelPhoneNumberRepository:EfEntityFramewrokRepository<PersonelPhoneNumber>,IPersonnelNumberRepository
    {
    }
}
