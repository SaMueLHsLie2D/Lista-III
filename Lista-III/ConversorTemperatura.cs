using System;

class ConversorTemperatura
{
    public static void Conversor()
    {
        Console.Write("Digite a temperatura em Fahrenheit: ");

        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double celsius = (fahrenheit - 32) / 1.8;

        Console.WriteLine($"A temperatura em Celsius é: {celsius:F2}°C");
        Console.WriteLine("\nPressione ENTER para voltar ao menu...");
        Console.ReadLine();
    }
}
