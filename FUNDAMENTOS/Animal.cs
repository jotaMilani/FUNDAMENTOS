using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNDAMENTOS
{
    public abstract class Animal
    {
        public string Especie { get; set; }
        public string Nome { get; set; }

        public abstract void emitirSom();


    }
}
