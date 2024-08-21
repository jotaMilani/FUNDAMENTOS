using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNDAMENTOS
{
    public class Personagem
    {
        //atributos
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public int Nivel { get; set; }
        public int Forca { get; set; }
        public int Agilidade { get; set; }
        public int Inteligencia { get; set; }
        public int Vida { get; set; }

        //metodos
        public virtual void apresentaSe() { }
        public virtual void evoluir()

        {
            this.Nivel += 2;
            this.Forca *= 2;
            this.Inteligencia *= 2;
            this.Agilidade *= 2;
            Console.WriteLine("O jogador " + this.Nome + "evoluiu para o nível " + this.Nivel + ". Seus novos valores são: \nAgilidade:" + "\nInteligência:" + "\nForça:");
        }
        public virtual void batalhar() { }
        public virtual int atacar()
        {
            int pontosAtaque = 0;
            pontosAtaque = (this.Inteligencia + (this.Forca * 2) + this.Agilidade + this.Nivel + this.Vida) / 6;
            return pontosAtaque;
        }
        public virtual int defender()
        {
            int pontosDefesa = 0;
            pontosDefesa = (this.Inteligencia + this.Forca + this.Agilidade + this.Nivel + this.Vida) / 6;
            return pontosDefesa;
        }

        public virtual void batalhar(Personagem p)
        {
            bool vencedor = false;
            while (vencedor == false)
            {
                int valorAtaque = this.atacar();
                int valorDefesaInimigo = p.defender();
                int danoDeVida = valorAtaque - valorDefesaInimigo;
                p.Vida = p.Vida - danoDeVida;
                Console.WriteLine("Dano na Vida do Inimigo em " + danoDeVida);
                Console.WriteLine("O nível de vida do Inimigo agora é  " + p.Vida);

                int valorAtaqueInimigo = p.atacar();
                int valorDefesa = this.defender();
                int danoDeVida2 = valorAtaqueInimigo - valorDefesa;
                if (danoDeVida2 <= 0)
                {
                    danoDeVida2 = 1;
                }
                this.Vida = this.Vida - danoDeVida2;
                Console.WriteLine("Dano na Vida do Atacante em " + danoDeVida2);
                Console.WriteLine("O nível de Vida do Atacante agora é " + p.Vida);

                if (this.Vida <= 0)
                {
                    Console.WriteLine("O personagem " + p.Nome + "Venceu!");
                    vencedor = true;
                    p.evoluir();
                    Console.WriteLine("O personagem " + this.Nome + "Venceu!");
                    vencedor = true;
                    this.evoluir();
                }
            }


        }




    }
}
