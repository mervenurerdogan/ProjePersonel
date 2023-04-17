using ProjePersonelCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjePersonelModel.Entities
{
    public class Departman:EntityBase,IEntity
    {
        public  int DepartmanID { get; set; }
        public string DepartmanName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Personnel> Personnels { get; set; }

    }
}
