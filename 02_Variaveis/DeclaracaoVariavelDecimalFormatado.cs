using System;
class DeclaracaoVariaveisDecimalFormatado
{
	static void Main(string[] args)
	{
		decimal x = 0.999m;
		decimal y = 9999999999999999999999999999m;
		/* Utilizado*/
		Console.WriteLine("Minha quantia = {0:c}", x);
		Console.WriteLine("Sua quantia = {0:c}", y);
		Console.WriteLine("Valor de x = {0:F3} e Valor de y = {1:c}",x,y);
		/*
		Console.WriteLine($"Minha quantia = {x:c}", x);
		Console.WriteLine($"Sua quantia = {y:c}", y);
		Console.WriteLine($"Valor de x = {x:F3} e Valor de y = {y:c}",x,y);
		*/
	}
}