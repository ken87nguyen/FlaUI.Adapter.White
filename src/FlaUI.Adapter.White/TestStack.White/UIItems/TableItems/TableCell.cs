
using System;
using System.Drawing;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Exceptions;

namespace TestStack.White.UIItems.TableItems
{
    // TODO [#14 | # | Open]
    public class TableCell : GridCell
    {
        private readonly TableRow _tableRow;
        public TableCell(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
        }

        public TableCell(TableRow tableRow,
            FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
            _tableRow = tableRow;
        }

        public TableCell this[string columnName]
        {
            get
            {
                if (_tableRow == null && String.IsNullOrEmpty(columnName))
                {
                    return this;
                }

                if (_tableRow == null)
                {
                    throw  new FlaUIException(String.Format("Cannot get cell for {0}", columnName));
                }

                return _tableRow.FindCellByText(columnName) as TableCell;
            }
        }

        public TableCell this[int columnIndex]
        {
            get
            {
                
                if (_tableRow == null)
                {
                    throw new FlaUIException(String.Format("Cannot get cell for {0}", columnIndex));
                }

                return _tableRow.CellList[columnIndex];
            }
        }

        public bool IsFocussed => false; // TODO HYT 2021.12.15

        public Rectangle Bounds => BoundingRectangle;
    }
}
