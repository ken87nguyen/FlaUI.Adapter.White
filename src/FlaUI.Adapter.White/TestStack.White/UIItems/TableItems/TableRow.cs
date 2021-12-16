using System.Collections.Generic;
using System.Linq;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;

namespace TestStack.White.UIItems.TableItems
{
    public class TableRow : GridRow
    {

        private TableCell cells;
        private readonly FrameworkAutomationElementBase _frameworkAutomationElement;

        public TableRow(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
            _frameworkAutomationElement = frameworkAutomationElement;
        }

        public TableCell Cells
        {
            get
            {
                if (cells == null)
                {
                    cells = TableCellFactory.CreateCells(this, _frameworkAutomationElement);
                }

                return cells;
            }
        }

        public List<TableCell> CellList => base.Cells.Cast<TableCell>().ToList();
    }
}
