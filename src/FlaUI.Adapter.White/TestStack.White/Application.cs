using System;
using System.Diagnostics;
using System.Linq;
using FlaUI.Adapter.White.Resources;
using FlaUI.Core;
using TestStack.White.Configuration;
using TestStack.White.UIItems.WindowItems;

namespace TestStack.White
{
    // TODO [#1 | HYT | Implemented]
    public class Application : FlaUI.Core.Application
    {
        public Application(int processId, bool isStoreApp = false) : base(processId, isStoreApp)
        {
        }

        public Application(Process process, bool isStoreApp = false) : base(process, isStoreApp)
        {
        }

        public Window GetWindow(AutomationBase automationBase)
        {
            return new Window(base.GetMainWindow(automationBase).FrameworkAutomationElement);
        }

        public Window GetWindow(string title, AutomationBase automationBase)
        {
            Window window = null;
            Deprecated_WaitFor(() =>
            {
                var frameworkAutomationElement = base.GetAllTopLevelWindows(automationBase)
                    .FirstOrDefault(x => x.Name == title)?.FrameworkAutomationElement;
                window = frameworkAutomationElement != null ? new Window(frameworkAutomationElement) : null;
                return window != null;
            }, assertionMessage: String.Format(MessageResources.Application_NotFindWindow, title));
            return window;
        }

        public Process Process => Process.GetProcessById(base.ProcessId);

        public static Application Launch(ProcessStartInfo processStartInfo)
        {
            var app = FlaUI.Core.Application.Launch(processStartInfo);
            return new Application(app.ProcessId);
        }

        public static Application Launch(string executable)
        {
            var app = FlaUI.Core.Application.Launch(executable);
            return new Application(app.ProcessId);
        }

        public static Application Attach(Process process)
        {
            var app = FlaUI.Core.Application.Attach(process);
            return new Application(app.ProcessId);
        }

        public static Application Attach(string executable)
        {
            var app = FlaUI.Core.Application.Attach(executable);
            return new Application(app.ProcessId);
        }

        private bool Deprecated_WaitFor(Func<bool> condition, Action action = null, string assertionMessage = null)
        {
            var now = DateTime.UtcNow;
            while (true)
            {
                if (DateTime.UtcNow.Subtract(now).TotalSeconds > (new TimeSpan(0,0 , 0,0, CoreAppXmlConfiguration.Instance.FindWindowTimeout)).TotalSeconds)
                {
                    if (String.IsNullOrEmpty(assertionMessage))
                    {
                        return false;
                    }
                    throw new AutomationException(assertionMessage, nameof(Application));
                }
                try
                {
                    action?.Invoke();
                    if (condition == null || condition())
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    throw new AutomationException($@"An error occurred during WaitFor: {ex.Message}", ex.StackTrace);
                }
            }
            return true;
        }
    }
}
