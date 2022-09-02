using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoPilha
{
    internal class Pilha
    {
        public Money Topo { get; set; }

        public Pilha()
        {
            this.Topo = null;
        }

        public bool VerificarVazio()
        {
            if(this.Topo == null)
                return true;
            else
                return false;
        }
        public void Inserir(Money dindin)
        {
            if (VerificarVazio())
            {
                Console.WriteLine("Pilha vazia. Inserindo o primeiro");
                this.Topo = dindin;
                Topo.Anterior = null;
            }
            else
            {
                Console.WriteLine("Pilha já iniciada. Inserindo no Topo");
                dindin.Anterior = this.Topo;
                this.Topo = dindin;
            }
        }
        public void Remover()
        {
            if (VerificarVazio())
            {
                Console.WriteLine("Pilha Vazia. Impossivel remover!");
            }
            else
            {
                this.Topo = Topo.Anterior;
                Console.WriteLine("Objeto removido do topo com sucesso!!!");
            }
        }

        public void Imprimir()
        {
            if(VerificarVazio())
                Console.WriteLine("Pilha Vazia!");
            else
            {
                Money auxiliar = this.Topo;
                do
                {
                    Console.WriteLine(auxiliar.ToString());
                    auxiliar = auxiliar.Anterior;
                } while (auxiliar != null);


            }
        }
    }

}
