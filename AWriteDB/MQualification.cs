using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWriteDB
{
    public class MQualification
    {
        public int QualificationID { get; set; }

        public int CurriculumID { get; set; }

        private string qualificationName;

        public string QualificationName
        {
            get { return qualificationName; }
            set { qualificationName = value; }
        }

        private string qualificationCode;

        public string QualificationCode
        {
            get { return qualificationCode; }
            set { qualificationCode = value; }
        }

        private DateTime qualValidFrom;

        public DateTime QualValidFrom
        {
            get { return qualValidFrom; }
            set { qualValidFrom = value; }
        }

        private DateTime qualValidTo;

        public DateTime QualValidTo
        {
            get { return qualValidTo; }
            set { qualValidTo = value; }
        }

        private string qualAccreditCode;

        public string QualAccreditCode
        {
            get { return qualAccreditCode; }
            set { qualAccreditCode = value; }
        }

    }
}
