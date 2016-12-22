namespace OrderManagementSystem
{
    partial class ButtonsControl
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
            this.customerButton = new System.Windows.Forms.Button();
            this.businessButton = new System.Windows.Forms.Button();
            this.employeeButton = new System.Windows.Forms.Button();
            this.ordersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerButton
            // 
            this.customerButton.CausesValidation = false;
            this.customerButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.customerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.customerButton.Location = new System.Drawing.Point(3, 156);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(154, 49);
            this.customerButton.TabIndex = 2;
            this.customerButton.Text = "Customer";
            this.customerButton.UseVisualStyleBackColor = true;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // businessButton
            // 
            this.businessButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.businessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.businessButton.Location = new System.Drawing.Point(3, 266);
            this.businessButton.Name = "businessButton";
            this.businessButton.Size = new System.Drawing.Size(154, 49);
            this.businessButton.TabIndex = 0;
            this.businessButton.Text = "Business";
            this.businessButton.UseVisualStyleBackColor = true;
            this.businessButton.Click += new System.EventHandler(this.businessButton_Click);
            // 
            // employeeButton
            // 
            this.employeeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.employeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.employeeButton.Location = new System.Drawing.Point(3, 211);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(154, 49);
            this.employeeButton.TabIndex = 3;
            this.employeeButton.Text = "Employee";
            this.employeeButton.UseVisualStyleBackColor = true;
            this.employeeButton.Click += new System.EventHandler(this.employeeButton_Click);
            // 
            // ordersButton
            // 
            this.ordersButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ordersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ordersButton.Location = new System.Drawing.Point(3, 3);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(154, 49);
            this.ordersButton.TabIndex = 5;
            this.ordersButton.Text = "Current Orders";
            this.ordersButton.UseVisualStyleBackColor = true;
            this.ordersButton.Click += new System.EventHandler(this.ordersButton_Click);
            // 
            // ButtonsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ordersButton);
            this.Controls.Add(this.employeeButton);
            this.Controls.Add(this.businessButton);
            this.Controls.Add(this.customerButton);
            this.Name = "ButtonsControl";
            this.Size = new System.Drawing.Size(160, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button businessButton;
        private System.Windows.Forms.Button employeeButton;
        private System.Windows.Forms.Button ordersButton;
    }
}
