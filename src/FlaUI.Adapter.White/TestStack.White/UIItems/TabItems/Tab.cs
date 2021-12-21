using System.Collections.Generic;
using System.Linq;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;

namespace TestStack.White.UIItems.TabItems
{
    public class Tab : FlaUI.Core.AutomationElements.Tab
    {
        public Tab(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
        }

        public int TabCount => base.TabItems.Length;

        public List<TabItem> Pages => base.TabItems.ToList();

        public void SelectTabPage(string tabName)
        {
            // TODO HYT 2021.12.15
        }

        public void SelectTabPage(int tabName)
        {
            // TODO HYT 2021.12.15
        }

        public TabItem SelectedTab => base.SelectedTabItem;
    }
}
