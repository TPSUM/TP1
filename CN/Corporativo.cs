using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CN
{
    public class Corporativo:Propietario
    {
        private int cuit;
        private static float interes;

        public Corporativo(int c, float i, string nomb):base(nomb){
            cuit = c;
            interes = i;
        }

        public override Boolean sos(int id)
        {
            if (id == cuit)
                return true;
            else
                return false;	
        }


    }
}
