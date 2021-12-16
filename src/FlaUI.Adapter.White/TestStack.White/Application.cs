using System;
using System.Diagnostics;
using TestStack.White.Factory;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace TestStack.White
{
    // TODO HYT 2021.12.15
    public class Application : FlaUI.Core.Application
    {
        public Application(int processId, bool isStoreApp = false) : base(processId, isStoreApp)
        {
        }

        public Application(Process process, bool isStoreApp = false) : base(process, isStoreApp)
        {
        }

        public Window GetWindow(SearchCriteria searchCriteria, InitializeOption initializeOption)
        {
            throw new Exception();
        }

        public Window GetWindow(string title)
        {
            throw new Exception();
        }

        public Process Process { get; set; } // TODO

        public static Application Launch(ProcessStartInfo processStartInfo)
        {
            // TODO HYT 2021.12.15
            return null;
        }

        public static Application Launch(string processStartInfo)
        {
            // TODO HYT 2021.12.15
            return null;
        }

        public static Application Attach(Process process)
        {
            // TODO HYT 2021.12.15
            return null;
        }
    }
}
