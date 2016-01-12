using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWriteDB
{
    public class MSystemUserType
    {
        public int SystemUserTypeId { get; set; }

        private string systemUserTypeName;

        public string SystemUserTypeName
        {
            get { return systemUserTypeName; }
            set { systemUserTypeName = value; }
        }

    }
}
