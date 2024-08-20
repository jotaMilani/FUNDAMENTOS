using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNDAMENTOS
{
    public class carros
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Velocidade { get; set; }

        public void Acelerar()
        {
            this.Velocidade += 5;
            Console.WriteLine("A velocidade atual é " + this.Velocidade + "km/h");
        }
        public void Desacelerar()
        {
            this.Velocidade -= 5;
            Console.WriteLine("A velocidade atual é " + this.Velocidade + "km/h");

        }

        public void Freiar()
        {
            this.Velocidade = 25;
            Console.WriteLine("A velocidade atual é " + this.Velocidade + "km/h, ele capotou");

        }
    }
}
