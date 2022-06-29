using System;

class Program
{
    public static void Fatorial_For_Loop(double num)
    {
        Console.WriteLine("\nFATORIAL COM FOR");
        double i, fat;
        fat = num;
        for (i = num - 1; i >= 1; i--)
        {
            fat = fat * i;

        }
        Console.WriteLine($"O fatorial de {num} é {fat}");
        Console.WriteLine("================ \\\\ ================");
    }
    public static void Fatorial_While_Loop(double num)
    {
        Console.WriteLine("\nFATORIAL COM WHILE");
        double fat;
        fat = num;
        while ( num != 1 )
        {
            fat = fat * num;
            num--;
        }
        Console.WriteLine($"O fatorial de {num} é {fat}");
        Console.WriteLine("================ \\\\ ================");
    }
    static void Main(string[] args)
    {
        double num;
        Console.Write("Informe um número: ");
        num = double.Parse(Console.ReadLine());
        Fatorial_For_Loop(num);
        Fatorial_While_Loop(num);
        Console.WriteLine("Press any key to continue...");
        Console.ReadLine();
    }
}