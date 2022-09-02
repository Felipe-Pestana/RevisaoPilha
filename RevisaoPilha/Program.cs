using System;

namespace RevisaoPilha
{
    internal class Program
    {
        //Pilha x = new Pilha();
        static void Menu(Pilha propilha)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 - Inserir na pilha");
                Console.WriteLine("2 - Remover da pilha");
                Console.WriteLine("3 - Imprimir a pilha");

                Console.WriteLine("Escolha uma opção: ");
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    default:
                        Console.Write("Errou!");
                        break;

                    case 1:
                        Console.Write("Informe o valor da nota: ");
                        int valor = int.Parse(Console.ReadLine());
                        propilha.Inserir(new Money(valor));
                        break;

                    case 2: 
                        propilha.Remover();
                        break;

                    case 3: 
                        propilha.Imprimir();
                        break;
                }
                Console.ReadKey();
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando com pilha!");
            Pilha propilha = new Pilha();
            Menu(propilha);

        }
    }
}
