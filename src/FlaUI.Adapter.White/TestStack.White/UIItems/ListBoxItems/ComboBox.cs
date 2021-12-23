using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;

namespace TestStack.White.UIItems.ListBoxItems
{
    // TODO [#18 | # | Open]
    public class ComboBox : FlaUI.Core.AutomationElements.ComboBox
    {
        public ComboBox(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
        }

        public bool Enabled => IsEnabled;

        public bool IsFocussed => false; // TODO HYT 2021.12.15

        public string SelectedItemText => SelectedItem.Text;
        public Bitmap VisibleImage => null; // TODO

        public List<ComboBoxItem> Items => base.Items.ToList();
    }
}
