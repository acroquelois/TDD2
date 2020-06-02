namespace TDD2
{
    public class ConsoleWriterMock: IConsoleWriter
    {
        public int WriteIsCalled { get; set; } = 0;
        
        public void write(string str)
        {
            WriteIsCalled = 1;
        }
    }
}