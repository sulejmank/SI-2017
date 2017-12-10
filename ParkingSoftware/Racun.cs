using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSoftware
{
   public class Racun
    {
        public DateTime VremeProvedeno { get; set; }
        public LoginClass Radnik { get; set; }
        public Parking Parking { get; set; }
    }
}
