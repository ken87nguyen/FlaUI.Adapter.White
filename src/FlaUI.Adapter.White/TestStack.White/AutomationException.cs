using System;
using System.Collections.Generic;
using System.Text;

namespace TestStack.White
{
    public class AutomationException : Exception
    {
        public AutomationException(string message, string debugDetails)
            : base(message)
        {
            DebugDetails = debugDetails;
        }

        public AutomationException(string message, string debugDetails, Exception innerException)
            : base(message, innerException)
        {
            DebugDetails = debugDetails;
        }

        /// <summary>
        /// Contains the current UI Automation tree
        /// </summary>
        public virtual string DebugDetails { get; private set; }
    }
}
