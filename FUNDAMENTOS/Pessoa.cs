﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNDAMENTOS
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Envelhecer(int anos)
        {
            this.Idade += anos;
            Console.WriteLine("A idade atual " + this.Idade + "Anos");
        }




    }
}
