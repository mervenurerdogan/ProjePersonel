using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjePersonelCore.Entities
{
    public abstract class EntityBase
    {

        public virtual DateTime CreatedDateTime { get; set; } = DateTime.Now;
        public virtual bool IsActive { get; set; } = true;
        public virtual bool IsDeleted { get; set; } = false;

    }
}
