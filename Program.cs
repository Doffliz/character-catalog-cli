using System;

class Program
{
    static void Main(string[] args)
    {
        var repo = new InMemoryCharacterRepository();
        var cli = new CLI();

        cli.UseStrategy(new CatalogStrategy(repo));

        Console.WriteLine("Каталог персонажів (CLI)");
        Console.WriteLine("Команди: list, show <id>, create, save, exit");

        while (true)
        {
            Console.Write("> ");
            string? input = Console.ReadLine();

            if (input == null)
                continue;

            if (input.Trim().ToLower() == "exit")
                break;

            cli.ExecCommand(input);
        }

        Console.WriteLine("Готово.");
    }
}
