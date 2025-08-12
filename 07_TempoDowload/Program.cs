using System;
using System.Globalization;

namespace _07_TempoDownload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tamanhoMB = 0;
            double velocidadeMbps = 0;
            bool digitacaoValida = false;

            while (!digitacaoValida)
                 {
                Console.Write("Informe o tamanho do arquivo (MB): ");
                digitacaoValida = double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out tamanhoMB);

                if (!digitacaoValida || tamanhoMB <= 0)
            {
                    Console.WriteLine("Valor inválido! Digite um número maior que zero.");
                    digitacaoValida = false;
            }
                }
           
            
            {
                Console.Write("Informe a velocidade da internet (Mbps): ");
                digitacaoValida = double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out velocidadeMbps);

                if (!digitacaoValida || velocidadeMbps <= 0)
                {
                    Console.WriteLine("Valor inválido! Digite um número maior que zero.");
                    digitacaoValida = false;
                }
            }

            
            double tempoSegundos = (tamanhoMB * 8) / velocidadeMbps;
            double tempoMinutos = tempoSegundos / 60;

            
            Console.WriteLine($"Tempo aproximado de download: {tempoMinutos:F2} minutos");
            Console.ReadLine();
        }
    }
}