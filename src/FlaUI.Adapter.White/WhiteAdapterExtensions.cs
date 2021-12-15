﻿using System.Linq;
using FlaUI.Adapter.White;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Conditions;
using FlaUI.Core.Definitions;
using FlaUI.Core.Input;
using FlaUI.Core.WindowsAPI;
using TestStack.White.UIItems.Finders;
using TestStack.White.WindowsAPI;

namespace TestStack.White
{
    public static class WhiteAdapterExtensions
    {
        public static T Get<T>(this AutomationElement element, string name) where T : AutomationElement
        {
            return Get<T>(element, element.ConditionFactory.ByName(name));
        }

        public static T Get<T>(this AutomationElement element, SearchCriteria searchCriteria) where T : AutomationElement
        {
            return Get(element, searchCriteria).As<T>();
        }

        public static T Get<T>(this AutomationElement element, ConditionBase condition) where T : AutomationElement
        {
            return Get(element, condition).As<T>();
        }

        public static AutomationElement Get(this AutomationElement element, SearchCriteria searchCriteria)
        {
            var condition = searchCriteria.ToCondition();
            if (searchCriteria.IsIndexed)
            {
                var allItems = element.FindAllDescendants(condition);
                if (allItems.Length >= searchCriteria.Index)
                {
                    return allItems[searchCriteria.Index];
                }
                return null;
            }
            return Get(element, condition);
        }

        public static AutomationElement Get(this AutomationElement element, ConditionBase condition)
        {
            var foundElement = element.FindFirstDescendant(condition);
            return foundElement;
        }

        public static void Enter<T>(this T element, string text)
        {
            Keyboard.Type(text);
        }

        public static void KeyIn<T>(this T element, KeyboardInput.SpecialKeys key)
        {
            Keyboard.Press((VirtualKeyShort)key);
        }

        public static void PressSpecialKey<T>(this T element, KeyboardInput.SpecialKeys key)
        {
            Keyboard.Press((VirtualKeyShort)key);
        }


        public static UIItems.WindowItems.Window ModalWindow(this UIItems.WindowItems.Window parent, string title)
        {
            var cf = parent.ConditionFactory;
            return parent.FindFirstDescendant(cf.ByControlType(ControlType.Window).And(cf.ByName(title))).AsWindow() as UIItems.WindowItems.Window;
        }

        public static UIItems.WindowItems.Window GetWindow(this Application application, string title)
        {
            return application.GetAllTopLevelWindows(WhiteAdapter.Automation).FirstOrDefault(x => x.Title == title) as UIItems.WindowItems.Window;
        }

        public static ListBox Check(this ListBox listBox, string itemText)
        {
            return listBox.SetCheck(itemText, true);
        }

        public static ListBox UnCheck(this ListBox listBox, string itemText)
        {
            return listBox.SetCheck(itemText, false);
        }

        private static ListBox SetCheck(this ListBox listBox, string itemText, bool isChecked)
        {
            var item = listBox.Items.FirstOrDefault(x => x.Text == itemText);
            if (item != null)
            {
                item.IsChecked = isChecked;
            }
            return listBox;
        }
    }
}
