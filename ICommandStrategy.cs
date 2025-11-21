public interface ICommandStrategy
{
    string[] GetCommandSelectors();
    void ExecCommand(string name, Args args);
}
