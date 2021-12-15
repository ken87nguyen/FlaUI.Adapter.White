using System.Diagnostics;
using System.Threading;
using TestStack.White.Factory;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace TestStack.White
{
    public class Application : FlaUI.Core.Application
    {
        public Application(int processId, bool isStoreApp = false) : base(processId, isStoreApp)
        {
        }

        public Application(Process process, bool isStoreApp = false) : base(process, isStoreApp)
        {
        }

        // TODO HYT 2021.12.15
        public Window GetWindow(SearchCriteria searchCriteria, InitializeOption initializeOption)
        {
            throw new AbandonedMutexException();
        }
    }
}
