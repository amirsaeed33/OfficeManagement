using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSytstem.Database
{
    class Common
    {
        public long Id { get; set; }
        public string Note { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? DeletetionDate { get; set; }
    }
}
