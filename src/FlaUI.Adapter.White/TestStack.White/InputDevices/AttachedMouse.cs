using System.Drawing;
using FlaUI.Core.Input;
using TestStack.White.UIItems;

namespace TestStack.White.InputDevices
{
    public class AttachedMouse
    {
        private readonly UIItemContainer container;

        internal AttachedMouse(UIItemContainer container)
        {
            this.container = container;
        }

        // For WPF
        public void Click(double x, double y)
        {
            Mouse.LeftClick(new Point((int)x, (int)y));
        }

        // for Window form
        public void Click(Point clickPoint)
        {
            Mouse.LeftClick(clickPoint);
        }

        public void DoubleClick(Point clickPoint)
        {
            Mouse.DoubleClick(clickPoint);
        }
    }
}
