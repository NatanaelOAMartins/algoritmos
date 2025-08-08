//classificacao_idade
using System;

class classificacao_idade
{
    static void Main()
    {
        int idade;

        Console.Write("Digite sua idade: ");
        idade = Convert.ToInt32(Console.ReadLine());

        if (idade <= 12)
        {
            Console.WriteLine("Você é criança");
        }
        else if (idade <= 17)
        {
            Console.WriteLine("Você é adolescente");
        }
        else
        {
            Console.WriteLine("Você é adulto");
        }

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
