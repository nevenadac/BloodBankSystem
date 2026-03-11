using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection.BLL
{
    class Delivery
    {
        public int DeliveryID { get; set; }
        public DateTime DateOfDelivery { get; set; }
        public Hospital Hospital_HospitalID { get; set; }
    }
}
