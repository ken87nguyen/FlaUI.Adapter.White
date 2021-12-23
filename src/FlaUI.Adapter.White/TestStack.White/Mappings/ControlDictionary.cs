using System;
using System.Collections.Generic;
using System.Linq;
using FlaUI.Adapter.White.Resources;
using FlaUI.Core.Definitions;
using FlaUI.Core.Exceptions;
using TestStack.White.UIItems;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.TableItems;
using TestStack.White.UIItems.TabItems;
using TestStack.White.UIItems.WindowStripControls;
using TestStack.White.UIItems.TreeItems;
using TestStack.White.UIItems.ListBoxItems;

namespace TestStack.White.Mappings
{
    public class ControlDictionary
    {
        public static readonly ControlDictionary Instance = new ControlDictionary();
        private readonly ControlDictionaryItems items = new ControlDictionaryItems();

        private ControlDictionary()
        {
            items.AddPrimary(typeof(Button), ControlType.Button);
            items.AddPrimary(typeof(CheckBox), ControlType.CheckBox);
            items.AddPrimary(typeof(ListBox), ControlType.List);
            items.AddPrimary(typeof(Tree), ControlType.Tree);
            items.AddPrimary(typeof(RadioButton), ControlType.RadioButton);
            items.AddPrimary(typeof(Table), ControlType.Table);
            items.AddPrimary(typeof(Tab), ControlType.Tab, true);
            items.AddPrimary(typeof(ListView), ControlType.DataGrid);
            items.AddPrimary(typeof(ToolStrip), ControlType.ToolBar);
            items.AddPrimary(typeof(Spinner), ControlType.Spinner);
            items.AddPrimary(typeof(TextBox), ControlType.Edit);

            items.AddSecondary(typeof(TableRow), ControlType.Custom);
            items.AddSecondary(typeof(Menu), ControlType.MenuItem);
            items.AddSecondary(typeof(ListViewRow), ControlType.DataItem);
        }

        public virtual ControlType[] GetControlType(Type testControlType)
        {
            var controlDictionaryItem = items.FindBy(testControlType);
            if (controlDictionaryItem == null)
                throw new ElementNotAvailableException(string.Format(MessageResources.Common_CanNotFindForThing, testControlType.Name, nameof(ControlDictionary)));
            return controlDictionaryItem.Select(c => c.ControlType).ToArray();
        }
    }
}
