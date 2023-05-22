using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //Class Machine pärib classi Cars.
    //Pärab kooloni abiga Car classi
    //See tähendab, et Machine Classil on kõik Car classi
    //omadused ja meetodeid
    public class Machine : Car
    {
        public int GetVinCode()
        {
            return vin;
        }
    }
}
