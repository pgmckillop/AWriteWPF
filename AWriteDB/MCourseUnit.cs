using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWriteDB
{
    public class MCourseUnit
    {

        private int idCourseUnit;

        public int IdCourseUnit
        {
            get { return idCourseUnit; }
            set { idCourseUnit = value; }
        }

        //public int CourseUnitID { get; set; }

        public int UnitStatusId { get; set; }

        public int CourseId { get; set; }

        public int QualUnitId { get; set; }

        private string courseUnitTitle;
        private object selectedItem;

        public string CourseUnitTitle
        {
            get { return courseUnitTitle; }
            set { courseUnitTitle = value; }
        }


        public MCourseUnit(int unitId, int statusId, int courseId, int qualId, string unitTitle)
        {
            idCourseUnit = unitId;
            UnitStatusId = statusId;
            CourseId = courseId;
            QualUnitId = qualId;
            courseUnitTitle = unitTitle;
        }

        public MCourseUnit()
        {

        }

        // This ia the constructor that can be used for 
        // data transfer between Assessment and AssessmentTasks pages
        public MCourseUnit(int unitId, string unitTitle)
        {
            idCourseUnit = unitId;
            courseUnitTitle = unitTitle;
        }

        public MCourseUnit(object selectedItem)
        {
            this.selectedItem = selectedItem;
        }
    }
}
