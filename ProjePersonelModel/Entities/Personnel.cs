using ProjePersonelCore.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static ProjePersonelCore.ClassEnumtype;

namespace ProjePersonelModel.Entities
{
    public class Personnel:EntityBase,IEntity
    {
        public int PersonnelID { get; set; }
        public string IdentityNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string PlaceOfBirth { get; set; }
        public EducationState EducationStatus { get; set; }
        public DateTime StartWorkDate { get; set; }
        public DateTime FinishWorkDate { get; set; }
        public Gender Gender { get; set; }
        public DriverLicense DriverLicense { get; set; }
        public string SummaryInfoPersonnel { get; set; }
        public string Email { get; set; }

        
        public int MissionID { get; set; }
        public virtual Mission Mission { get; set; }
        public int DepartmanID { get; set; }
        public virtual Departman Departman { get; set; }



        public virtual ICollection<PersonnelAddress> PersonnelAddresses { get; set; }
        public virtual ICollection<PersonelPhoneNumber> PersonnelPhoneNumbers { get; set; }
    }
}
