using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01
{
    public class Barbaro : Personagem
    {
       public int Furia { get; set; }

        public Barbaro()
        {
            Furia = 7;
        }
        /*
       public override int atacar()
        {
            return Forca+Furia;
        }

        */
    }
}
