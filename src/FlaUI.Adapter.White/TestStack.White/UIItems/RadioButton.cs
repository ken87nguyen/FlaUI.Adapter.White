using FlaUI.Core;

namespace TestStack.White.UIItems
{
    public class RadioButton : FlaUI.Core.AutomationElements.RadioButton
    {
        public RadioButton(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
        }

        public bool IsSelected
        {
            get => base.IsChecked;
            set => base.IsChecked = value;
        }

        public void Select()
        {
            Click();
        }
    }
}
