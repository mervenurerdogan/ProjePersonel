using ProjePersonelCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjePersonelModel.Entities
{
    public class PersonelPhoneNumber:EntityBase,IEntity
    {
        public int PersonnelPhoneNumberID { get; set; }
        public string PhoneNumber { get; set; }
        public string NumberDescription { get; set; }
        public int PersonnelID { get; set; }
        public virtual Personnel Personnel { get; set; }
    }
}
