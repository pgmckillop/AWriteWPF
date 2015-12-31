using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWriteDB
{
    public class MLookupId
    {
        public int Id { get; set; }
        public int LookupId { get; set; }

        // -- Default constructor
        public MLookupId()
        {
        }

        public MLookupId(int x, int y)
        {
            Id = x;
            LookupId = y;
        }

        // -- Constructor without PK
        public MLookupId(int myValue)
        {
            LookupId = myValue;
        }
    }
}
