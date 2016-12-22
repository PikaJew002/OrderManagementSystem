namespace OrderManagementSystem
{
    partial class BusinessControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.dayComboBox = new System.Windows.Forms.ComboBox();
            this.getBusinessVolume = new System.Windows.Forms.Button();
            this.ordersListBox = new System.Windows.Forms.ListBox();
            this.businessVolumeLabel = new System.Windows.Forms.Label();
            this.businessVolumeValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yearComboBox
            // 
            this.yearComboBox.AllowDrop = true;
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(17, 22);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(69, 21);
            this.yearComboBox.TabIndex = 0;
            this.yearComboBox.SelectedIndexChanged += new System.EventHandler(this.yearComboBox_SelectedIndexChanged);
            // 
            // monthComboBox
            // 
            this.monthComboBox.AllowDrop = true;
            this.monthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComboBox.Enabled = false;
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(92, 22);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(98, 21);
            this.monthComboBox.TabIndex = 1;
            this.monthComboBox.SelectedIndexChanged += new System.EventHandler(this.monthComboBox_SelectedIndexChanged);
            // 
            // dayComboBox
            // 
            this.dayComboBox.AllowDrop = true;
            this.dayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayComboBox.Enabled = false;
            this.dayComboBox.FormattingEnabled = true;
            this.dayComboBox.Location = new System.Drawing.Point(196, 22);
            this.dayComboBox.Name = "dayComboBox";
            this.dayComboBox.Size = new System.Drawing.Size(53, 21);
            this.dayComboBox.TabIndex = 2;
            // 
            // getBusinessVolume
            // 
            this.getBusinessVolume.ForeColor = System.Drawing.SystemColors.ControlText;
            this.getBusinessVolume.Location = new System.Drawing.Point(128, 49);
            this.getBusinessVolume.Name = "getBusinessVolume";
            this.getBusinessVolume.Size = new System.Drawing.Size(121, 29);
            this.getBusinessVolume.TabIndex = 3;
            this.getBusinessVolume.Text = "Get Busines Volume";
            this.getBusinessVolume.UseVisualStyleBackColor = true;
            this.getBusinessVolume.Click += new System.EventHandler(this.getBusinessVolume_Click);
            // 
            // ordersListBox
            // 
            this.ordersListBox.FormattingEnabled = true;
            this.ordersListBox.Location = new System.Drawing.Point(389, 22);
            this.ordersListBox.Margin = new System.Windows.Forms.Padding(2);
            this.ordersListBox.Name = "ordersListBox";
            this.ordersListBox.Size = new System.Drawing.Size(294, 368);
            this.ordersListBox.TabIndex = 4;
            // 
            // businessVolumeLabel
            // 
            this.businessVolumeLabel.AutoSize = true;
            this.businessVolumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessVolumeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.businessVolumeLabel.Location = new System.Drawing.Point(79, 146);
            this.businessVolumeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.businessVolumeLabel.Name = "businessVolumeLabel";
            this.businessVolumeLabel.Size = new System.Drawing.Size(120, 17);
            this.businessVolumeLabel.TabIndex = 5;
            this.businessVolumeLabel.Text = "Business Volume:";
            // 
            // businessVolumeValueLabel
            // 
            this.businessVolumeValueLabel.AutoSize = true;
            this.businessVolumeValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessVolumeValueLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.businessVolumeValueLabel.Location = new System.Drawing.Point(205, 146);
            this.businessVolumeValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.businessVolumeValueLabel.Name = "businessVolumeValueLabel";
            this.businessVolumeValueLabel.Size = new System.Drawing.Size(0, 17);
            this.businessVolumeValueLabel.TabIndex = 6;
            // 
            // BusinessControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.businessVolumeValueLabel);
            this.Controls.Add(this.businessVolumeLabel);
            this.Controls.Add(this.ordersListBox);
            this.Controls.Add(this.getBusinessVolume);
            this.Controls.Add(this.dayComboBox);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.yearComboBox);
            this.Name = "BusinessControl";
            this.Size = new System.Drawing.Size(800, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.ComboBox dayComboBox;
        private System.Windows.Forms.Button getBusinessVolume;
        private System.Windows.Forms.ListBox ordersListBox;
        private System.Windows.Forms.Label businessVolumeLabel;
        private System.Windows.Forms.Label businessVolumeValueLabel;
    }
}
