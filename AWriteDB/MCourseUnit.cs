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

        public int IDCourseUnit
        {
            get { return idCourseUnit; }
            set { idCourseUnit = value; }
        }

        //public int CourseUnitID { get; set; }

        public int UnitStatusID { get; set; }

        public int CourseID { get; set; }

        public int QualUnitID { get; set; }

        private string courseUnitTitle;
        private object selectedItem;

        public string CourseUnitTitle
        {
            get { return courseUnitTitle; }
            set { courseUnitTitle = value; }
        }


        public MCourseUnit(int unitID, int statusID, int courseID, int qualID, string unitTitle)
        {
            idCourseUnit = unitID;
            UnitStatusID = statusID;
            CourseID = courseID;
            QualUnitID = qualID;
            courseUnitTitle = unitTitle;
        }

        public MCourseUnit()
        {

        }

        // This ia the constructor that can be used for 
        // data transfer between Assessment and AssessmentTasks pages
        public MCourseUnit(int unitID, string unitTitle)
        {
            idCourseUnit = unitID;
            courseUnitTitle = unitTitle;
        }

        public MCourseUnit(object selectedItem)
        {
            this.selectedItem = selectedItem;
        }
    }
}
