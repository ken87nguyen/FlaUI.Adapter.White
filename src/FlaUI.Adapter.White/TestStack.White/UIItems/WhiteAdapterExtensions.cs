using System.Collections.Generic;
using System.Linq;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Conditions;
using FlaUI.Core.Definitions;
using FlaUI.Core.Input;
using FlaUI.Core.WindowsAPI;
using TestStack.White.UIItems.Finders;
using TestStack.White.WindowsAPI;

namespace TestStack.White.UIItems
{
    // TODO [#12 | # | Open]
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

        public static T Get<T>(this AutomationElement element) where T : AutomationElement
        {
            return Get(element, SearchCriteria.All).As<T>();
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

        public static AutomationElement GetElement(this AutomationElement element, SearchCriteria searchCriteria) {
            return element.Get(searchCriteria);
        }

        public static AutomationElement Get(this AutomationElement element, ConditionBase condition)
        {
            var foundElement = element.FindFirstDescendant(condition);
            return foundElement;
        }

        public static bool Exists<T>(this AutomationElement element, string name) where T : AutomationElement
        {
            return Get<T>(element, element.ConditionFactory.ByName(name)) != null;
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

        // TODO [#12 | VTQ | Open]
        public static void HoldKey<T>(this T element, KeyboardInput.SpecialKeys key)
        {
            // TODO HYT 2021.12.15
            Keyboard.Press((VirtualKeyShort)key);
        }

        // TODO [#12 | VTQ | Open]
        public static void LeaveKey<T>(this T element, KeyboardInput.SpecialKeys key)
        {
            // TODO HYT 2021.12.15
            Keyboard.Release((VirtualKeyShort)key);
        }

        public static List<WindowItems.Window> GetWindows(this Application application)
        {
            // TODO
            return null;
        }

        public static WindowItems.Window ModalWindow(this WindowItems.Window parent, string title)
        {
            var cf = parent.ConditionFactory;
            return parent.FindFirstDescendant(cf.ByControlType(ControlType.Window).And(cf.ByName(title))).AsWindow() as UIItems.WindowItems.Window;
        }

        public static WindowItems.Window ModalWindow(this WindowItems.Window parent, SearchCriteria searchCriteria)
        {
            return parent.Get(searchCriteria.ToCondition()).AsWindow() as WindowItems.Window;
        }

        public static UIItemContainer MdiChild(this WindowItems.Window parent, SearchCriteria searchCriteria)
        {
            return parent.Get(searchCriteria) as UIItemContainer;
        }

        public static AutomationElement[] GetMultiple(this WindowItems.Window parent, SearchCriteria searchCriteria) {
            return parent.FindAllDescendants(searchCriteria.ToCondition());
        }

        public static AutomationElement[] GetMultiple(this AutomationElement parent, SearchCriteria searchCriteria)
        {
            return parent.FindAllDescendants(searchCriteria.ToCondition());
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
