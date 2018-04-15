using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CN
{
    public class Vehiculo
    {
        private int patente;
        private string modelo;


        private List<Suceso> sucesos;
        private Propietario prop;
        public Vehiculo(int pat, string mod, Propietario p) {
            patente = pat;
            modelo = mod;
            prop = p;
            sucesos = new List<Suceso>();
        
        }

        public Boolean sos(int pat)
        {
            if (pat == patente)
                return true;
            else
            {
                return false;
            }
        }
                
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

    }
}
