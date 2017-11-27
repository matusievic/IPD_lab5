using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeviceManager.Device;

namespace DeviceManager.Dispatcher
{
    sealed class DeviceDispatcher
    {
        private static DeviceDispatcher _instance;
        public static DeviceDispatcher GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DeviceDispatcher();
            }
            return _instance;
        }

        public List<PCDevice> Devices { get; private set; }
    }
}
