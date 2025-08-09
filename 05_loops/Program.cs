using System;
using System.Linq;

namespace _05_loops
{
    internal class Program
    {
        private static bool str;

        static void Main(string[] args)
        {
            string[] nomes = new string[100];
            string continuar = "S";
            int contador = 0;

            while (continuar.ToUpper() == "S")
            {
                Console.WriteLine("Digite o {0}ª nome: ", contador+1);
                //append: adiciona um item no vetor
                nomes[contador] = Console.ReadLine();
                contador++;

                Console.WriteLine("Deseja continuar? (S/N)");
                continuar = Console.ReadLine();
            }
            Console.WriteLine("Nomes informados:");
            foreach (string str in nomes)
            {
                if (str != null)
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}
