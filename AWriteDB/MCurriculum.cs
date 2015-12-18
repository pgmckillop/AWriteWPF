using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWriteDB
{
    public class MCurriculum
    {
        public int CurriculumID { get; set; }

        public int AcademicLevelID { get; set; }

        private string curriculumName;

        public string CurriculumName
        {
            get { return curriculumName; }
            set { curriculumName = value; }
        }   

    }
}
