using System.Collections;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {

        Menu();

    }

    static void Soma()
    {

        Console.Clear();

        Console.WriteLine("Primeiro Valor: ");
        double v1 = double.Parse(Console.ReadLine());

        Console.WriteLine(" ");

        Console.WriteLine("Segundo Valor: ");
        double v2 = double.Parse(Console.ReadLine());


        Console.WriteLine(" ");

        double resultado = v1 + v2;
        Console.WriteLine($"O resultado da Soma entre {v1} + {v2} = {resultado}");
        Console.WriteLine(" ");
        Console.WriteLine("Aperte Enter para voltar ao Menu");

        Console.ReadKey();

        Menu();

    }

    static void Subtracao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro Valor: ");
        double v1 = double.Parse(Console.ReadLine());

        Console.WriteLine(" ");

        Console.WriteLine("Segundo Valor: ");
        double v2 = double.Parse(Console.ReadLine());


        Console.WriteLine(" ");

        double resultado = v1 - v2;
        Console.WriteLine($"O resultado da Subtração entre {v1} - {v2} = {resultado}");
        Console.WriteLine(" ");
        Console.WriteLine("Aperte Enter para voltar ao Menu");
        Console.ReadKey();

        Menu();
    }

    static void Multiplicacao()
    {

        Console.Clear();

        Console.WriteLine("Primeiro Valor: ");
        double v1 = double.Parse(Console.ReadLine());

        Console.WriteLine(" ");

        Console.WriteLine("Segundo Valor: ");
        double v2 = double.Parse(Console.ReadLine());


        Console.WriteLine(" ");

        double resultado = v1 * v2;
        Console.WriteLine($"O resultado da Multiplicação entre {v1} x {v2} = {resultado}");
        Console.WriteLine(" ");
        Console.WriteLine("Aperte Enter para voltar ao Menu");
        Console.ReadKey();

        Menu();
    }

    static void Divisao()
    {

        Console.Clear();

        Console.WriteLine("Primeiro Valor: ");
        double v1 = double.Parse(Console.ReadLine());

        Console.WriteLine(" ");

        Console.WriteLine("Segundo Valor: ");
        double v2 = double.Parse(Console.ReadLine());


        Console.WriteLine(" ");

        double resultado = v1 / v2;
        Console.WriteLine($"O resultado da Divisão entre {v1} / {v2} = {resultado}");
        Console.WriteLine(" ");
        Console.WriteLine("Aperte Enter para voltar ao Menu");
        Console.ReadKey();

        Menu();
    }

    static void Exponencial()
    {

        Console.Clear();

        Console.WriteLine("Valor da Base: ");
        double v1 = double.Parse(Console.ReadLine());

        Console.WriteLine(" ");

        Console.WriteLine("Valor do Exponencial: ");
        double v2 = double.Parse(Console.ReadLine());


        Console.WriteLine(" ");

        double resultado = Math.Pow(v1, v2);

        Console.WriteLine($"O resultado de {v1} elevado à {v2} = {resultado}");
        Console.WriteLine(" ");
        Console.WriteLine("Aperte Enter para voltar ao Menu");
        Console.ReadKey();

        Menu();
    }

    static void Bhaskara()
    {
        Console.Clear();

        Console.WriteLine("Essa Função realiza o calculo de Bhaskara: Ax² + bx + c = 0 ");

        Console.WriteLine("Digite o valor de A: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine(" ");

        Console.WriteLine("Digite o valor de B: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine(" ");

        Console.WriteLine("Digite o valor de C: ");
        double c = double.Parse(Console.ReadLine());



        Console.WriteLine(" ");

        double delta = Math.Sqrt(b * b - 4 * a * c);
        Console.WriteLine(delta);
        double resultado1 = (-(b) + delta) / (2 * a);
        double resultado2 = (-(b) - delta) / (2 * a);


        Console.WriteLine($" O resultado de x é: {resultado1} e {resultado2}");
        Console.WriteLine(" ");
        Console.WriteLine("Aperte Enter para voltar ao Menu");
        Console.ReadKey();

        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Calculadora");
        Console.WriteLine(" ");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("|          Menu:             |\n|[1] - Soma                  | \n|[2] - Subtração             |\n|[3] - Multiplicacao         |\n|[4] - Divisão               |\n|[5] - Exponencial           |\n|[6] - Calculo de Bharkara   |\n|[7] - Calculo Área Triângulo|\n|[8] - Sair                  |");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Selecione uma opção: ");
        int opcao = Int32.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Soma();
                break;
            case 2:
                Subtracao();
                break;
            case 3:
                Multiplicacao();
                break;
            case 4:
                Divisao();
                break;
            case 5:
                Exponencial();
                break;
            case 6:
                Bhaskara();
                break;

            case 7:
                CalculoAreaTriangulo();
                break;
            case 8:
                Console.WriteLine("Fim do Programa! Volte Sempre");
                System.Environment.Exit(0);
                break;
            default:
                Menu();
                break;

        }

    }

    static void CalculoAreaTriangulo()
    {
        Console.Clear();
        Console.WriteLine("Calculo da Área de um Triangulo :");

        Console.WriteLine("Valor da Base em metros:");
        double baseT = double.Parse(Console.ReadLine());
        Console.WriteLine(" ");

        Console.WriteLine("Valor da Altura em metros:");
        double alturaT = double.Parse(Console.ReadLine());
        Console.WriteLine(" ");

        double area = baseT * alturaT / 2;

        Console.WriteLine($"A área do triângulo é: {area} m²");

        Console.WriteLine(" ");

        Console.WriteLine("Digite Enter para voltar ao Menu");

        Console.ReadKey();

        Menu();






    }
}























