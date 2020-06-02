using System;

namespace TDD2
{
    public class Task
    {
        //Need method to test equality of Task
        public Task(int id, string message, DateTime deadline)
        {
            Id = id;
            Message = message;
            DeadLine = deadline;
        }

        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime DeadLine { get; set; }

        //TO TEST
        public string getId()
        {
            return "ID: " + Id;
        }
        
        //TO TEST
        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;
            else
            {
                Task cmpMsg = (Task) obj;
                return Id == cmpMsg.Id &&
                       Message == cmpMsg.Message &&
                       DeadLine.Equals(cmpMsg.DeadLine);
            }
        }
    }
}