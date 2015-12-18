using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWriteDB
{
    public class MQualUnit
    {
        public int QualUnitID { get; set; }

        public int QualificationID { get; set; }


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

        private string qualUnitUAN;

        public string QualUnitUAN
        {
            get { return qualUnitUAN; }
            set { qualUnitUAN = value; }
        }

        private int qualUnitGLH;

        public int QualUnitGLH
        {
            get { return qualUnitGLH; }
            set { qualUnitGLH = value; }
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

    }
}
