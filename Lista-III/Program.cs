using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("======= MENU =======");
            Console.WriteLine("01 - Calculadora de média aritmética");
            Console.WriteLine("02 - Calculadora de 10% de acréscimo no preço");
            Console.WriteLine("03 - Conversor de Temperatura");
            Console.WriteLine("04 - Calculadora de Juros Compostos");
            Console.WriteLine("05 - Calculadora de Salário Bruto");
            Console.WriteLine("06 - Calculadora de Logaritmo");
            Console.WriteLine("07 - Calculadora de Salário de Vendedor");
            Console.WriteLine("08 - Calculadora de Estacionamento");
            Console.WriteLine("09 - Conversor de Tempo");
            Console.WriteLine("10 - Calculadora de Médias");
            Console.WriteLine("11 - Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine()?.Trim() ?? string.Empty;

            switch (opcao)
            {
                case "1":
                    MediaAritmetica.CalcularMedia();
                    break;

                case "2":
                    AcrescimoPreco.CalcularNovoPreco();
                    break;

                case "3":
                    ConversorTemperatura.Conversor();
                    break;

                case "4":
                    CalculadoraJuros.CalculadoraJ();
                    break;

                case "5":
                    CalculadoraSalario.CalculadoraS();
                    break;

                case "6":
                    CalculadoraLogaritmo.CalculadoraL();
                    break;

                case "7":
                    SalarioVendedor.CalcularSalario();
                    break;

                case "8":
                    Estacionamento.CalcularVeiculos();
                    break;

                case "9":
                    ConversorTempo.ConversorT();
                    break;

                case "10":
                    CalculadoraMedias.CalculadoraM();
                    break;

                case "11":
                    continuar = false;
                    Console.WriteLine("Saindo... Obrigado por usar o programa!");
                    break;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

            if (continuar)
            {
                Console.Write("\nDeseja rodar outro programa? (S/N): ");
                continuar = (Console.ReadLine()?.Trim().ToUpper() == "S");
            }
        }
    }
}

