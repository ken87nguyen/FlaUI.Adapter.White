using FlaUI.Core;

namespace TestStack.White.UIItems.Custom
{
    public class CustomUIItem : UIItem
    {
        private UIItemContainer container;

        public CustomUIItem(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement) {
        }

        // TODO HYT 2021.12.20
        protected virtual UIItemContainer Container
        {
            get
            {
                return this.container;
            }
        }
    }
}
