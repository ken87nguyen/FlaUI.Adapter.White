using FlaUI.Core;

namespace TestStack.White.UIItems
{
    public class TextBox : FlaUI.Core.AutomationElements.TextBox
    {
        public TextBox(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
        }

        public bool IsFocussed => false; // TODO: HYT 2021.12.15

        public bool Enabled => IsEnabled;
    }
}
