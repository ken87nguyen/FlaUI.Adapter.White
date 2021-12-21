﻿using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using FlaUI.Core;
using TestStack.White.InputDevices;
using TestStack.White.UIItems.WindowStripControls;

namespace TestStack.White.UIItems.WindowItems
{
    public class Window : FlaUI.Core.AutomationElements.Window
    {
        public Window(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
        }

        // TODO HYT 2021.12.15
        public MenuBar MenuBar { get; set; }

        public List<Window> ModalWindows()
        {
            return base.ModalWindows.Cast<Window>().ToList();
        }

        public Rectangle Bounds => BoundingRectangle;

        public virtual AttachedKeyboard Keyboard
        {
            get
            {
                return new AttachedKeyboard(this);
            }
        }

        //TODO
        public DisplayState DisplayState
        {
            get;
            set;
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

        public bool IsOffScreen => base.IsOffscreen;

        public bool IsCurrentlyActive => base.IsAvailable;

        public void WaitWhileBusy()
        {
            // TODO
        }

        public void ReloadIfCached()
        {
            // TODO
        }

        public bool Visible => base.IsAvailable;
    }
}
