using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CN
{
    public abstract class Propietario
    {
        private string nombre;
        private List<Vehiculo> vehiculos;

        public Propietario(string n) {

            nombre = n;
            vehiculos = new List<Vehiculo>();

        }
        public void agregarVehiculo(Vehiculo v){

            this.vehiculos.Add(v);
        }

        public abstract Boolean sos(int id);

    }
}
