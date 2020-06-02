using System;
using Xunit;

namespace TDD2
{
    public class ViewingTest
    {
        /**
         * Given I am a user 
         * When I send a command
         * And I indicate task that i want to see
         * Then I should receive message of indicated task
         */
        [Fact]
        public void Acceptance_Test_Task_Viewed()
        {
            string cmd = "tasks view 0";
            InputReaderFake inputReaderFake = new InputReaderFake();
            Command command = inputReaderFake.readInput(cmd);
            CommandReaderFake commandReaderFake = new CommandReaderFake();
            string str = commandReaderFake.viewTask(command);
            ConsoleWriterMock consoleWriter = new ConsoleWriterMock();
            Assert.Equal("Acheter du pain", str);
            //consoleWriter.write(str);
            //Assert.Equal(1, consoleWriter.WriteIsCalled); // I m not convinced by this final test yet
            
            // Acceptance TEst pass & unit test doesn't pass bad, very baddd
        }
        
        [Fact]
        public void InputReader_ReadInput_View_Good()
        {
            string cmd = "tasks view 0";
            InputReaderFake inputReaderFake = new InputReaderFake();
            Command command = inputReaderFake.readInput(cmd);
            Command commandTest = new Command(ActionEnum.View, "0");
            Assert.Equal(commandTest, command);
        }
        
        [Fact]
        public void CommandReader_ViewTask_Good()
        {
            CommandReaderFake commandReader = new CommandReaderFake();
            Command command = new Command(ActionEnum.View, "0");
            string str = commandReader.viewTask(command);
            string strCmp = "Acheter du pain";
            Assert.Equal(strCmp, str);
        }
    }
}