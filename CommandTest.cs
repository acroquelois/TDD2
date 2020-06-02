using Xunit;

namespace TDD2
{
    public class CommandTest
    {
        public class TaskTest
        {

            [Fact]
            public void Test_Equals_OK()
            {
                Command command1 = new Command(ActionEnum.Create, "test");
                Command command2 = new Command(ActionEnum.Create, "test");
                Assert.True(command1.Equals(command2));
            }
        
            [Fact]
            public void Test_Equals_Fail_Action()
            {
                Command command1 = new Command(ActionEnum.Create, "test");
                Command command2 = new Command(ActionEnum.View, "test");
                Assert.False(command1.Equals(command2));
            }
        
            [Fact]
            public void Test_Equals_Fail_Msg()
            {
                Command command1 = new Command(ActionEnum.Create, "test1");
                Command command2 = new Command(ActionEnum.Create, "test");
                Assert.False(command1.Equals(command2));
            }
        }
    }
}