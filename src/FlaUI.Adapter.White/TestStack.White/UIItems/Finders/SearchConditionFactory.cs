using System;
using System.Linq;
using FlaUI.Core.Definitions;
using TestStack.White.Mappings;

namespace TestStack.White.UIItems.Finders
{
    public class SearchConditionFactory
    {
        public static ControlType CreateForControlType(Type testControlType)
        {
              return ControlDictionary.Instance.GetControlType(testControlType).FirstOrDefault();
        }
    }
}
