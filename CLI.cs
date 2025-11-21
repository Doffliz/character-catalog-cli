using System;
using System.Collections.Generic;
using System.Linq;

public class CLI
{
    private readonly List<ICommandStrategy> _strategies = new();
    private readonly ArgParser _parser = new();

    public void UseStrategy(ICommandStrategy strategy)
    {
        _strategies.Add(strategy);
    }

    public void ExecCommand(string rawInput)
    {
        var args = _parser.ParseArgs(rawInput);

        if (string.IsNullOrWhiteSpace(args.CommandName))
            return;

        var strat = _strategies.FirstOrDefault(s =>
            s.GetCommandSelectors().Contains(args.CommandName));

        if (strat == null)
        {
            Console.WriteLine($"Невідома команда: {args.CommandName}");
            return;
        }

        strat.ExecCommand(args.CommandName, args);
    }
}
