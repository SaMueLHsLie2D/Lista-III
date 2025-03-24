using System;

class ConversorTempo
{
    public static void ConversorT()
    {
        Console.Clear();
        Console.Write("Digite a quantidade de segundos: ");
        int totalSegundos = Convert.ToInt32(Console.ReadLine());

        int horas = totalSegundos / 3600;
        int minutos = (totalSegundos % 3600) / 60;
        int segundos = totalSegundos % 60;

        Console.WriteLine($"\nO tempo correspondente é: {horas}h {minutos}m {segundos}s");
        Console.WriteLine("\nPressione ENTER para voltar ao menu...");
        Console.ReadLine();
    }
}
