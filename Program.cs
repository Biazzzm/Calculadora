using System.Collections;
using System.Diagnostics;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        Menu();

    }

    static void Soma()
    {

        Console.Clear();
        double valor1 = 0;
        double valor2 = 0;
        bool testando = false;
       
        Console.WriteLine("Primeiro Valor: ");

        var input1 = Console.ReadLine();

        try
        {
            valor1 = double.Parse(input1);
        }
        catch (FormatException)
        {
            MinhaExcecao();
            Soma();
        }

        Console.WriteLine(" ");


        do
        {

            Console.WriteLine("Segundo Valor: ");

            var input2 = Console.ReadLine();

            try
            {
                testando = double.TryParse(input2, out double number);
                valor2 = double.Parse(input2);
            }

            catch (FormatException)
            {
                MinhaExcecao();
            }

        } while (testando == false);

        Console.WriteLine(" ");

        double resultado = valor1 + valor2;
        Console.WriteLine($"O resultado da Soma entre {valor1} + {valor2} = {resultado}");
        Console.WriteLine(" ");
        Console.WriteLine("Aperte Enter para voltar ao Menu");

        Console.ReadKey();

        Menu();

    }

    static void Subtracao()
    {

        Console.Clear();
        double valor1 = 0;
        double valor2 = 0;
        bool testando = false;
        Console.WriteLine("Primeiro Valor: ");

        var input1 = Console.ReadLine();

        try
        {
            valor1 = double.Parse(input1);
        }
        catch (FormatException)
        {
            MinhaExcecao();
            Subtracao();
        }


        Console.WriteLine(" ");


        do
        {

            Console.WriteLine("Segundo Valor: ");

            var input2 = Console.ReadLine();

            try
            {
                testando = double.TryParse(input2, out double number);
                valor2 = double.Parse(input2);
            }

            catch (FormatException)
            {
                MinhaExcecao();
            }

        } while (testando == false);


        Console.WriteLine(" ");

        double resultado = valor1 - valor2;
        Console.WriteLine($"O resultado da Subtração entre {valor1} - {valor2} = {resultado}");
        Console.WriteLine(" ");
        Console.WriteLine("Aperte Enter para voltar ao Menu");
        Console.ReadKey();

        Menu();
    }

    static void Multiplicacao()
    {

        Console.Clear();
        double valor1 = 0;
        double valor2 = 0;
        bool testando = false;
        Console.WriteLine("Primeiro Valor: ");

        var input1 = Console.ReadLine();

        try
        {
            valor1 = double.Parse(input1);
        }
        catch (FormatException)
        {
            MinhaExcecao();
            Multiplicacao();
        }


        Console.WriteLine(" ");


        do
        {

            Console.WriteLine("Segundo Valor: ");

            var input2 = Console.ReadLine();

            try
            {
                testando = double.TryParse(input2, out double number);
                valor2 = double.Parse(input2);
            }

            catch (FormatException)
            {
                MinhaExcecao();
            }

        }

        while (testando == false);

        Console.WriteLine(" ");

        double resultado = valor1 * valor2;
        Console.WriteLine($"O resultado da Multiplicação entre {valor1} x {valor2} = {resultado}");
        Console.WriteLine(" ");
        Console.WriteLine("Aperte Enter para voltar ao Menu");
        Console.ReadKey();

        Menu();
    }

    static void Divisao()
    {

        Console.Clear();
        double valor1 = 0;
        double valor2 = 0;
        bool testando = false;
        Console.WriteLine("Primeiro Valor: ");

        var input1 = Console.ReadLine();

        try
        {
            valor1 = double.Parse(input1);
        }
        catch (FormatException)
        {
            MinhaExcecao();
            Divisao();
        }


        Console.WriteLine(" ");


        do
        {

            Console.WriteLine("Segundo Valor: ");

            var input2 = Console.ReadLine();

            try
            {
                testando = double.TryParse(input2, out double number);
                valor2 = double.Parse(input2);
            }

            catch (FormatException)
            {
                MinhaExcecao();
            }

        } while (testando == false);


        Console.WriteLine(" ");

        double resultado = valor1 / valor2;
        Console.WriteLine($"O resultado da Divisão entre {valor1} / {valor2} = {resultado}");
        Console.WriteLine(" ");
        Console.WriteLine("Aperte Enter para voltar ao Menu");
        Console.ReadKey();

        Menu();
    }

    static void Exponencial()
    {

        Console.Clear();
        double valor1 = 0;
        double valor2 = 0;
        bool testando = false;
        Console.WriteLine("Digite o valor da base: ");

        var input1 = Console.ReadLine();

        try
        {
            valor1 = double.Parse(input1);
        }
        catch (FormatException)
        {
            MinhaExcecao();
            Exponencial();
        }


        Console.WriteLine(" ");


        do
        {

            Console.WriteLine("Digite o valor do exponencial: ");

            var input2 = Console.ReadLine();

            try
            {
                testando = double.TryParse(input2, out double number);
                valor2 = double.Parse(input2);
            }

            catch (FormatException)
            {
                MinhaExcecao();
            }


        } while (testando == false);

        double resultado = Math.Pow(valor1, valor2);

        Console.WriteLine($"O resultado de {valor1} elevado à {valor2} = {resultado}");
        Console.WriteLine(" ");
        Console.WriteLine("Aperte Enter para voltar ao Menu");
        Console.ReadKey();

        Menu();
    }

    static void Bhaskara()
    {
        Console.Clear();
        double a = 0;
        double b = 0;
        double c = 0;
        bool testando = false;
        Console.WriteLine("Essa Função realiza o calculo de Bhaskara: Ax² + Bx + C = 0 ");

        Console.WriteLine("Digite o valor de A: ");
        var inputA = Console.ReadLine();
        try
        {
            a = double.Parse(inputA);
        }
        catch (FormatException)
        {
            MinhaExcecao();
            Bhaskara();
        }

        Console.WriteLine(" ");
        do
        {
            Console.WriteLine("Digite o valor de B: ");
            var inputB = Console.ReadLine();
            try
            {
                testando = double.TryParse(inputB, out double number);
                b = double.Parse(inputB);
            }
            catch (FormatException)
            {
                MinhaExcecao();
                Console.Clear();
            }

            Console.WriteLine(" ");
        } while (testando == false);

        do
        {
            Console.WriteLine("Digite o valor de c: ");
            var inputC = Console.ReadLine();
            try
            {
                testando = double.TryParse(inputC, out double number);
                c = double.Parse(inputC);
            }
            catch (FormatException)
            {
                MinhaExcecao();
                Console.Clear();
            }

            Console.WriteLine(" ");
        } while (testando == false);

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
        var opcao = Console.ReadLine();


        switch (opcao)
        {
            case "1":
                Soma();
                break;
            case "2":
                Subtracao();
                break;
            case "3":
                Multiplicacao();
                break;
            case "4":
                Divisao();
                break;
            case "5":
                Exponencial();
                break;
            case "6":
                Bhaskara();
                break;

            case "7":
                CalculoAreaTriangulo();
                break;
            case "8":
                Console.WriteLine("Fim do Programa! Volte Sempre");
                System.Environment.Exit(0);
                break;
            default:
                Console.Clear();
                Console.WriteLine("Opção Inválida! Tente novamente");

                Console.WriteLine("Aperte qualquer tecla para voltar ao Menu");
                Console.ReadKey();
                Menu();
                break;


        }

    }

    static void CalculoAreaTriangulo()
    {
        Console.Clear();
        double baseT = 0;
        double alturaT = 0;
        bool testando = false;
        Console.WriteLine("Calculo da Área de um Triangulo :");

        Console.WriteLine("Valor da Base em metros:");
        var input1 = Console.ReadLine();

        try
        {
            baseT = double.Parse(input1);

        }
        catch
        {
            MinhaExcecao();
        }
        Console.WriteLine(" ");

        do
        {
            Console.WriteLine("Valor da Altura em metros:");
            var input2 = Console.ReadLine();

            try
            {
                testando = double.TryParse(input2, out double number);
                alturaT = double.Parse(input2);
            }
            catch
            {
                MinhaExcecao();
            }
        } while (testando == false);




        double area = baseT * alturaT / 2;

        Console.WriteLine($"A área do triângulo é: {area} m²");

        Console.WriteLine(" ");

        Console.WriteLine("Digite Enter para voltar ao Menu");

        Console.ReadKey();

        Menu();

    }

    static void MinhaExcecao()
    {
        Console.Clear();
        Console.WriteLine("Error: Valor Inválido!");
        Console.WriteLine("Aperte qualquer tecla para voltar");
        Console.ReadKey();
        Console.Clear();
    }

}























