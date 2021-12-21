using System;
using System.Collections.Generic;

namespace TestStack.White.Configuration
{
    // TODO HYT 2021.12.15
    public class CoreAppXmlConfiguration
    {
        private static CoreAppXmlConfiguration instance;

        public static CoreAppXmlConfiguration Instance => instance ?? (instance = new CoreAppXmlConfiguration());

        private int busyTimeout = 5000;
        public int BusyTimeout
        {
            get => busyTimeout;
            set => busyTimeout = value;
        }

        private bool waitBasedOnHourGlass = false;
        public bool WaitBasedOnHourGlass
        {
            get => waitBasedOnHourGlass;
            set => waitBasedOnHourGlass = value;
        }

        private int findWindowTimeout = 30000;
        public int FindWindowTimeout
        {
            get => findWindowTimeout;
            set => findWindowTimeout = value;
        }

        private int popupTimeout = 5000;

        public int PopupTimeout
        {
            get => popupTimeout;
            set => popupTimeout = value;
        }
    }
}
