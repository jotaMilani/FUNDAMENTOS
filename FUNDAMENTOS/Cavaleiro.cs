using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNDAMENTOS
{
    public class Cavaleiro : Personagem
    {
        public override void apresentaSe()
        {
            Console.WriteLine("Olá, meu nome é " + this.Nome + ", tenho " + this.Vida + " de vida, sou da categoria mago e tenho  " + this.Forca + " de força.");


        }
        public virtual void batalhar()
        {
        }
        public virtual void evoluir()
        {

        }
    }
}
