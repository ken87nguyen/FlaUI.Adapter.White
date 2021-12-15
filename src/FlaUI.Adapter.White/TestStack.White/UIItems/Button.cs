using FlaUI.Core;

namespace TestStack.White.UIItems
{
    public class Button : FlaUI.Core.AutomationElements.Button
    {

        public Button(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
        }

        public bool Enabled => IsEnabled;

        public bool IsFocussed => false; // TODO: 2021.12.15
    }
}
