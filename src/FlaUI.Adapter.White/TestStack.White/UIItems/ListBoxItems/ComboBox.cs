using FlaUI.Core;

namespace TestStack.White.UIItems.ListBoxItems
{
    public class ComboBox : FlaUI.Core.AutomationElements.ComboBox
    {
        public ComboBox(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
        }

        public bool Enabled => IsEnabled;

        public string SelectedItemText => SelectedItem.Text;
    }
}
