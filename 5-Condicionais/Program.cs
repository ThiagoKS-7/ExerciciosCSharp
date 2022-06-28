using System;

class Program
{
    static void Main(string[] args)
    {
        var date = DateTime.Now;
        Console.WriteLine($"Projeto 7 e 8- Condicionais - {date}\n");
        int idade = 18;
        int qtdAdultos = 0;
        bool taAcompanhado = (qtdAdultos > 0);
        bool maiorIdade = (idade >= 18);
        if (maiorIdade || taAcompanhado)
        {
            string result = taAcompanhado ? "Tá acompanhado" : "É maior de idade";
            Console.WriteLine($"Pode passar, {result}");
        }
        else
        {
            Console.WriteLine("Menor de idade");
        }
        Console.WriteLine("Aperte enter para continuar...");
        Console.ReadLine();
    }
}