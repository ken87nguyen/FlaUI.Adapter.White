using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using TestStack.White.UIItems.Scrolling;

namespace TestStack.White.UIItems
{
    public class ListView : ListBox
    {
        public ListView(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
            ScrollBars = new ScrollBar(FrameworkAutomationElement);
        }

        public List<ListViewRow> Rows => Items.Cast<ListViewRow>().ToList();

        public bool Enabled => base.IsEnabled;

        public Scrolling.ScrollBar ScrollBars
        {
            get;
            private set;
        }

        public Rectangle Bounds => base.BoundingRectangle;
    }
}
