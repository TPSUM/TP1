using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CN
{
    public abstract class Infraccion
    {
        protected int codigo;
        protected String desc;
        protected float importe;

        public Infraccion(int c, String d,float i)
        {
            codigo = c;
            desc = d;
            importe = i;        
        }

        public Boolean sos(int c)
        {
            if (c == codigo)
                return true;
            else
                return false;
        }

        public int dameCodigo() {
            return codigo;
        }
        public String dameDesc() {
            return desc;
        }
        public float dameImporte() {

            return importe;

        }
        public abstract String dameTipo();
    }
}
