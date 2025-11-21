using System.Collections.Generic;

public class Args
{
    public string CommandName { get; set; } = "";
    public List<string> Positionals { get; } = new();
    public Dictionary<string, string> Options { get; } = new();
}
