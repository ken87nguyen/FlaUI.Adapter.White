using System.Collections.Generic;
using System.Linq;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;

namespace TestStack.White.UIItems
{
    public class ListView : ListBox
    {
        public ListView(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
        }

        public List<ListViewRow> Rows => Items.Cast<ListViewRow>().ToList();
    }
}
