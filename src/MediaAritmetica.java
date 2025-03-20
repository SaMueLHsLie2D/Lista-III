
import java.util.Scanner;

public class MediaAritmetica {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Solicita a entrada do usuário
        System.out.print("Digite o primeiro número: ");
        double num1 = scanner.nextDouble();

        System.out.print("Digite o segundo número: ");
        double num2 = scanner.nextDouble();

        // Calcula a média aritmética
        double media = (num1 + num2) / 2;

        // Exibe o resultado
        System.out.println("A média aritmética é: " + media);

        scanner.close();
    }
}
