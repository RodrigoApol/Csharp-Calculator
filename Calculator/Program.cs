namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.WriteLine("Qual operação deseja fazer?");

        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Potência");
        Console.WriteLine("6 - Sair");

        Console.WriteLine("---------");

        Console.Write("Escolha uma opção: ");
        short opcao = short.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Multiplicacao(); break;
            case 4: Divisao(); break;
            case 5: Potencia(); break;
            case 6: Environment.Exit(0); break;
            default: Menu(); break;
        }
    }

    static void Soma()
    {
        Console.Clear();

        Console.Write("Digite um valor: ");

        float firstValue = float.Parse(Console.ReadLine());
        Console.WriteLine("");

        Console.Write("Digite o segundo valor: ");

        float secondValue = float.Parse(Console.ReadLine());
        Console.WriteLine("");

        var resultado = firstValue + secondValue;

        Console.WriteLine($"O resultado da soma é {resultado}");

        Console.ReadKey();

        Menu();
    }

    static void Subtracao()
    {
        Console.Clear();

        Console.Write("Digite um valor: ");

        float firstValue = float.Parse(Console.ReadLine());
        Console.WriteLine("");

        Console.Write("Digite o segundo valor: ");

        float secondValue = float.Parse(Console.ReadLine());
        Console.WriteLine("");

        var resultado = firstValue - secondValue;

        Console.WriteLine($"O resultado da subtração é {resultado}");

        Console.ReadKey();

        Menu();
    }

    static void Multiplicacao()
    {
        Console.Clear();

        Console.Write("Digite um valor: ");

        float firstValue = float.Parse(Console.ReadLine());
        Console.WriteLine("");

        Console.Write("Digite o segundo valor: ");

        float secondValue = float.Parse(Console.ReadLine());
        Console.WriteLine("");

        var resultado = firstValue * secondValue;

        Console.WriteLine($"O resultado da multiplicação é {resultado}");

        Console.ReadKey();

        Menu();
    }

    static void Divisao()
    {
        Console.Clear();

        Console.Write("Digite um valor: ");

        float firstValue = float.Parse(Console.ReadLine());
        Console.WriteLine("");

        Console.Write("Digite o segundo valor: ");

        float secondValue = float.Parse(Console.ReadLine());
        Console.WriteLine("");

        var resultado = firstValue / secondValue;

        Console.WriteLine($"O resultado da divisão é {resultado}");

        Console.ReadKey();

        Menu();
    }

    static void Potencia()
    {
        Console.Clear();

        Console.Write("Digite um valor: ");

        float firstValue = float.Parse(Console.ReadLine());
        Console.WriteLine("");

        Console.Write("Digite o segundo valor: ");

        float secondValue = float.Parse(Console.ReadLine());
        Console.WriteLine("");

        var resultado = Math.Pow(firstValue, secondValue);

        Console.WriteLine($"O resultado da Potência é {resultado}");

        Console.ReadKey();

        Menu();
    }
}
