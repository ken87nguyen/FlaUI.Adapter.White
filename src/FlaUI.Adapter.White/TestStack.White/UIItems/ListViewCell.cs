using FlaUI.Core;
using FlaUI.Core.AutomationElements;

namespace TestStack.White.UIItems
{
    public class ListViewCell : AutomationElement
    {
        public string Text { get; set; }

        public ListViewCell(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement) {
        }

        public ListViewCell(AutomationElement automationElement) : base(automationElement) {
        }
    }
}
