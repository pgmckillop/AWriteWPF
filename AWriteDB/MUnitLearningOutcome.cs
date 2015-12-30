using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AWriteDB.LTSC;

namespace AWriteDB
{
    public class MUnitLearningOutcome
    {
        public int UnitLearningOutcomeId { get; set; }

        public int QualificationUnitId { get; set; }

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

        private string loShort;

        public string LoShort
        {
            get { return loShort; }
            set { loShort = value; }
        }

        public int IdQualUnit { get; set; }

        public string LoDisplay()
        {
            return learningOutcomeNumber.ToString() + ": " + loShort;
        }

        public List<LOTopic> Topics { get; set; }
    }
}
