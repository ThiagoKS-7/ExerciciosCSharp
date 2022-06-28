using System;


class Program
{
    static void Main(string[] args)
    {
        var date = DateTime.Now;
        Console.WriteLine($"Projeto 2 e 3 - Criando variáveis - {date}\n");
        int idade = 27;
        idade = (5 * 5) + 2;
        int calculo = 27 - 5;
        double peso = 5.5;
        double calculoDouble = 7 / 5.0;
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Calculo: " + calculo);
        Console.WriteLine("float: " + peso);
        Console.WriteLine("Calculo double: " + calculoDouble);
        Console.WriteLine("\nPressione enter para continuar...");
        Console.ReadLine();
    } 
}