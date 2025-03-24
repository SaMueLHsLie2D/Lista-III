using System;

class SalarioVendedor
{
    public static void CalcularSalario()
    {
        Console.Clear();
        Console.Write("Digite o salário fixo do vendedor: ");
        double salarioFixo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor total das vendas no mês: ");
        double totalVendas = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o percentual de comissão (%): ");
        double percentualComissao = Convert.ToDouble(Console.ReadLine());

        double comissao = (percentualComissao / 100) * totalVendas;
        double salarioTotal = salarioFixo + comissao;

        Console.WriteLine($"\nO salário total do vendedor é: R$ {salarioTotal:F2}");
        Console.WriteLine("\nPressione ENTER para voltar ao menu...");
        Console.ReadLine();
    }
}
