using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01
{
    public class Personagem
    {
        public int Forca { get; set; }
         
        public Personagem()
        {
            Forca = 15;
        }

        public virtual int atacar()
        {
            return Forca;
        }

        public int atacar(int multiplier)
        {
            return Forca * multiplier;
        }
    }
}
