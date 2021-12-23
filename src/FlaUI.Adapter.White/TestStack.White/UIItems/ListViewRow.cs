using System.Collections.Generic;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;

namespace TestStack.White.UIItems
{
    // TODO [#9 | # | Open]
    public class ListViewRow : ListBoxItem
    {
        public List<ListViewCell> Cells { get; set; }
        public ListViewRow(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
            Cells = new List<ListViewCell>();
            Cells.Add(new ListViewCell(frameworkAutomationElement)
            {
                Text = Text
            });
        }

        public bool IsKeyboardFocusable => true; //TODO
        public void MultiSelect()
        {
            // TODO: HYT 2021.12.21
        }

        public string Id => base.AutomationId;
    }
}
