using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CN
{
    public class Particular:Propietario
    {

        private int dni;
        private static float interes;

        public Particular(int d, float i, string nomb):base(nomb){
            dni = d;
            interes = i;
        }

        public override Boolean sos(int id)
        {
            if (id == dni)
                return true;
            else
                return false;	
        }
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

    }
}
