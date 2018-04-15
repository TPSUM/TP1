using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CN
{
    public class Suceso
    {

        private DateTime fechaSuc;
        private int id;
        private Pago pago;
        private Infraccion infraccion;
        private Vehiculo vehiculo;

        public Suceso(DateTime f, int i, Infraccion inf, Vehiculo v) {

            fechaSuc = f;
            id =i;
            infraccion = inf;
            vehiculo = v;
            pago = null;
        
        }

        public void agregarPago(Pago p) {

            pago = p;
        }

    }
}
