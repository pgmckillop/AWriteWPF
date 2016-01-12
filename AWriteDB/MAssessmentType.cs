using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWriteDB
{
    public class MAssessmentType
    {
        public int AssessmentTypeId { get; set; }
        private string assessmentTypeName;

        public string AssessmentTypeName
        {
            get { return assessmentTypeName; }
            set { assessmentTypeName = value; }
        }


        public MAssessmentType(int myId, string myName)
        {
            AssessmentTypeId = myId;
            assessmentTypeName = myName;
        }


    }
}
