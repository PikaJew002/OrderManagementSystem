namespace OrderManagementSystem
{
    partial class OrdersControl
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
            this.activeOrdersListBox = new System.Windows.Forms.ListBox();
            this.activeOrdersLabel = new System.Windows.Forms.Label();
            this.orderProductsListLabel = new System.Windows.Forms.Label();
            this.employeeDriversListBox = new System.Windows.Forms.ListBox();
            this.assignDriverButton = new System.Windows.Forms.Button();
            this.driversListLabel = new System.Windows.Forms.Label();
            this.orderProductListView = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // activeOrdersListBox
            // 
            this.activeOrdersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeOrdersListBox.FormattingEnabled = true;
            this.activeOrdersListBox.ItemHeight = 20;
            this.activeOrdersListBox.Location = new System.Drawing.Point(9, 55);
            this.activeOrdersListBox.Margin = new System.Windows.Forms.Padding(0);
            this.activeOrdersListBox.Name = "activeOrdersListBox";
            this.activeOrdersListBox.Size = new System.Drawing.Size(168, 304);
            this.activeOrdersListBox.TabIndex = 0;
            this.activeOrdersListBox.SelectedIndexChanged += new System.EventHandler(this.activeOrdersListBox_SelectedIndexChanged);
            // 
            // activeOrdersLabel
            // 
            this.activeOrdersLabel.AutoSize = true;
            this.activeOrdersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeOrdersLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.activeOrdersLabel.Location = new System.Drawing.Point(31, 12);
            this.activeOrdersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.activeOrdersLabel.Name = "activeOrdersLabel";
            this.activeOrdersLabel.Size = new System.Drawing.Size(124, 24);
            this.activeOrdersLabel.TabIndex = 2;
            this.activeOrdersLabel.Text = "Active Orders";
            // 
            // orderProductsListLabel
            // 
            this.orderProductsListLabel.AutoSize = true;
            this.orderProductsListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderProductsListLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.orderProductsListLabel.Location = new System.Drawing.Point(320, 12);
            this.orderProductsListLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderProductsListLabel.Name = "orderProductsListLabel";
            this.orderProductsListLabel.Size = new System.Drawing.Size(107, 24);
            this.orderProductsListLabel.TabIndex = 5;
            this.orderProductsListLabel.Text = "Product List";
            // 
            // employeeDriversListBox
            // 
            this.employeeDriversListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeDriversListBox.FormattingEnabled = true;
            this.employeeDriversListBox.ItemHeight = 16;
            this.employeeDriversListBox.Location = new System.Drawing.Point(577, 55);
            this.employeeDriversListBox.Margin = new System.Windows.Forms.Padding(0);
            this.employeeDriversListBox.Name = "employeeDriversListBox";
            this.employeeDriversListBox.Size = new System.Drawing.Size(212, 164);
            this.employeeDriversListBox.TabIndex = 6;
            this.employeeDriversListBox.SelectedIndexChanged += new System.EventHandler(this.employeeDriversListBox_SelectedIndexChanged);
            // 
            // assignDriverButton
            // 
            this.assignDriverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignDriverButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.assignDriverButton.Location = new System.Drawing.Point(600, 240);
            this.assignDriverButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.assignDriverButton.Name = "assignDriverButton";
            this.assignDriverButton.Size = new System.Drawing.Size(167, 45);
            this.assignDriverButton.TabIndex = 7;
            this.assignDriverButton.Text = "Assign Driver";
            this.assignDriverButton.UseVisualStyleBackColor = true;
            this.assignDriverButton.Visible = false;
            this.assignDriverButton.Click += new System.EventHandler(this.assignDriverButton_Click);
            // 
            // driversListLabel
            // 
            this.driversListLabel.AutoSize = true;
            this.driversListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driversListLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.driversListLabel.Location = new System.Drawing.Point(633, 12);
            this.driversListLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.driversListLabel.Name = "driversListLabel";
            this.driversListLabel.Size = new System.Drawing.Size(100, 24);
            this.driversListLabel.TabIndex = 8;
            this.driversListLabel.Text = "Drivers List";
            // 
            // orderProductListView
            // 
            this.orderProductListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderProductListView.FormattingEnabled = true;
            this.orderProductListView.ItemHeight = 20;
            this.orderProductListView.Location = new System.Drawing.Point(184, 55);
            this.orderProductListView.Margin = new System.Windows.Forms.Padding(0);
            this.orderProductListView.Name = "orderProductListView";
            this.orderProductListView.Size = new System.Drawing.Size(385, 304);
            this.orderProductListView.TabIndex = 9;
            // 
            // OrdersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orderProductListView);
            this.Controls.Add(this.driversListLabel);
            this.Controls.Add(this.assignDriverButton);
            this.Controls.Add(this.employeeDriversListBox);
            this.Controls.Add(this.orderProductsListLabel);
            this.Controls.Add(this.activeOrdersLabel);
            this.Controls.Add(this.activeOrdersListBox);
            this.Name = "OrdersControl";
            this.Size = new System.Drawing.Size(800, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox activeOrdersListBox;
        private System.Windows.Forms.Label activeOrdersLabel;
        private System.Windows.Forms.Label orderProductsListLabel;
        private System.Windows.Forms.ListBox employeeDriversListBox;
        private System.Windows.Forms.Button assignDriverButton;
        private System.Windows.Forms.Label driversListLabel;
        private System.Windows.Forms.ListBox orderProductListView;
    }
}
