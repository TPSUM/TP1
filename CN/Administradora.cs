using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CN
{
    public class Administradora
    {
        private List<Infraccion> infracciones;
        private List<Vehiculo> vehiculos;
        private List<Propietario> propietarios;
        private List<Suceso> sucesos;

        public Administradora()
        {
            infracciones = new List<Infraccion>();
            vehiculos = new List<Vehiculo>();
            propietarios = new List<Propietario>();
            sucesos = new List<Suceso>();
        }

        public Vehiculo buscarVehiculo(int patente)
        {
            Vehiculo vehi = null;
            foreach(Vehiculo v in vehiculos)
            {
                if (v.sos(patente))
                    vehi = v;
            }
            return vehi;
        }

        public Propietario buscarPropietario(int id)
        {
            Propietario prop = null;
            foreach (Propietario p in propietarios)
            {
                if (p.sos(id))
                    prop = p;
            }
            return prop;
        }

        public Infraccion buscarInfraccion(int c)
        {
            Infraccion inf = null;
            foreach (Infraccion i in infracciones)
            {
                if (i.sos(c))
                    inf = i;
            }
            return inf;
        }

        //   Agregar

        public void agregarVehiculo(Vehiculo v)
        {
            vehiculos.Add(v);
        }

        public void agregarPropietario(Propietario p)
        {
            propietarios.Add(p);
        }

        public void agregarInfraccion(Infraccion i)
        {
            infracciones.Add(i);
        }

        public void agregarSuceso(Suceso s)
        {
            sucesos.Add(s);
        }


        public int darCodigoDeSuceso()
        {
            return sucesos.Count();
        }
        public List<Infraccion> darInfracciones() {
            return infracciones;
        }
    }
}
