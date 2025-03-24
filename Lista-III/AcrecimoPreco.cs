using System;

class AcrescimoPreco
{
    public static void CalcularNovoPreco()
    {
        Console.Clear();
        Console.Write("Informe o valor do produto: ");
        double preco = Convert.ToDouble(Console.ReadLine());

        double novoPreco = preco * 1.10; // Acrescenta 10%

        Console.WriteLine($"Novo valor do produto: {novoPreco:F2}");
        Console.WriteLine("\nPressione ENTER para voltar ao menu...");
        Console.ReadLine();
    }
}
