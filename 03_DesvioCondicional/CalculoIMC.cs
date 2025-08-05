using System;
 
 class calculoIMC
 {
	 static void Main()
	 {
	 double peso, altura, imc;
	 
	 Console.WriteLine("Digite o seu peso (kg):");
	 peso = Double.Parse(Console.ReadLine() );
	 
	 Console.WriteLine("Digite sua altura (m)");
	 altura = Double.Parse (Console.ReadLine() );
	 
	imc = peso / (altura * altura);
	
	Console.WriteLine("seu IMC é {0:F3}", imc);
	if(imc < 18.5)
	{
		Console.WriteLine("Classificação: abaixo do peso");
	}else if( imc < 25 )
	{
	Console.WriteLine("clasificação: peso normal");	
	}else
	{
		Console.WriteLine("clasificação: acima do peso");
	}
	 }
 
 }