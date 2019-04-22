using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod fm = new FactoryMethod();

            Console.WriteLine("Liukeng | Scorpion");
            Console.WriteLine();
            Console.WriteLine("Escolha seu personagem");
            string escolha = Console.ReadLine();

            IPersonagem personagem = fm.Escolher_Pesonagem(escolha);
            Console.WriteLine();
            Console.WriteLine("VC vai jogar com ");
            personagem.Escolhido();

            Console.ReadKey();
        }
    }
}
