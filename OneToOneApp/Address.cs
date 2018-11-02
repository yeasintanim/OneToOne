using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOneApp
{
    class Address
    {
        public string District { get; set; }
        public string Thana { get; set; }
        public string HouseNo { get; set; }

        public string GetFullAddress()
        {
            return District + " " + Thana + " " + HouseNo;
        }
    }
}
