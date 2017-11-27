using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using DeviceManager.Device;

namespace DeviceManager.Scanner
{
    sealed class DeviceScanner
    {
        private static DeviceScanner _instance;
        public static DeviceScanner GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DeviceScanner();
            }
            return _instance;
        }
        private DeviceScanner()
        {
            UpdateDevices();
        }

        private const string GUID_PROPERTY = "ClassGUID";
        private const string HARDWARE_ID_PROPERTY = "HardwareID";
        private const string Manufacturer_PROPERTY = "Manufacturer";
        private const string PROVIDER_PROPERTY = "Caption";
        private const string DRIVER_DESCRIPTION_PROPERTY = "Description";
        private const string SYS_FILE_PROPERTY = "PathName";
        private const string DEVICE_PATH_PROPERTY = "DeviceID";
        

        public List<PCDevice> Devices { get; set; }
        public List<PCDevice> UpdateDevices()
        {
            var deviceList = new List<PCDevice>();
            var wmiDeviceList = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity").Get();

            foreach (var device in wmiDeviceList)
            {
                var currentDevice = new PCDevice();

                currentDevice.GUID = device[GUID_PROPERTY].ToString();
                object hardwareIDProp = device[HARDWARE_ID_PROPERTY];
                currentDevice.HardwareID = (hardwareIDProp != null) ? string.Join("", (string[]) hardwareIDProp) : "";
                object manufacturerProp = device[Manufacturer_PROPERTY];
                currentDevice.Manufacturer = (manufacturerProp != null) ? manufacturerProp.ToString() : "";
                currentDevice.Provider = device[PROVIDER_PROPERTY].ToString();
                currentDevice.DevicePath = device[DEVICE_PATH_PROPERTY].ToString();

                var driverInfo = ((ManagementObject)device).GetRelated("Win32_SystemDriver");
                foreach (var driver in driverInfo)
                {
                    currentDevice.SysFile = driver[SYS_FILE_PROPERTY].ToString();
                    currentDevice.DriverDescription = driver[DRIVER_DESCRIPTION_PROPERTY].ToString();
                }

                deviceList.Add(currentDevice);
            }

            Devices = deviceList;
            return Devices;
        }
    }
}
