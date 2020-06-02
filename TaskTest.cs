using Xunit;

namespace TDD2
{
    public class TaskTest
    {
        [Fact]
        public void Test_GetId()
        {
            Task task = new Task( 0, "msg test");
            task.Id = 0;
            Assert.Equal("ID: 0", task.getId());
        }

        [Fact]
        public void Test_Equals_OK()
        {
            Task task1 = new Task( 0, "msg test");
            Task task2 = new Task(0, "msg test");
            Assert.True(task1.Equals(task2));
        }
        
        [Fact]
        public void Test_Equals_Fail_Id()
        {
            Task task1 = new Task(0, "msg test");
            Task task2 = new Task(1, "msg test");
            Assert.False(task1.Equals(task2));
        }
        
        [Fact]
        public void Test_Equals_Fail_Msg()
        {
            Task task1 = new Task(0, "msg");
            Task task2 = new Task(0, "msg test");
            Assert.False(task1.Equals(task2));
        }
    }
}