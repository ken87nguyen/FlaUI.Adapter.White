using System.Drawing;
using FlaUI.Core;
using FlaUI.Core.Definitions;

namespace TestStack.White.UIItems
{
    // TODO [#3 | # | Open]
    public class Button : FlaUI.Core.AutomationElements.Button
    {

        public Button(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
        }

        public bool Enabled => IsEnabled;

        public Bitmap VisibleImage => null; // TODO

        public bool Visible => base.IsAvailable;

        public bool IsFocussed => false; // TODO: 2021.12.15

        public string Text => base.Name;

        // TODO
        public ToggleState State
        {
            get;
            set;
        }
    }
}
