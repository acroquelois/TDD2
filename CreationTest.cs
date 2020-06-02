using System;
using Xunit;

namespace TDD2
{
    public class CreationTest
    {
        /**
         * Given I am a user 
         * When I send a command
         * And I indicate task create command
         * Then I should receive the id of created Task
         */
        [Fact]
        public void Acceptance_Test_Task_Created()
        {
            string cmd = "tasks create  \"Acheter du pain\"";
            InputReaderFake inputReaderFake = new InputReaderFake();
            Command command = inputReaderFake.readInput(cmd);
            CommandReaderFake commandReader = new CommandReaderFake();
            Task task = commandReader.createTask(command);
            String str = task.getId();
            ConsoleWriterMock consoleWriter = new ConsoleWriterMock();
            consoleWriter.write(str);
            Assert.Equal(1, consoleWriter.WriteIsCalled);
        }

        [Fact]
        public void InputReader_ReadInput_Create_Good()
        {
            string cmd = "tasks create  \"Acheter du pain\"";
            InputReaderFake inputReaderFake = new InputReaderFake();
            Command command = inputReaderFake.readInput(cmd);
            Command commandTest = new Command(ActionEnum.Create, "Acheter du pain");
            Assert.Equal(commandTest, command);

        }
        // We are going to write our first TU
        // We could test if commandReader is able to return string
        [Fact]
        public void CommandReader_CreateTask_Good()
        {
            CommandReaderFake commandReader = new CommandReaderFake();
            Command command = new Command(ActionEnum.Create, "Acheter du pain");
            Task task = commandReader.createTask(command);
            
            Task taskTest = new Task(0, "Acheter du pain");
            Assert.True(taskTest.Equals(task));
        }

        [Fact]
        public void ConsoleWrite_Write_Console()
        {
            string str = "test";
            ConsoleWriterMock consoleWriter = new ConsoleWriterMock();
            consoleWriter.write(str);
            Assert.Equal(1, consoleWriter.WriteIsCalled);
        }
        
    }
}