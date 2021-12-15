using FlaUI.Core;
using TestStack.White.InputDevices;

namespace TestStack.White.UIItems
{
    public class UIItemContainer : WindowItems.Window
    {
        public UIItemContainer(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
        }

        public virtual AttachedKeyboard Keyboard
        {
            get
            {
                return new AttachedKeyboard(this);
            }
        }

        /// <summary>
        /// Returns a mouse which is associated to this window. 
        /// Any operation performed using the mouse would wait till the window is busy after this operation. 
        /// Before any operation is performed the window is brought to focus.
        /// </summary>
        public virtual AttachedMouse Mouse
        {
            get { return new AttachedMouse(this); }
        }
    }
}
