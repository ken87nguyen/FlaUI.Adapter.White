using FlaUI.Core.AutomationElements;

namespace TestStack.White.UIItems.Finders
{
    public class SearchControlFactory
    {


        public static T CreateForControl<T>(AutomationElement element) where T : AutomationElement
        {
            if (typeof(T) == typeof(TextBox))
            {
                return new TextBox(element.FrameworkAutomationElement) as T;
            }
            if (typeof(T) == typeof(Button))
            {
                return new Button(element.FrameworkAutomationElement) as T;
            }

            return element as T;
        }

        public static void EnterByControl(AutomationElement element, string text)
        {
            if (element.GetType() == typeof(TextBox))
            {
                var textBox = (TextBox)element;
                textBox.SetValue(text);
            }
            if (element.GetType() == typeof(ComboBox))
            {
                var textBox = (ComboBox)element;
                textBox.Select(text);
            }
        }
    }
}
