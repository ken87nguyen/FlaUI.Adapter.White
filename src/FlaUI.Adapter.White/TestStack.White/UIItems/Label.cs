using System.Drawing;
using FlaUI.Core;

namespace TestStack.White.UIItems
{
    public class Label : FlaUI.Core.AutomationElements.Label
    {
        public Label(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
        }

        public bool Visible => base.IsAvailable;
        public Rectangle Bounds => base.BoundingRectangle;
        public bool Enabled => base.IsEnabled;
    }
}
