using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;

namespace TestStack.White.UIItems.TableItems
{
    // TODO [#13 | # | Open]
    public class Table : Grid
    {
        public Table(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
        }

        public bool Enabled => base.IsEnabled;

        public bool Visible => base.IsAvailable;

        public Bitmap VisibleImage => null; // TODO

        public new List<TableRow> Rows => base.Rows.Cast<TableRow>().ToList();

        public void Refresh()
        {
            // TODO
        }
    }
}
