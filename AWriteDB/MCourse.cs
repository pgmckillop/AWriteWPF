using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWriteDB
{
    class MCourse
    {
        public int CourseId { get; set; }

        public int PathwayId { get; set; }

        private string courseName;

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

    }
}
