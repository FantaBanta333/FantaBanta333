using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Truck : Car //deriving from Car
    {
        public int TowingCapacity { get; set; }
        public int BedSize { get; set; }

        public Truck(int towing, int bedSize, int year, string make, string model, int odometer = 0) : base(year, make, model, odometer)
        {
            TowingCapacity = towing;
            BedSize = bedSize;
        }
    }
}
