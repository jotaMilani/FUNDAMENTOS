﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNDAMENTOS
{
    public class Elfo : Personagem
    {
        public override void apresentaSe()
        {
            Console.WriteLine("Olá, meu nome é " + this.Nome + ", tenho " + this.Vida + " de vida, sou da categoria mago e tenho  " + this.Forca + " de força.");

        }
        public override void batatalhar()
        {

        }
        public override void evoluir()
        {

        }
    }
}
