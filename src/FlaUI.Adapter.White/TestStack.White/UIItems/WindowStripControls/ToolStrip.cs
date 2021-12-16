using FlaUI.Core;
namespace TestStack.White.UIItems.WindowStripControls
{
    public class ToolStrip : FlaUI.Core.AutomationElements.AutomationElement
    {
        public ToolStrip(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
        }

        public ToolStrip(FlaUI.Core.AutomationElements.AutomationElement automationElement) : base(automationElement)
        {
        }
        public MenuItems.Menu MenuItem(params string[] path)
        {
            // TODO HYT 2021.12.15
            return null;
        }

        public Label GetLabel(string automationId)
        {
            // TODO HYT 2021.12.15
            return null;
        }
    }
}
