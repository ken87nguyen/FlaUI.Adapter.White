using FlaUI.Core;

namespace TestStack.White.UIItems.TableItems
{
    public class TableCellFactory
    {
        public static TableCell CreateCells(TableRow tableRow,
            FrameworkAutomationElementBase frameworkAutomationElement)
        {
            
            return new TableCell(tableRow, frameworkAutomationElement);
        }
    }
}
