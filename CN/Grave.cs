using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CN
{
    public class Grave:Infraccion
    {
        private static float descPor25;
        public Grave(float d25, int c, string d, float i) : base(c, d, i) 
        {
            descPor25 = d25;
        }
        public override string ToString()
        {
            return "Codigo: " + codigo + " Descripcion: " + desc + " Importe: " + importe +

                " %DescPor25: " + descPor25;
        }
        public override string dameTipo()
        {
            return "Grave";
        }

    }
}
