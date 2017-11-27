using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DeviceManager.Dispatcher;

namespace DeviceManager
{
    public partial class DeviceManagerForm : Form
    {
        public DeviceManagerForm()
        {
            InitializeComponent();
            UpdateData();
        }

        public void UpdateData()
        {
            var dispatcher = DeviceDispatcher.GetInstance();
            var deviceList = dispatcher.Devices;

            devicesGridView.Rows.Clear();
            foreach (var device in deviceList)
            {
                devicesGridView.Rows.Add(device.GUID, device.HardwareID, device.Manufacturer, device.Name, device.DriverDescription, device.SysFile, device.DevicePath);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
