using System;
using System.Collections.Generic;
using System.Linq;

public class InMemoryCharacterRepository : ICharacterRepository
{
    private readonly List<Character> _characters = new();
    private int _nextId = 1;

    public InMemoryCharacterRepository()
    {
        Add(new Character
        {
            Name = "Arthon",
            Race = "Elf",
            Class = "Mage",
            ImagePath = "img/arthon.png",
            Description = "Wise elven mage."
        });

        Add(new Character
        {
            Name = "Krog",
            Race = "Orc",
            Class = "Warrior",
            ImagePath = "img/krog.png",
            Description = "Strong orc warrior."
        });
    }

    public List<Character> GetAll() => new(_characters);

    public Character? GetById(int id) =>
        _characters.FirstOrDefault(c => c.Id == id);

    public void Add(Character character)
    {
        character.Id = _nextId++;
        _characters.Add(character);
    }

    public void SaveAll()
    {
        Console.WriteLine("[Repo] Дані збережено (заглушка).");
    }
}
