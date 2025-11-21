using System;
using System.Collections.Generic;

public class CharacterListRenderer : IRenderer<List<Character>>
{
    public void Render(List<Character> characters)
    {
        if (characters.Count == 0)
        {
            Console.WriteLine("Список персонажів порожній.");
            return;
        }

        Console.WriteLine("ID   Ім'я        Раса        Клас        Графіка");
        Console.WriteLine("--------------------------------------------------");

        foreach (var c in characters)
        {
            Console.WriteLine($"{c.Id,-4} {c.Name,-10} {c.Race,-10} {c.Class,-10} {c.ImagePath}");
        }
    }
}
