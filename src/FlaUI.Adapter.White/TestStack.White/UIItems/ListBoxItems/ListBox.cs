﻿
using System.Linq;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;

namespace TestStack.White.UIItems.ListBoxItems
{
    public class ListBox : FlaUI.Core.AutomationElements.ListBox
    {
        public ListBox(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
        }

        public ListBoxItem Item(string itemText)
        {
            return base.Select(itemText);
        }
    }
}
