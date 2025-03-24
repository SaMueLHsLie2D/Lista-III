using System;

class CalculadoraJuros
{
    public static void CalculadoraJ()
    {
        Console.Write("Digite o capital inicial (R$): ");
        double capital = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a taxa de juros mensal (%): ");
        double taxaJuros = Convert.ToDouble(Console.ReadLine()) / 100; // Convertendo para decimal

        Console.Write("Digite o prazo da aplicação (meses): ");
        int prazo = Convert.ToInt32(Console.ReadLine());

        // Fórmula dos juros compostos: M = C × (1 + i)^n
        double montante = capital * Math.Pow((1 + taxaJuros), prazo);

        Console.WriteLine($"O montante ao final do período será: R$ {montante:F2}");
        Console.WriteLine("\nPressione ENTER para voltar ao menu...");
        Console.ReadLine();
    }
}
