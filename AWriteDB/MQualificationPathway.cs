using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWriteDB
{
    public class MQualificationPathway
    {
        public int QualificationPathwayId { get; set; }

        public int QualificationId { get; set; }

        private string qualPathwayName;

        public string QualPathwayName
        {
            get { return qualPathwayName; }
            set { qualPathwayName = value; }
        }

    }
}
