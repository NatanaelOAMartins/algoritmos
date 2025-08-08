using System;


namespace _04_Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração de vareavel
            //Sintaxe: tipo nomeVareavel = valor
            string nome = "Fulano de tal";
            //retribuição de Valor em uma variavel
            nome = "beltrano";
            Console.WriteLine(nome);

            //declaração de vetores
            //Sintaxe: tipo[] nomeVariavel = {valor1, valor2, valor3};
            string[] nomes = { "Fulano de tal", "beltrano", "ciclano", "João", "Maria",  };
            Console.WriteLine(nomes[0]);
            Console.WriteLine(nomes[1]);
            Console.WriteLine(nomes[2]);

            //Loop FOR
            // for( indice; controle; incremento)
            for (int i = 0; i < nomes.Length; i++)
            { 
            Console.WriteLine("{0}° Nome: {1}",i+1, nomes[i]);
            }
            //inpressão dos 100 primeiros numeros pares
            for (int i = 0; i <= 100; i += 2) 
            {
            Console.WriteLine("numero:{0}", i);
            }
            //Loop foreach
            //Sintexe: foreach( Variavel in vetor
            foreach (string varNome in nomes) 
            { 
            Console.WriteLine("Nome: {0}", varNome);
            }
        }
    }
}
