using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.AutomationElements.Scrolling;

namespace TestStack.White.UIItems.Scrolling
{
    // TODO [#16 | # | Open]
    public class ScrollBar : AutomationElement
    {
        public ScrollBar(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement) {
            Vertical = new VerticalScrollBar(frameworkAutomationElement);
            Horizontal = new HorizontalScrollBar(frameworkAutomationElement);
        }

        // TODO
        public VerticalScrollBar Vertical
        {
            get;
            private set;
        }

        // TODO
        public HorizontalScrollBar Horizontal
        {
            get;
            private set;
        }
    }
}
