using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection.BLL
{
    internal class Test
    {
        public int TestID { get; set; }
        public string TestResult { get; set; }
        public DateTime DateOfTest { get; set; }
        public Donation DonationID { get; set; }
        public TypeOfTest TypeOfTestID { get; set; }
        public Employee Employee_Account_UserName { get; set; }
        public Employee Employee_Person_JMB { get; set; }
    }
}
