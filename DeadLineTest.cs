using Xunit;

namespace TDD2
{
    public class DeadLineTest
    {
        /**
         * Given I am a user 
         * When I send a command
         * And I indicate "deadline"; task id; date
         * Then should add a deadline to the task
         */
        [Fact]
        public void Acceptance_Test_Task_Deadline()
        {
            string cmd = "tasks deadline 0 2020-06-02";
            // No time to finish but here we need to refacto all test & create this acceptance test
        }
    }
}