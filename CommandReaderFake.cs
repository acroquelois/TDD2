namespace TDD2
{
    public class CommandReaderFake: ICommandReader
    {
        // Distinct method because different implementation in real
        public Task createTask(Command command)
        {
            return new Task(0, command.Param);
        }

        public string viewTask(Command command)
        {
            return "Acheter du pain";
        }
    }
}