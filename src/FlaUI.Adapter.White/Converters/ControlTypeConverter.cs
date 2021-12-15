using System;
using FlaUI.Core.Definitions;

namespace FlaUI.Adapter.White.Converters
{
    public static class FlaUIControlTypeConverter
    {
#if !NETSTANDARD
        public static object ToFlaUIControlType(object windowsControlType)
        {
            var controlType = windowsControlType as System.Windows.Automation.ControlType;

            if (Equals(controlType, System.Windows.Automation.ControlType.Button))
            {
                return ControlType.Button;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.Calendar))
            {
                return ControlType.Calendar;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.CheckBox))
            {
                return ControlType.CheckBox;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.ComboBox))
            {
                return ControlType.ComboBox;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.Custom))
            {
                return ControlType.Custom;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.DataGrid))
            {
                return ControlType.DataGrid;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.DataItem))
            {
                return ControlType.DataItem;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.Document))
            {
                return ControlType.Document;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.Edit))
            {
                return ControlType.Edit;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.Group))
            {
                return ControlType.Group;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.Header))
            {
                return ControlType.Header;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.HeaderItem))
            {
                return ControlType.HeaderItem;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.Hyperlink))
            {
                return ControlType.Hyperlink;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.Image))
            {
                return ControlType.Image;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.List))
            {
                return ControlType.List;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.ListItem))
            {
                return ControlType.ListItem;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.MenuBar))
            {
                return ControlType.MenuBar;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.Menu))
            {
                return ControlType.Menu;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.MenuItem))
            {
                return ControlType.MenuItem;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.Pane))
            {
                return ControlType.Pane;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.ProgressBar))
            {
                return ControlType.ProgressBar;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.RadioButton))
            {
                return ControlType.RadioButton;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.ScrollBar))
            {
                return ControlType.ScrollBar;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.Separator))
            {
                return ControlType.Separator;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.Slider))
            {
                return ControlType.Slider;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.Spinner))
            {
                return ControlType.Spinner;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.SplitButton))
            {
                return ControlType.SplitButton;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.StatusBar))
            {
                return ControlType.StatusBar;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.Tab))
            {
                return ControlType.Tab;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.TabItem))
            {
                return ControlType.TabItem;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.Table))
            {
                return ControlType.Table;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.Text))
            {
                return ControlType.Text;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.Thumb))
            {
                return ControlType.Thumb;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.TitleBar))
            {
                return ControlType.TitleBar;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.ToolBar))
            {
                return ControlType.ToolBar;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.ToolTip))
            {
                return ControlType.ToolTip;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.Tree))
            {
                return ControlType.Tree;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.TreeItem))
            {
                return ControlType.TreeItem;
            }
            if (Equals(controlType, System.Windows.Automation.ControlType.Window))
            {
                return ControlType.Window;
            }
            throw new ArgumentOutOfRangeException(nameof(windowsControlType));
        }
#endif
    }
}
