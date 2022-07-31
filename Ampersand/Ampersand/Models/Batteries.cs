using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ampersand.Models
{
    public class Batteries
    {
        public string batteryNumber { get; set; }
        public string batteryName { get; set; }
        public string batteryDetails { get; set; }

        public string fullBatteryInfo
        {
            get
            {
                //return (001) batteryname batteryDetails
                return $"({ batteryNumber }) { batteryName } { batteryDetails }";
            }
            
        }

    }
}
