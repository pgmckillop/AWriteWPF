using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWriteDB
{
    class MCourse
    {
        public int CourseID { get; set; }

        public int PathwayID { get; set; }

        private string courseName;

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

    }
}
