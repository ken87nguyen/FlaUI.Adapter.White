using FlaUI.Core;
using FlaUI.Core.AutomationElements;

namespace TestStack.White.UIItems.TableItems
{
    public class TableRows : GridRow
    {
        public TableRows(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
        }

        public new TableCells[] Cells => Cells;

        

        public new TableCells FindCellByText(string columnName)
        {
            return FindCellByText(columnName) as TableCells;
        }
    }
}
