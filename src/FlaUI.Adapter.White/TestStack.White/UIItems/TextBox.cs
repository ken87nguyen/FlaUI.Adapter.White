using System.Drawing;
using FlaUI.Core;

namespace TestStack.White.UIItems
{
    // TODO [#10 | # | Open]
    public class TextBox : FlaUI.Core.AutomationElements.TextBox
    {
        public TextBox(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
        }

        public FrameworkAutomationElementBase AutomationElement => base.FrameworkAutomationElement;
        public bool IsFocussed => false; // TODO: HYT 2021.12.15

        public bool Enabled => IsEnabled;

        public Bitmap VisibleImage => null; // TODO

        public bool Visible => base.IsAvailable;

        // TODO
        public void SetValue(string text) {
            base.Enter(text);
        }

        public Rectangle Bounds => base.BoundingRectangle;

        public string Id => base.AutomationId;
    }
}
