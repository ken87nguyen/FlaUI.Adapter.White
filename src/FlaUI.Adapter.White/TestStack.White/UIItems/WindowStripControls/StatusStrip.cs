using FlaUI.Core;
using FlaUI.Core.AutomationElements;

namespace TestStack.White.UIItems.WindowStripControls
{
    public class StatusStrip : AutomationElement
    {
        public StatusStrip(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
        }

        public StatusStrip(AutomationElement automationElement) : base(automationElement)
        {
        }

        public Label GetLabel(string automationId)
        {
            // TODO HYT 2021.12.15
            return null;
        }
    }
}
