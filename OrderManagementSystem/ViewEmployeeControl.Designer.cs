namespace OrderManagementSystem
{
    partial class ViewEmployeeControl
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
            this.positionValueLabel = new System.Windows.Forms.Label();
            this.clockedInValueLabel = new System.Windows.Forms.Label();
            this.firstNameValueLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.lastNameValueLabel = new System.Windows.Forms.Label();
            this.editEmployeeButton = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.clockInCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // positionValueLabel
            // 
            this.positionValueLabel.AutoSize = true;
            this.positionValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionValueLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.positionValueLabel.Location = new System.Drawing.Point(191, 94);
            this.positionValueLabel.Name = "positionValueLabel";
            this.positionValueLabel.Size = new System.Drawing.Size(0, 25);
            this.positionValueLabel.TabIndex = 25;
            // 
            // clockedInValueLabel
            // 
            this.clockedInValueLabel.AutoSize = true;
            this.clockedInValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockedInValueLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clockedInValueLabel.Location = new System.Drawing.Point(191, 138);
            this.clockedInValueLabel.Name = "clockedInValueLabel";
            this.clockedInValueLabel.Size = new System.Drawing.Size(0, 25);
            this.clockedInValueLabel.TabIndex = 22;
            // 
            // firstNameValueLabel
            // 
            this.firstNameValueLabel.AutoSize = true;
            this.firstNameValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameValueLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.firstNameValueLabel.Location = new System.Drawing.Point(191, 50);
            this.firstNameValueLabel.Name = "firstNameValueLabel";
            this.firstNameValueLabel.Size = new System.Drawing.Size(0, 25);
            this.firstNameValueLabel.TabIndex = 21;
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.positionLabel.Location = new System.Drawing.Point(63, 94);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(81, 25);
            this.positionLabel.TabIndex = 19;
            this.positionLabel.Text = "Position";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameLabel.Location = new System.Drawing.Point(80, 50);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(64, 25);
            this.nameLabel.TabIndex = 14;
            this.nameLabel.Text = "Name";
            // 
            // lastNameValueLabel
            // 
            this.lastNameValueLabel.AutoSize = true;
            this.lastNameValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameValueLabel.Location = new System.Drawing.Point(325, 51);
            this.lastNameValueLabel.Name = "lastNameValueLabel";
            this.lastNameValueLabel.Size = new System.Drawing.Size(0, 25);
            this.lastNameValueLabel.TabIndex = 27;
            // 
            // editEmployeeButton
            // 
            this.editEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editEmployeeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editEmployeeButton.Location = new System.Drawing.Point(196, 202);
            this.editEmployeeButton.Name = "editEmployeeButton";
            this.editEmployeeButton.Size = new System.Drawing.Size(161, 36);
            this.editEmployeeButton.TabIndex = 28;
            this.editEmployeeButton.Text = "Edit Employee";
            this.editEmployeeButton.UseVisualStyleBackColor = true;
            this.editEmployeeButton.Click += new System.EventHandler(this.editEmployeeButton_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(191, 50);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(109, 26);
            this.firstNameTextBox.TabIndex = 29;
            this.firstNameTextBox.Visible = false;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(325, 51);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(122, 26);
            this.lastNameTextBox.TabIndex = 30;
            this.lastNameTextBox.Visible = false;
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(191, 94);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(134, 26);
            this.positionTextBox.TabIndex = 31;
            this.positionTextBox.Visible = false;
            // 
            // clockInCheckBox
            // 
            this.clockInCheckBox.AutoSize = true;
            this.clockInCheckBox.Location = new System.Drawing.Point(191, 138);
            this.clockInCheckBox.Name = "clockInCheckBox";
            this.clockInCheckBox.Size = new System.Drawing.Size(110, 24);
            this.clockInCheckBox.TabIndex = 32;
            this.clockInCheckBox.Text = "Clocked In";
            this.clockInCheckBox.UseVisualStyleBackColor = true;
            // 
            // ViewEmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clockInCheckBox);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.editEmployeeButton);
            this.Controls.Add(this.lastNameValueLabel);
            this.Controls.Add(this.positionValueLabel);
            this.Controls.Add(this.clockedInValueLabel);
            this.Controls.Add(this.firstNameValueLabel);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "ViewEmployeeControl";
            this.Size = new System.Drawing.Size(860, 444);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label positionValueLabel;
        private System.Windows.Forms.Label clockedInValueLabel;
        private System.Windows.Forms.Label firstNameValueLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label lastNameValueLabel;
        private System.Windows.Forms.Button editEmployeeButton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.CheckBox clockInCheckBox;
    }
}
