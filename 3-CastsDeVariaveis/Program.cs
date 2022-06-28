using System;

class Program
{
    static void Main(string[] args)
    {
        var date = DateTime.Now;
        double salario = 3000.15;
        int salInteiro = (int) salario;
        long x = 300000000000000;
        short y = 300;
        float teste = 23.5454544F; // se usa pra ter mais precisão decimal (tem q ter F no fim)
        Console.WriteLine($"Projeto 4 - Casts de variáveis - {date}\n");
        Console.WriteLine(
            $"salario: {salario}\n" +
            $"salInteiro: {salInteiro}\n" +
            $"long: {x}\n" +
            $"short: {y}\n" +
            $"teste: {teste}");
        Console.WriteLine("\nPressione enter para continuar...");
        Console.ReadLine();
    }
}