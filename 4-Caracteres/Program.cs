using System;

class Info
{
    public string nome;
    public char letra;
    public char asciiCode;
    public char asciiDeslocado;

    public Info(string nome, char letra, char asciiCode, char asciiDeslocado)
    {
        this.nome = nome;
        this.letra = letra;
        this.asciiCode = asciiCode;
        this.asciiDeslocado = asciiDeslocado;
    }
}
class Program
{
    private static void showInfo(Info data)
    {
        Console.WriteLine(
            $"Nome: {data.nome}\n" +
            $"Letra: {data.letra}\n" +
            $"ASCII Char: {data.asciiCode}\n" +
            $"ASCII Char deslocado {data.asciiDeslocado}");
    }

    private static void chooseOption(string op, Info data)
    {
        switch (op)
        {
            case "1":
                showInfo(data);
                Console.WriteLine($"\n{data.nome} Escolheu Go\n");
                break;
            case "2":
                showInfo(data);
                Console.WriteLine($"\n{data.nome} Escolheu C#\n");
                break;
            case "3":
                showInfo(data);
                Console.WriteLine($"\n{data.nome} Escolheu Java\n");
                break;
            case "4":
                showInfo(data);
                Console.WriteLine($"\n{data.nome} Escolheu Python\n");
                break;
            case "5":
                showInfo(data);
                Console.WriteLine($"\n{data.nome} Escolheu Ruby\n");
                break;
            default:
                Console.WriteLine("\nFim do programa!\n");
                break;
        }
    }
    private static void showMenu(Info data)
    {
        string op;
        do
        {
            Console.WriteLine(
                "** ESCOLHA UMA OPÇÃO **\n" +
                "1 - Go\n" +
                "2 - C#\n" +
                "3 - Java\n" +
                "4 - Python\n" +
                "5 - Ruby\n" +
                "0 - Sair\n\n"
                );
            Console.Write("Digite a sua opção: ");
            op = Console.ReadLine();
            chooseOption(op, data);
        } while (op != "0");
    }
    static void Main(string[] args)
    {
        var date = DateTime.Now;
        char letra = 'a';
        char asciiCode = (char)65;
        char asciiDeslocado = (char)(65 + 1);
        string nome = "Thiago";
        var data = new Info(nome, letra, asciiCode, asciiDeslocado);
        Console.WriteLine($"Projeto 5 e 6 - Textos e chars - {date}\n");
        showMenu(data);
        Console.WriteLine("Aperte enter para continuar...");
        Console.ReadLine();
    }
}