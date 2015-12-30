using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AWEF;

namespace AWriteDB
{
    public class DbQualUnit
    {
        public static List<MQualUnit> UnitRange(int[] myUnits)
        {
            // create a list of units based on the IDs of the Qual Units
            awriteEntities context = new awriteEntities();

            List<MQualUnit> result = new List<MQualUnit>();
            return result;
        } 
    }



}
