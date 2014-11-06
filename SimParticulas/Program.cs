using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Gravity_Simulation
{
    static class Program
    {

        static void Main()
        {

            Gravity_Simulation.Quadra quadra = new Quadra();
            Application.Run(quadra);


        }
    }
}
