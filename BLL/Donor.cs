using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection.BLL
{
    internal class Donor
    {
        public Account Account_UserName { get; set; }
        public Person Person_JMB { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
    }
}
