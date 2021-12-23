
using System.Collections.Generic;
using System.Linq;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;

namespace TestStack.White.UIItems.ListBoxItems
{
    // TODO [#15 | # | Open]
    public class ListBox : FlaUI.Core.AutomationElements.ListBox
    {
        public ListBox(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
        }

        public ListBoxItem Item(string itemText)
        {
            return base.Select(itemText);
        }

        public List<ListItem> Items => base.Items.Cast<ListItem>().ToList();

        public string SelectedItemText => base.SelectedItem.Text;
    }
}
