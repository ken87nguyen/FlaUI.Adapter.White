using System.Collections.Generic;
using System.Linq;
using FlaUI.Core;

namespace TestStack.White.UIItems.TreeItems
{
    public class Tree : FlaUI.Core.AutomationElements.Tree
    {
        public Tree(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement) {
        }

        public List<TreeNode> Nodes => base.Items.Cast<TreeNode>().ToList();
    }
}
