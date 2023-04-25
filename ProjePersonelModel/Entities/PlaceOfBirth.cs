using ProjePersonelCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjePersonelModel.Entities
{
    public class PlaceOfBirth:EntityBase,IEntity
    {
        public int CityID { get; set; }
        public string CityName { get; set; }

        public ICollection<Personnel> Personnels { get; set; }
    }
}
