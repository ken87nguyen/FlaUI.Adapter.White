using System.Drawing;
using FlaUI.Core;

namespace TestStack.White.UIItems
{
    // TODO HYT 2021.12.15
    public class Button : FlaUI.Core.AutomationElements.Button
    {

        public Button(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
        }

        public bool Enabled => IsEnabled;

        public Bitmap VisibleImage => null; // TODO

        public bool Visible => base.IsAvailable;

        public bool IsFocussed => false; // TODO: 2021.12.15
    }
}
