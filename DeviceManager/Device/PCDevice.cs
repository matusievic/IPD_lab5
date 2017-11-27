using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeviceManager.Device
{
    class PCDevice
    {
        public string GUID { get; set; }
        public string HardwareID { get; set; }
        public string Manufacturer { get; set; }
        public string Provider { get; set; }
        public string DriverDescription { get; set; }
        public string SysFile { get; set; }
        public string DevicePath { get; set; }
    }
}
