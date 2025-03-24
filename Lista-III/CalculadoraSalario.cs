using System;

class CalculadoraSalario
{
    public static void CalculadoraS()
    {
        Console.Write("Digite o número de horas trabalhadas no mês: ");
        double horasTrabalhadas = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor recebido por hora (R$): ");
        double valorHora = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor do salário família por filho (R$): ");
        double salarioFamiliaPorFilho = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o número de filhos menores de 14 anos: ");
        int numeroFilhos = Convert.ToInt32(Console.ReadLine());

        // Cálculo do salário bruto
        double salarioBruto = (horasTrabalhadas * valorHora) + (numeroFilhos * salarioFamiliaPorFilho);

        Console.WriteLine($"O salário bruto a ser recebido é: R$ {salarioBruto:F2}");
        Console.WriteLine("\nPressione ENTER para voltar ao menu...");
        Console.ReadLine();
    }
}
