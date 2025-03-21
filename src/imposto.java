import java.util.Scanner;

public class imposto {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Solicita a entrada do usuário
        System.out.print("Informe o valor do produto: ");
        double preco = scanner.nextDouble();

        // Calcula o novo preço com acréscimo de 10%
        double novoPreco = preco * 1.10;

        // Exibe o resultado
        System.out.println("Novo valor do produto: " + novoPreco);

        scanner.close();
    }
}