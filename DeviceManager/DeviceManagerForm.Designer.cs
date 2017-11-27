namespace DeviceManager
{
    partial class DeviceManagerForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GUIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HardwareIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufacturerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProviderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SysFileColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevicePathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enableButton = new System.Windows.Forms.Button();
            this.disableButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GUIDColumn,
            this.HardwareIDColumn,
            this.ManufacturerColumn,
            this.ProviderColumn,
            this.DriverDescriptionColumn,
            this.SysFileColumn,
            this.DevicePathColumn});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 212);
            this.dataGridView1.TabIndex = 0;
            // 
            // GUIDColumn
            // 
            this.GUIDColumn.HeaderText = "GUID";
            this.GUIDColumn.Name = "GUIDColumn";
            // 
            // HardwareIDColumn
            // 
            this.HardwareIDColumn.HeaderText = "HardwareID";
            this.HardwareIDColumn.Name = "HardwareIDColumn";
            // 
            // ManufacturerColumn
            // 
            this.ManufacturerColumn.HeaderText = "Manufacturer";
            this.ManufacturerColumn.Name = "ManufacturerColumn";
            // 
            // ProviderColumn
            // 
            this.ProviderColumn.HeaderText = "Provider";
            this.ProviderColumn.Name = "ProviderColumn";
            // 
            // DriverDescriptionColumn
            // 
            this.DriverDescriptionColumn.HeaderText = "DriverDescription";
            this.DriverDescriptionColumn.Name = "DriverDescriptionColumn";
            // 
            // SysFileColumn
            // 
            this.SysFileColumn.HeaderText = "SysFile";
            this.SysFileColumn.Name = "SysFileColumn";
            // 
            // DevicePathColumn
            // 
            this.DevicePathColumn.HeaderText = "DevicePath";
            this.DevicePathColumn.Name = "DevicePathColumn";
            // 
            // enableButton
            // 
            this.enableButton.Location = new System.Drawing.Point(12, 218);
            this.enableButton.Name = "enableButton";
            this.enableButton.Size = new System.Drawing.Size(75, 23);
            this.enableButton.TabIndex = 1;
            this.enableButton.Text = "Enable";
            this.enableButton.UseVisualStyleBackColor = true;
            // 
            // disableButton
            // 
            this.disableButton.Location = new System.Drawing.Point(94, 218);
            this.disableButton.Name = "disableButton";
            this.disableButton.Size = new System.Drawing.Size(75, 23);
            this.disableButton.TabIndex = 2;
            this.disableButton.Text = "Disable";
            this.disableButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(654, 218);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // DeviceManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 251);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.disableButton);
            this.Controls.Add(this.enableButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DeviceManagerForm";
            this.Text = "Device Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HardwareIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProviderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SysFileColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevicePathColumn;
        private System.Windows.Forms.Button enableButton;
        private System.Windows.Forms.Button disableButton;
        private System.Windows.Forms.Button exitButton;
    }
}

