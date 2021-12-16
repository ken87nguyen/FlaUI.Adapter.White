using System;
using FlaUI.Core;

namespace TestStack.White.UIItems.WindowStripControls
{
    // TODO HYT 2021.12.15
    public class MenuBar : FlaUI.Core.AutomationElements.AutomationElement
    {
        public MenuBar(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
        }

        public MenuBar(FlaUI.Core.AutomationElements.AutomationElement automationElement) : base(automationElement)
        {
        }

        public MenuItems.Menu MenuItem(params string[] path)
        {
            throw new Exception();
        }

        public bool Enabled => IsEnabled;
    }
}
