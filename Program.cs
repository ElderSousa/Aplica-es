using System.Globalization;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Escolha  a operação a ser realizada: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtracao");
            Console.WriteLine("3 - Multiplicacao");
            Console.WriteLine("4 - Divisao");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("______________________________");
            Console.Write("Selecione uma opção: ");

            int resp = int.Parse(Console.ReadLine());


            switch (resp)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: Environment.Exit(0); break;
                default: Menu(); break; 

            }

        }

        static void Soma()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = v1 + v2;

            Console.WriteLine("");

            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();

            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = v1 - v2;

            Console.WriteLine("");

            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();

            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = v1 / v2;

            Console.WriteLine();

            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();

            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = v1 * v2;

            Console.WriteLine("");

            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();

            Menu();
        }
    }
}

