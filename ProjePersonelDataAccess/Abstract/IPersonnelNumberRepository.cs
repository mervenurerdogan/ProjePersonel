﻿using ProjePersonelModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjePersonelDataAccess.Abstract
{
    public interface IPersonnelNumberRepository:IEntityRepository<PersonelPhoneNumber>
    {
        List<PersonelPhoneNumber> GetFullAll();
        List<PersonelPhoneNumber> GetByPersonelID(int PersonelID);
    }
}
