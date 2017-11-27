using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;

namespace DeviceManager.Device
{
    class PCDevice
    {
        public string GUID { get; set; }
        public string HardwareID { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public string DriverDescription { get; set; }
        public string SysFile { get; set; }
        public string DevicePath { get; set; }
        public bool Enabled { get; set; }

        public void enable()
        {
            var devices = new ManagementObjectSearcher("SELECT * FROM Win32_PNPEntity").Get();
            foreach (var dev in devices)
            {
                if (this.DevicePath == dev["DeviceID"].ToString())
                {
                    try { ((ManagementObject)dev)?.InvokeMethod("Enable", new object[] { false }); }
                    catch (ManagementException) { throw new PCDeviceException("Cannot enable this device."); }
                    this.Enabled = true;
                    return;
                }
            }

            throw new PCDeviceException("Cannot find this device");
        }

        public void disable()
        {
            var devices = new ManagementObjectSearcher("SELECT * FROM Win32_PNPEntity").Get();
            foreach (var dev in devices)
            {
                if (this.DevicePath == dev["DeviceID"].ToString())
                {
                    try { ((ManagementObject)dev)?.InvokeMethod("Disable", new object[] { false }); }
                    catch(ManagementException) { throw new PCDeviceException("Cannot disable this device."); }
                    this.Enabled = false;
                    return;
                }
            }

            throw new PCDeviceException("Cannot find this device");
        }
    }
}
