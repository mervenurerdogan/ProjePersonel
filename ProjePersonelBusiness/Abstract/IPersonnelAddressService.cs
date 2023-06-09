﻿using ProjePersonelModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjePersonelBusiness.Abstract
{
    public interface IPersonnelAddressService:IBaseService<PersonnelAddress>
    {
        List<PersonnelAddress> GetFullAll();
        List<PersonnelAddress> GetByPersonelID(int personnelID);
    }
}
