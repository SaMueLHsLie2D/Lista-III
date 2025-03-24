using System;

class CalculadoraMedias
{
    public static void CalculadoraM()
    {
        Console.Clear();
        Console.WriteLine("Digite três valores:");

        Console.Write("Valor 1: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Valor 2: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Valor 3: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Média Aritmética
        double mediaAritmetica = (a + b + c) / 3;

        // Média Harmônica
        double mediaHarmonica = 3 / ((1 / a) + (1 / b) + (1 / c));

        // Média Geométrica
        double mediaGeometrica = Math.Pow(a * b * c, 1.0 / 3.0);

        Console.WriteLine("\nResultados:");
        Console.WriteLine($"Média Aritmética: {mediaAritmetica:F2}");
        Console.WriteLine($"Média Harmônica: {mediaHarmonica:F2}");
        Console.WriteLine($"Média Geométrica: {mediaGeometrica:F2}");

        Console.WriteLine("\nPressione ENTER para voltar ao menu...");
        Console.ReadLine();
    }
}
