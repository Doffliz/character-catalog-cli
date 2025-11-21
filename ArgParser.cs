using System;
using System.Linq;

public class ArgParser
{
    public Args ParseArgs(string raw)
    {
        var result = new Args();

        if (string.IsNullOrWhiteSpace(raw))
            return result;

        var parts = raw.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        result.CommandName = parts[0];

        foreach (var part in parts.Skip(1))
        {
            if (part.StartsWith("--"))
            {
                var without = part.Substring(2);
                var eqIndex = without.IndexOf('=');

                if (eqIndex >= 0)
                {
                    var key = without[..eqIndex];
                    var value = without[(eqIndex + 1)..];
                    result.Options[key] = value;
                }
                else
                {
                    result.Options[without] = "true";
                }
            }
            else
            {
                result.Positionals.Add(part);
            }
        }

        return result;
    }
}
