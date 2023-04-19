using ProjePersonelCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjePersonelModel.Entities
{
    public class Gender:EntityBase,IEntity
    {
        public int GenderID { get; set; }
        public string GenderName { get; set; }

        public virtual ICollection<Personnel> Personnels { get; set; }

    }
}
