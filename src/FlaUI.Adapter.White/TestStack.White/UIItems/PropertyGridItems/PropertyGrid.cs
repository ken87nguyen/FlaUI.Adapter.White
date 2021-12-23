using System.Collections.Generic;
using FlaUI.Core;
using TestStack.White.UIItems.Finders;
using AutomationElement = FlaUI.Core.AutomationElements.AutomationElement;

namespace TestStack.White.UIItems.PropertyGridItems
{
    // TODO [#17 | # | Open]
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

        /// <summary>
        /// TODO HYT 2021.12.15
        /// Provides a list of categories in the property grid.
        /// </summary>
        public virtual List<PropertyGridCategory> Categories
        {
            get => null;
        }

        public bool Enabled => IsEnabled;
    }
}
