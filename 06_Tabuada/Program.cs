using System;


namespace _06_Tabuada
{
    internal class Program
        static void Main(string[] args)
    {
        int multiplicando = 0; produto;
        bool digitacaoValida = false;

        //! negação: inverter o valor booleano
        //! false = true
        //! true = false
        //  wihile ( digitacaovalida == false )

        while ( !digitacaoValida )

        {
            Console.WriteLine("Digite um numero inteiro:");
            digitacaoValida = int.TryParse(Console.ReadLine(), out multiplicando);



            Console.WriteLine($"TABUADA DO {multiplicando}:");
            for (int multiplicador = 1; multiplicador <= 10; multiplicador++) 
            {
                produto = multiplicando * multiplcador;
            Console.WriteLine($"{multiplicando} x {multiplicador} = {produto}");
            }
        }
    }
}
