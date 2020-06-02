namespace TDD2
{
    public class InputReaderFake: IInputReader

    {
        public Command readInput(string cmd)
        {
            if (cmd == "tasks view 0")
            {
                return new Command(ActionEnum.View, "0");
            }
            else
            {
                return new Command(ActionEnum.Create, "Acheter du pain");   
            }
        }
    }
}