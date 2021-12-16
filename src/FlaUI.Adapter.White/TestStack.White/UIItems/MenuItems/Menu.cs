using FlaUI.Core;

namespace TestStack.White.UIItems.MenuItems
{
    public class Menu : FlaUI.Core.AutomationElements.Menu
    {
        public Menu(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
        }

        public bool Enabled => IsEnabled;
    }
}
