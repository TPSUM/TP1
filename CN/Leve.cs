using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CN
{
    public class Leve:Infraccion
    {
        private static float descPor20;
        private static float descPor10;
        public Leve(float d20, float d10, int c, string d, float i) : base(c, d, i) 
        {
            descPor20 = d20;
            descPor10 = d10;
        }

        public override string ToString()
        {
            return "Codigo: " + codigo + " Descripcion: " + desc + " Importe: " + importe + " %Desc20Dias: " +descPor20 +
                
                " %DescPor10: " + descPor10;
        }
        public override string dameTipo() {
            return "Leve";
        }
    }
}
