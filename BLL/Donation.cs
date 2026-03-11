using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection.BLL
{
    internal class Donation
    {
        public int DonationID { get; set; }
        public decimal PintOfBlood { get; set; }
        public DateTime DateOfDonation { get; set; }
        public Delivery Delivery_DeliveryID { get; set; }
        public Donor Donor_Account_UserName { get; set; }
        public Donor Donor_Person_JMB { get; set; }
    }
}
