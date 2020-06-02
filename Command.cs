using System;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace TDD2
{
    public class Command
    {
        public Command(ActionEnum action, string param)
        {
            Action = action;
            Param = param;
        }
        public ActionEnum Action { get; set; }
        public string Param { get; set; }
        
        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;
            else
            {
                Command cmpMsg = (Command) obj;
                return Action == cmpMsg.Action &&
                       Param == cmpMsg.Param;
            }
        }
    }
}