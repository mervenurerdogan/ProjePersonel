using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjePersonelCore
{
    public class ClassEnumtype
    {
        public enum Gender
        {
            Male=1,
            Female=2
        }

        public enum DriverLicense
        {
            A1 = 1,
            A2 = 2,
            B = 3,
            C = 4
        }
        public enum EducationState
        {
            HighSchool = 1,
            AssociateDegree = 2,
            BachelorDegree = 3,
            MasterDegree = 4
        }

        public enum ResultStatus
        {
            Success = 0,
            Error = 1,//ResultStatus.Error
            Warning = 2,
            Info = 3
        }
    }
}
