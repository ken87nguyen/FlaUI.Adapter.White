using System.Collections.Generic;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;

namespace FlaUI.Adapter.White.TestStack.White.UIItems
{
    public class ListViewRow : ListBoxItem
    {
        public List<ListViewCell> Cells { get; set; }
        public ListViewRow(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
            Cells = new List<ListViewCell>();
            Cells.Add(new ListViewCell
            {
                Text = Text
            });
        }

        
    }
}
