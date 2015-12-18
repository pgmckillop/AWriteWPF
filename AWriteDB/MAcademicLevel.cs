using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWriteDB
{
    public class MAcademicLevel
    {
        public int AcademicLevelID { get; set; }

        private string acdemicLevelName;

        public string AcademicLevelName
        {
            get { return acdemicLevelName; }
            set { acdemicLevelName = value; }
        }

        private string academicLevelShort;

        public string AcademicLevelShort
        {
            get { return academicLevelShort; }
            set { academicLevelShort = value; }
        }

        private int academicLevelSort;

        public int AcademicLevelSort
        {
            get { return academicLevelSort; }
            set { academicLevelSort = value; }
        }


        // Constructor
        public MAcademicLevel(int idAcadLevel,string acadLevelName, string acadLevelShort, int acadLevelSort)
        {
            AcademicLevelID = idAcadLevel;
            AcademicLevelName = acadLevelName;
            AcademicLevelShort = acadLevelShort;
            AcademicLevelSort = acadLevelSort;
        }

    }
}
