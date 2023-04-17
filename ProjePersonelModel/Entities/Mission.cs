using ProjePersonelCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjePersonelModel.Entities
{
    public class Mission:EntityBase,IEntity
    {
        public int MissionID { get; set; }
        public string MissionName { get; set; }
        public string Description { get; set; }
        //Foreign Key
        public int DepartmanID { get; set; }
        public virtual Departman Departman { get; set; }
        public virtual ICollection<Personnel> Personnels { get; set; }
    }
}
