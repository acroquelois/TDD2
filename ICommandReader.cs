namespace TDD2
{
    public interface ICommandReader
    {
        Task createTask(Command command);

        string viewTask(Command command);
    }
}