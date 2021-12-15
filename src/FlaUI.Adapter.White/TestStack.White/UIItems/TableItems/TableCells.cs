
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

        public Rectangle Bounds => BoundingRectangle;
    }
}
