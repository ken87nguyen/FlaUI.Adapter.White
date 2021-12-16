
using System.Drawing;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;

namespace TestStack.White.UIItems.TableItems
{
    public class TableCells : GridCell
    {
        public TableCells(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
        }

        public bool IsFocussed => false; // TODO HYT 2021.12.15

        public Rectangle Bounds => BoundingRectangle;
    }
}
