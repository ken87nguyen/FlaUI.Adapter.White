using System.Collections.Generic;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;

namespace TestStack.White.UIItems.TableItems
{
    public class Table : Grid
    {
        public Table(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
        }

        public bool Enabled => IsEnabled;

        public new List<TableRows> Rows => Rows;
    }
}
