using FlaUI.Core.AutomationElements;

namespace FlaUI.Adapter.White.TestStack.White
{
    public class Enabled
    {
        public bool this[AutomationElement automationElement] => automationElement.IsEnabled;
    }
}
