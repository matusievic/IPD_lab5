﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DeviceManager.Dispatcher;
using DeviceManager.Device;

namespace DeviceManager
{
    public partial class DeviceManagerForm : Form
    {
        private DeviceDispatcher dispatcher = DeviceDispatcher.GetInstance();

        public DeviceManagerForm()
        {
            InitializeComponent();
            devicesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            devicesGridView.MultiSelect = false;
            UpdateData();
        }

        public void UpdateData()
        {
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

        private void enableButton_Click(object sender, EventArgs e)
        {
            var selectedRow = devicesGridView.SelectedRows[0].Index;
            var deviceList = dispatcher.Devices;
            try
            {
                deviceList[selectedRow]?.enable();
                MessageBox.Show(this, deviceList[selectedRow].Name + " was enabled succefully", "OK - deviceManager");
            }
            catch (PCDeviceException exc) { MessageBox.Show(this, exc.Message, "Error - DeviceManager"); }

            disableButton.Enabled = true;
            enableButton.Enabled = false;
        }

        private void disableButton_Click(object sender, EventArgs e)
        {
            var selectedRow = devicesGridView.SelectedRows[0].Index;
            var deviceList = dispatcher.Devices;
            try
            {
                deviceList[selectedRow]?.disable();
                MessageBox.Show(this, deviceList[selectedRow].Name + " was disabled succefully", "OK - deviceManager");
            }
            catch (PCDeviceException exc) { MessageBox.Show(this, exc.Message, "Error - DeviceManager"); }

            disableButton.Enabled = false;
            enableButton.Enabled = true;
        }

        private void devicesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = devicesGridView.SelectedRows[0].Index;
            var device = dispatcher.Devices[selectedRow];
            if (device.Enabled == true)
            {
                enableButton.Enabled = false;
                disableButton.Enabled = true;
            }
            if (device.Enabled == false)
            {
                enableButton.Enabled = true;
                disableButton.Enabled = false;
            } 
        }
    }
}
