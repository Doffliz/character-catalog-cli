using System;

public class CatalogStrategy : ICommandStrategy
{
    private readonly ICharacterRepository _repo;

    public CatalogStrategy(ICharacterRepository repo)
    {
        _repo = repo;
    }

    public string[] GetCommandSelectors() =>
        new[] { "list", "show", "create", "save" };

    public void ExecCommand(string name, Args args)
    {
        switch (name)
        {
            case "list":
                ExecList();
                break;

            case "show":
                ExecShow(args);
                break;

            case "create":
                ExecCreate();
                break;

            case "save":
                ExecSave();
                break;

            default:
                Console.WriteLine($"Невідома команда: {name}");
                break;
        }
    }

    private void ExecList()
    {
        var list = _repo.GetAll();
        new CharacterListRenderer().Render(list);
    }

    private void ExecShow(Args args)
    {
        if (args.Positionals.Count == 0)
        {
            Console.WriteLine("Використання: show <id>");
            return;
        }

        if (!int.TryParse(args.Positionals[0], out var id))
        {
            Console.WriteLine("ID має бути числом.");
            return;
        }

        var character = _repo.GetById(id);
        if (character == null)
        {
            Console.WriteLine($"Персонажа з ID={id} не знайдено.");
            return;
        }

        new CharacterDetailsRenderer().Render(character);
    }

    private void ExecCreate()
    {
        var c = new Character();

        Console.Write("Ім'я: ");
        c.Name = Console.ReadLine() ?? "";

        Console.Write("Раса: ");
        c.Race = Console.ReadLine() ?? "";

        Console.Write("Клас: ");
        c.Class = Console.ReadLine() ?? "";

        Console.Write("Шлях до графіки: ");
        c.ImagePath = Console.ReadLine() ?? "";

        Console.Write("Опис: ");
        c.Description = Console.ReadLine() ?? "";

        _repo.Add(c);

        Console.WriteLine("Персонажа створено!");
        new CharacterDetailsRenderer().Render(c);
    }

    private void ExecSave()
    {
        _repo.SaveAll();
        Console.WriteLine("Дані збережено.");
    }
}
