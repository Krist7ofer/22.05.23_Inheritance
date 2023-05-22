using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Car
    {
        //Meetod Machine classis, mis tagastab masina VIN-koodi,
        //milleks on muutuja vin.
        public void SetVinCode(int vinCode)
        {
            vin = vinCode;
        }

        //protected abil on see muutuja nähtav ja kasutatav ainult
        //classi enda ja selle alamklasside piires.
        protected int vin;
    }
}
