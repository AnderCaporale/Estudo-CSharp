using System;

namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        int menu = 1;
        do
        {
            menu = Menu();
            switch (menu)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                default: break;
            }
        } while (menu != 0);
    }

    static void Soma()
    {
        Console.Clear();
        Console.WriteLine("Digite o primeiro valor: ");
        float numero1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        float numero2 = float.Parse(Console.ReadLine());

        float resultado = numero1 + numero2;
        Console.WriteLine("");
        Console.WriteLine("O resultado da soma eh: " + resultado);
        Console.ReadKey();
    }

    static void Subtracao()
    {
        Console.Clear();
        Console.WriteLine("Digite o primeiro valor: ");
        float numero1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        float numero2 = float.Parse(Console.ReadLine());

        float resultado = numero1 - numero2;
        Console.WriteLine("");
        Console.WriteLine("O resultado da soma eh: " + resultado);
        Console.ReadKey();
    }

    static void Divisao()
    {
        Console.Clear();
        Console.WriteLine("Digite o primeiro valor: ");
        float numero1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        float numero2 = float.Parse(Console.ReadLine());

        float resultado = numero1 / numero2;
        Console.WriteLine("");
        Console.WriteLine("O resultado da soma eh: " + resultado);
        Console.ReadKey();
    }

    static void Multiplicacao()
    {
        Console.Clear();
        Console.WriteLine("Digite o primeiro valor: ");
        float numero1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        float numero2 = float.Parse(Console.ReadLine());

        float resultado = numero1 * numero2;
        Console.WriteLine("");
        Console.WriteLine("O resultado da soma eh: " + resultado);
        Console.ReadKey();
    }

    static int Menu()
    {
        int menu = 1;

        Console.Clear();
        Console.WriteLine("Escolha uma opção: ");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("0 - Sair do Programa");

        Console.WriteLine("--------------");
        menu = int.Parse(Console.ReadLine());

        return menu;
    }
}
