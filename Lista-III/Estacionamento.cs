using System;

class Estacionamento
{
    public static void CalcularVeiculos()
    {
        Console.Clear();
        Console.Write("Digite o total de veículos no estacionamento: ");
        int totalVeiculos = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o total de rodas no estacionamento: ");
        int totalRodas = Convert.ToInt32(Console.ReadLine());

        int motos = (totalRodas - (4 * totalVeiculos)) / -2;
        int carros = totalVeiculos - motos;

        if (motos >= 0 && carros >= 0 && (4 * carros + 2 * motos) == totalRodas)
        {
            Console.WriteLine($"\nTotal de carros: {carros}");
            Console.WriteLine($"Total de motos: {motos}");
        }
        else
        {
            Console.WriteLine("\nOs valores informados são inválidos!");
        }

        Console.WriteLine("\nPressione ENTER para voltar ao menu...");
        Console.ReadLine();
    }
}
