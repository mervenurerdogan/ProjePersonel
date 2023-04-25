using ProjePersonelCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjePersonelModel.Entities
{
    public class EducationStatus : EntityBase, IEntity
    {
        public int EducationID { get; set; }
        public string EducationStatusName { get; set; }

        public virtual ICollection<Personnel> Personnels { get; set; }
    }
}
