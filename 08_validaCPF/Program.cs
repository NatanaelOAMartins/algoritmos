using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08_validaCPF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite o CPF: ");
            string entrada = Console.ReadLine();
            string cpf = Regex.Replace(entrada, "[^0-9]", "");
            if ( cpf.Length != 11 || new string(cpf[0], 11) == cpf)
            {
                Console.WriteLine("CPF invslido!");
                return;
            }
             int soma1 = 0, soma2 = 0;
            
            for (int i = 0; i < 9; i++)
                soma1 += (cpf[i] - '0') * (10 - i);

            int digito1 = (soma1 % 11 < 2) ? 0 : 11 - (soma1 % 11);

            for (int i = 0; i < 10; i++)
                soma2 += (cpf[i] - '0') * (11 - i);

            int digito2 = (soma2 % 11 < 2) ? 0 : 11 - (soma2 % 11);

            if (cpf[9] - '0' == digito1 && cpf[10] - '0' == digito2)
                Console.WriteLine("CPF válido!");
            else
                Console.WriteLine("CPF inválido!");

        }
    }
}
