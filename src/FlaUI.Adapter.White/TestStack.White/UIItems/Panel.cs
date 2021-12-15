using FlaUI.Core;
using FlaUI.Core.AutomationElements;

namespace TestStack.White.UIItems
{
    public class Panel : AutomationElement
    {
        public Panel(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
        }

        public Panel(AutomationElement automationElement) : base(automationElement)
        {
        }
    }
}
