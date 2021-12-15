using TestStack.White.UIItems.WindowItems;

namespace TestStack.White.InputDevices
{
    public class AttachedMouse
    {
        private readonly Window container;

        internal AttachedMouse(Window container)
        {
            this.container = container;
        }

        // For WPF
#if !NETSTANDARD
        public void Click(System.Windows.Point clickPoint)
        {
            FlaUI.Core.Input.Mouse.LeftClick(new System.Drawing.Point((int)clickPoint.X, (int)clickPoint.Y));
        }
#endif

        // for Window form
        public void Click(System.Drawing.Point clickPoint)
        {
            FlaUI.Core.Input.Mouse.LeftClick(clickPoint);
        }

        public void DoubleClick(System.Drawing.Point clickPoint)
        {
            FlaUI.Core.Input.Mouse.DoubleClick(clickPoint);
        }
    }
}
