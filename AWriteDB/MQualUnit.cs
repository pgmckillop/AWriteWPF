using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWriteDB
{
    public class MQualUnit
    {
        public int QualUnitId { get; set; }

        public int QualificationId { get; set; }


        private string qualUnitTitle;

        public string QualUnitTitle
        {
            get { return qualUnitTitle; }
            set { qualUnitTitle = value; }
        }

        private int qualUnitNumber;

        public int QualUnitNumber
        {
            get { return qualUnitNumber; }
            set { qualUnitNumber = value; }
        }

        private string qualUnitUan;

        public string QualUnitUan
        {
            get { return qualUnitUan; }
            set { qualUnitUan = value; }
        }

        private int qualUnitGlh;

        public int QualUnitGlh
        {
            get { return qualUnitGlh; }
            set { qualUnitGlh = value; }
        }

        public string NumberAndTitle()
        {
            string unitNumberToString;

            if (qualUnitNumber < 100)
            {
                if (qualUnitNumber <10)
                {
                    unitNumberToString = "00" + qualUnitNumber.ToString();
                }
                else
                {
                    unitNumberToString = "0" + qualUnitNumber.ToString();
                }
            }
            else
            {
                unitNumberToString = qualUnitNumber.ToString();
            }


            return unitNumberToString + ": " + qualUnitTitle;

        }

     public List<MUnitLearningOutcome> LearningOutcomes { get; set; } 

    }
}
