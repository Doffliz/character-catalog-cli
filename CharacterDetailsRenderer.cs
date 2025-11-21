using System;

public class CharacterDetailsRenderer : IRenderer<Character>
{
    public void Render(Character c)
    {
        Console.WriteLine($"ID: {c.Id}");
        Console.WriteLine($"Ім'я: {c.Name}");
        Console.WriteLine($"Раса: {c.Race}");
        Console.WriteLine($"Клас: {c.Class}");
        Console.WriteLine($"Графіка: {c.ImagePath}");
        Console.WriteLine($"Опис: {c.Description}");
    }
}
