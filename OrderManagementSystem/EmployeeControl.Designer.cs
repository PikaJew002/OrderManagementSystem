namespace OrderManagementSystem
{
    partial class EmployeeControl
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
            this.employeesLabel = new System.Windows.Forms.Label();
            this.employeesListBox = new System.Windows.Forms.ListBox();
            this.employeePanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.clockInCheckBox = new System.Windows.Forms.CheckBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.editEmployeeButton = new System.Windows.Forms.Button();
            this.positionValueLabel = new System.Windows.Forms.Label();
            this.clockedInValueLabel = new System.Windows.Forms.Label();
            this.firstNameValueLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.employeePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeesLabel
            // 
            this.employeesLabel.AutoSize = true;
            this.employeesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.employeesLabel.Location = new System.Drawing.Point(35, 23);
            this.employeesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.employeesLabel.Name = "employeesLabel";
            this.employeesLabel.Size = new System.Drawing.Size(105, 24);
            this.employeesLabel.TabIndex = 4;
            this.employeesLabel.Text = "Employees";
            // 
            // employeesListBox
            // 
            this.employeesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesListBox.FormattingEnabled = true;
            this.employeesListBox.ItemHeight = 16;
            this.employeesListBox.Location = new System.Drawing.Point(13, 66);
            this.employeesListBox.Margin = new System.Windows.Forms.Padding(0);
            this.employeesListBox.Name = "employeesListBox";
            this.employeesListBox.Size = new System.Drawing.Size(168, 276);
            this.employeesListBox.TabIndex = 3;
            this.employeesListBox.SelectedIndexChanged += new System.EventHandler(this.employeesListBox_SelectedIndexChanged);
            // 
            // employeePanel
            // 
            this.employeePanel.Controls.Add(this.cancelButton);
            this.employeePanel.Controls.Add(this.saveChangesButton);
            this.employeePanel.Controls.Add(this.clockInCheckBox);
            this.employeePanel.Controls.Add(this.positionTextBox);
            this.employeePanel.Controls.Add(this.lastNameTextBox);
            this.employeePanel.Controls.Add(this.firstNameTextBox);
            this.employeePanel.Controls.Add(this.editEmployeeButton);
            this.employeePanel.Controls.Add(this.positionValueLabel);
            this.employeePanel.Controls.Add(this.clockedInValueLabel);
            this.employeePanel.Controls.Add(this.firstNameValueLabel);
            this.employeePanel.Controls.Add(this.positionLabel);
            this.employeePanel.Controls.Add(this.nameLabel);
            this.employeePanel.Location = new System.Drawing.Point(201, 66);
            this.employeePanel.Margin = new System.Windows.Forms.Padding(2);
            this.employeePanel.Name = "employeePanel";
            this.employeePanel.Size = new System.Drawing.Size(573, 289);
            this.employeePanel.TabIndex = 9;
            this.employeePanel.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancelButton.Location = new System.Drawing.Point(224, 125);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(116, 31);
            this.cancelButton.TabIndex = 45;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveChangesButton.Location = new System.Drawing.Point(104, 125);
            this.saveChangesButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(116, 31);
            this.saveChangesButton.TabIndex = 44;
            this.saveChangesButton.Text = " Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Visible = false;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // clockInCheckBox
            // 
            this.clockInCheckBox.AutoSize = true;
            this.clockInCheckBox.Enabled = false;
            this.clockInCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clockInCheckBox.Location = new System.Drawing.Point(101, 83);
            this.clockInCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.clockInCheckBox.Name = "clockInCheckBox";
            this.clockInCheckBox.Size = new System.Drawing.Size(77, 17);
            this.clockInCheckBox.TabIndex = 43;
            this.clockInCheckBox.Text = "Clocked In";
            this.clockInCheckBox.UseVisualStyleBackColor = true;
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(98, 55);
            this.positionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(91, 20);
            this.positionTextBox.TabIndex = 42;
            this.positionTextBox.Visible = false;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(176, 26);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(83, 20);
            this.lastNameTextBox.TabIndex = 41;
            this.lastNameTextBox.Visible = false;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(98, 26);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(74, 20);
            this.firstNameTextBox.TabIndex = 40;
            this.firstNameTextBox.Visible = false;
            // 
            // editEmployeeButton
            // 
            this.editEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editEmployeeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editEmployeeButton.Location = new System.Drawing.Point(104, 125);
            this.editEmployeeButton.Margin = new System.Windows.Forms.Padding(2);
            this.editEmployeeButton.Name = "editEmployeeButton";
            this.editEmployeeButton.Size = new System.Drawing.Size(116, 31);
            this.editEmployeeButton.TabIndex = 39;
            this.editEmployeeButton.Text = "Edit Employee";
            this.editEmployeeButton.UseVisualStyleBackColor = true;
            this.editEmployeeButton.Click += new System.EventHandler(this.editEmployeeButton_Click);
            // 
            // positionValueLabel
            // 
            this.positionValueLabel.AutoSize = true;
            this.positionValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionValueLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.positionValueLabel.Location = new System.Drawing.Point(98, 55);
            this.positionValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.positionValueLabel.Name = "positionValueLabel";
            this.positionValueLabel.Size = new System.Drawing.Size(0, 16);
            this.positionValueLabel.TabIndex = 37;
            // 
            // clockedInValueLabel
            // 
            this.clockedInValueLabel.AutoSize = true;
            this.clockedInValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockedInValueLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clockedInValueLabel.Location = new System.Drawing.Point(101, 83);
            this.clockedInValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clockedInValueLabel.Name = "clockedInValueLabel";
            this.clockedInValueLabel.Size = new System.Drawing.Size(0, 17);
            this.clockedInValueLabel.TabIndex = 36;
            // 
            // firstNameValueLabel
            // 
            this.firstNameValueLabel.AutoSize = true;
            this.firstNameValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameValueLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.firstNameValueLabel.Location = new System.Drawing.Point(98, 26);
            this.firstNameValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameValueLabel.Name = "firstNameValueLabel";
            this.firstNameValueLabel.Size = new System.Drawing.Size(0, 16);
            this.firstNameValueLabel.TabIndex = 35;
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.positionLabel.Location = new System.Drawing.Point(15, 55);
            this.positionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(58, 17);
            this.positionLabel.TabIndex = 34;
            this.positionLabel.Text = "Position";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameLabel.Location = new System.Drawing.Point(27, 26);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 33;
            this.nameLabel.Text = "Name";
            // 
            // EmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.employeePanel);
            this.Controls.Add(this.employeesLabel);
            this.Controls.Add(this.employeesListBox);
            this.Name = "EmployeeControl";
            this.Size = new System.Drawing.Size(800, 500);
            this.employeePanel.ResumeLayout(false);
            this.employeePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeesLabel;
        private System.Windows.Forms.ListBox employeesListBox;
        private System.Windows.Forms.Panel employeePanel;
        private System.Windows.Forms.CheckBox clockInCheckBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Button editEmployeeButton;
        private System.Windows.Forms.Label positionValueLabel;
        private System.Windows.Forms.Label clockedInValueLabel;
        private System.Windows.Forms.Label firstNameValueLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
