using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRegistrationStation
{
    internal class Vehicle
    {
        public string RegNum { get; set; }

        public bool Tag { get; set; }

        public override string ToString()
        {
            return "Rego#: " + RegNum + "   Tagged: " + Tag;
        }
        public Vehicle(string RegNum)
        {
            this.RegNum = RegNum;
            Tag = false;
        }
    }
}
