using ProjePersonelModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjePersonelDataAccess.Abstract
{
    public interface IPersonnelAddressRepository:IEntityRepository<PersonnelAddress>
    {
        List<PersonnelAddress> GetFullAll();
        List<PersonnelAddress> GetByPersonelID(int personnelID);
    }
}
