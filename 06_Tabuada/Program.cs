using System;


namespace _06_Tabuada
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Digite um numero:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nTabuada do {numero}:");
            for (int i = 1; i <= 10; i++)
            { 
            Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
    }
}
