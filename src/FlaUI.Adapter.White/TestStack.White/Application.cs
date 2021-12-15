using System.Diagnostics;

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
    }
}
