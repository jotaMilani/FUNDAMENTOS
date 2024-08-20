using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNDAMENTOS
{
    public class Funcionario : Pessoa
    {
        public string Cargo { get; set; }
        public double Salario { get; set; }


        public void ApresentarSe()
        {
            Console.WriteLine("Olá, meu nome é " + this.Nome + ", tenho " + this.Idade + " anos, sou " + this.Cargo + " e meu salário é de R$ " + this.Salario);
        }
    }
}
