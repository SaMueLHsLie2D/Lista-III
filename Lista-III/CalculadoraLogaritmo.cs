using System;

class CalculadoraLogaritmo
{
    public static void CalculadoraL()
    {
        Console.Clear();
        Console.Write("Digite o número: ");
        double numero = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a base do logaritmo: ");
        double baseLog = Convert.ToDouble(Console.ReadLine());

        if (numero > 0 && baseLog > 0 && baseLog != 1)
        {
            double resultado = Math.Log(numero, baseLog);
            Console.WriteLine($"O logaritmo de {numero} na base {baseLog} é: {resultado:F4}");
        }
        else
        {
            Console.WriteLine("Erro: O número e a base devem ser positivos e a base não pode ser 1.");
        }

        Console.WriteLine("\nPressione ENTER para voltar ao menu...");
        Console.ReadLine();
    }
}
