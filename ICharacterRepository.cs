using System.Collections.Generic;

public interface ICharacterRepository
{
    List<Character> GetAll();
    Character? GetById(int id);
    void Add(Character character);
    void SaveAll();
}
