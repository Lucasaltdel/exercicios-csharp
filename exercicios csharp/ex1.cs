using System;

class Temperatura 
{
    static void Main()
    {
        Console.Write("Digite se quer converter para Celsius (digite 'c') ou Fahrenheit (digite 'f'): ");
        string escolha = Console.ReadLine().ToLower(); 

        if (escolha == "c") 
        {
            Console.Write("Digite a temperatura em Fahrenheit: ");
            double f = double.Parse(Console.ReadLine()); 
            double c = (5.0 / 9.0) * (f - 32); 
            Console.WriteLine("Temperatura em Celsius: " + c + " graus");
        }
        else if (escolha == "f") 
        {
            Console.Write("Digite a temperatura em Celsius: ");
            double c = double.Parse(Console.ReadLine());
            double f = c * 1.8 + 32;
            Console.WriteLine("Temperatura em Fahrenheit: " + f + " graus");
        }
        else
        {
            Console.WriteLine("Opção inválida! Digite apenas 'c' ou 'f'.");
        }
    }
}
