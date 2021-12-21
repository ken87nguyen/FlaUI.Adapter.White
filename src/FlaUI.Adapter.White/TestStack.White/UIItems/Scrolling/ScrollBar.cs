using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.AutomationElements.Scrolling;

namespace TestStack.White.UIItems.Scrolling
{
    public class ScrollBar : AutomationElement
    {
        public ScrollBar(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement) {
            Vertical = new VerticalScrollBar(frameworkAutomationElement);
            Horizontal = new HorizontalScrollBar(frameworkAutomationElement);
        }

        public VerticalScrollBar Vertical
        {
            get;
            private set;
        }

        public HorizontalScrollBar Horizontal
        {
            get;
            private set;
        }
    }
}
