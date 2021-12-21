using System.Drawing;
using FlaUI.Core.Input;

namespace TestStack.White.InputDevices
{
    public class Mouse
    {
        public static Mouse Instance => new Mouse();

        public void DoubleClick(Point clickPoint)
        {
            FlaUI.Core.Input.Mouse.DoubleClick(clickPoint);
        }

        public void RightClick()
        {
            FlaUI.Core.Input.Mouse.RightClick();
        }

        // For WPF
#if !NETSTANDARD
        public void Click(System.Windows.Point clickPoint)
        {
            FlaUI.Core.Input.Mouse.LeftClick(new System.Drawing.Point((int)clickPoint.X, (int)clickPoint.Y));
        }

        public void RightClick(System.Windows.Point clickPoint)
        {
            FlaUI.Core.Input.Mouse.RightClick(new System.Drawing.Point((int)clickPoint.X, (int)clickPoint.Y));
        }
#endif

        // for Window form
        public void Click(System.Drawing.Point clickPoint)
        {
            FlaUI.Core.Input.Mouse.LeftClick(clickPoint);
        }
    }
}
