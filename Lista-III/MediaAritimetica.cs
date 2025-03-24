using System;

class MediaAritmetica
{
    public static void CalcularMedia()
    {
        Console.Clear();
        Console.Write("Digite o primeiro número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        double media = (numero1 + numero2) / 2;

        Console.WriteLine($"A média aritmética é: {media:F2}");
        Console.WriteLine("\nPressione ENTER para voltar ao menu...");
        Console.ReadLine();
    }
}