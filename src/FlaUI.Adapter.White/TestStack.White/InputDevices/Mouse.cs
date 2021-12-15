using System.Drawing;

namespace TestStack.White.InputDevices
{
    public class Mouse
    {
        public static Mouse Instance => new Mouse();

        public void DoubleClick(Point clickPoint)
        {
            FlaUI.Core.Input.Mouse.DoubleClick(clickPoint);
        }
    }
}
