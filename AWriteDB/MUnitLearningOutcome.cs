using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWriteDB
{
    public class MUnitLearningOutcome
    {
        public int UnitLearningOutcomeID { get; set; }

        public int QualificationUnitID { get; set; }

        private string learningOutcomeName;

        public string LearningOutcomeName
        {
            get { return learningOutcomeName; }
            set { learningOutcomeName = value; }
        }

        private int learningOutcomeNumber;

        public int LearningOutcomeNumber
        {
            get { return learningOutcomeNumber; }
            set { learningOutcomeNumber = value; }
        }

    }
}
