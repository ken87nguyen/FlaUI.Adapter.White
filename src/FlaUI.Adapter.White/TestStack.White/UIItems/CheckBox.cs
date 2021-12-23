using FlaUI.Core;

namespace TestStack.White.UIItems
{  
    // TODO [#4 | VTQ | Open]
    public class CheckBox : FlaUI.Core.AutomationElements.CheckBox
    {
        public CheckBox(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
        }

        public bool Checked
        {
            get => IsChecked ?? false;
            set => IsChecked = value;
        }

        public bool IsSelected
        {
            get => IsChecked ?? false;
            set => IsChecked = value;
        }

        public bool Enabled => IsEnabled;

        public bool IsFocussed => false; // TODO

        public void Select() {
            // TODO
        }

        public void UnSelect()
        {
            // TODO
        }
    }
}
