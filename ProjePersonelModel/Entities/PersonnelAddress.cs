using ProjePersonelCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjePersonelModel.Entities
{
    public class PersonnelAddress:EntityBase,IEntity
    {
        public int AdressID { get; set; }
        public string Address { get; set; }
        public string AddressDescription { get; set; }
        public int PersonnelID { get; set; }
        public virtual Personnel Personnel { get; set; }
    }
}
