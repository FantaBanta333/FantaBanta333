using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public interface IVehicle
    {
        int Year { get; }
        string Make { get; }
        string Model { get; }

        string Info();
    }
}
