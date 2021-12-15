using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using TestStack.White.UIItems.Finders;

namespace TestStack.White.UIItems.PropertyGridItems
{
    public class PropertyGrid : AutomationElement
    {
        public PropertyGrid(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
        }

        public PropertyGrid(AutomationElement automationElement) : base(automationElement)
        {
        }

        public AutomationElement GetElement(SearchCriteria searchCriteria)
        {
            // TODO: HYT 2021.12.15
            return this;
        }
    }
}
