namespace OrderManagementSystem
{
    partial class CustomerControl
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
            this.customerListBox = new System.Windows.Forms.ListBox();
            this.customerListLabel = new System.Windows.Forms.Label();
            this.customerInfoLabel = new System.Windows.Forms.Label();
            this.customerInfoPanel = new System.Windows.Forms.Panel();
            this.phoneValueLabel = new System.Windows.Forms.Label();
            this.address1ValueLabel = new System.Windows.Forms.Label();
            this.emailValueLabel = new System.Windows.Forms.Label();
            this.nameValueLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.address1Label = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.orderHistoryListBox = new System.Windows.Forms.ListBox();
            this.orderHistoryLabel = new System.Windows.Forms.Label();
            this.viewCustomerInfoButton = new System.Windows.Forms.Button();
            this.viewOrderButton = new System.Windows.Forms.Button();
            this.orderHistoryPanel = new System.Windows.Forms.Panel();
            this.goBackButton = new System.Windows.Forms.Button();
            this.customerInfoPanel.SuspendLayout();
            this.orderHistoryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerListBox
            // 
            this.customerListBox.FormattingEnabled = true;
            this.customerListBox.HorizontalScrollbar = true;
            this.customerListBox.Location = new System.Drawing.Point(9, 58);
            this.customerListBox.Name = "customerListBox";
            this.customerListBox.Size = new System.Drawing.Size(207, 355);
            this.customerListBox.TabIndex = 0;
            this.customerListBox.SelectedIndexChanged += new System.EventHandler(this.customerListBox_SelectedIndexChanged);
            // 
            // customerListLabel
            // 
            this.customerListLabel.AutoSize = true;
            this.customerListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerListLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.customerListLabel.Location = new System.Drawing.Point(49, 25);
            this.customerListLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerListLabel.Name = "customerListLabel";
            this.customerListLabel.Size = new System.Drawing.Size(123, 24);
            this.customerListLabel.TabIndex = 3;
            this.customerListLabel.Text = "Customer List";
            // 
            // customerInfoLabel
            // 
            this.customerInfoLabel.AutoSize = true;
            this.customerInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInfoLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.customerInfoLabel.Location = new System.Drawing.Point(316, 25);
            this.customerInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerInfoLabel.Name = "customerInfoLabel";
            this.customerInfoLabel.Size = new System.Drawing.Size(126, 24);
            this.customerInfoLabel.TabIndex = 4;
            this.customerInfoLabel.Text = "Customer Info";
            this.customerInfoLabel.Visible = false;
            // 
            // customerInfoPanel
            // 
            this.customerInfoPanel.Controls.Add(this.phoneValueLabel);
            this.customerInfoPanel.Controls.Add(this.address1ValueLabel);
            this.customerInfoPanel.Controls.Add(this.emailValueLabel);
            this.customerInfoPanel.Controls.Add(this.nameValueLabel);
            this.customerInfoPanel.Controls.Add(this.phoneLabel);
            this.customerInfoPanel.Controls.Add(this.address1Label);
            this.customerInfoPanel.Controls.Add(this.emailLabel);
            this.customerInfoPanel.Controls.Add(this.nameLabel);
            this.customerInfoPanel.Location = new System.Drawing.Point(221, 58);
            this.customerInfoPanel.Margin = new System.Windows.Forms.Padding(2);
            this.customerInfoPanel.Name = "customerInfoPanel";
            this.customerInfoPanel.Size = new System.Drawing.Size(316, 432);
            this.customerInfoPanel.TabIndex = 5;
            this.customerInfoPanel.Visible = false;
            // 
            // phoneValueLabel
            // 
            this.phoneValueLabel.AutoSize = true;
            this.phoneValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneValueLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.phoneValueLabel.Location = new System.Drawing.Point(114, 155);
            this.phoneValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneValueLabel.Name = "phoneValueLabel";
            this.phoneValueLabel.Size = new System.Drawing.Size(0, 16);
            this.phoneValueLabel.TabIndex = 12;
            // 
            // address1ValueLabel
            // 
            this.address1ValueLabel.AutoSize = true;
            this.address1ValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address1ValueLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.address1ValueLabel.Location = new System.Drawing.Point(111, 87);
            this.address1ValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.address1ValueLabel.Name = "address1ValueLabel";
            this.address1ValueLabel.Size = new System.Drawing.Size(0, 16);
            this.address1ValueLabel.TabIndex = 9;
            // 
            // emailValueLabel
            // 
            this.emailValueLabel.AutoSize = true;
            this.emailValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailValueLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.emailValueLabel.Location = new System.Drawing.Point(115, 58);
            this.emailValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailValueLabel.Name = "emailValueLabel";
            this.emailValueLabel.Size = new System.Drawing.Size(0, 16);
            this.emailValueLabel.TabIndex = 8;
            // 
            // nameValueLabel
            // 
            this.nameValueLabel.AutoSize = true;
            this.nameValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameValueLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameValueLabel.Location = new System.Drawing.Point(115, 28);
            this.nameValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameValueLabel.Name = "nameValueLabel";
            this.nameValueLabel.Size = new System.Drawing.Size(0, 16);
            this.nameValueLabel.TabIndex = 7;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.phoneLabel.Location = new System.Drawing.Point(44, 154);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(49, 17);
            this.phoneLabel.TabIndex = 5;
            this.phoneLabel.Text = "Phone";
            // 
            // address1Label
            // 
            this.address1Label.AutoSize = true;
            this.address1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address1Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.address1Label.Location = new System.Drawing.Point(34, 87);
            this.address1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.address1Label.Name = "address1Label";
            this.address1Label.Size = new System.Drawing.Size(60, 17);
            this.address1Label.TabIndex = 2;
            this.address1Label.Text = "Address";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.emailLabel.Location = new System.Drawing.Point(48, 57);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 17);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameLabel.Location = new System.Drawing.Point(48, 27);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // orderHistoryListBox
            // 
            this.orderHistoryListBox.FormattingEnabled = true;
            this.orderHistoryListBox.Location = new System.Drawing.Point(0, 0);
            this.orderHistoryListBox.Name = "orderHistoryListBox";
            this.orderHistoryListBox.Size = new System.Drawing.Size(242, 355);
            this.orderHistoryListBox.TabIndex = 6;
            this.orderHistoryListBox.Visible = false;
            // 
            // orderHistoryLabel
            // 
            this.orderHistoryLabel.AutoSize = true;
            this.orderHistoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderHistoryLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.orderHistoryLabel.Location = new System.Drawing.Point(603, 25);
            this.orderHistoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderHistoryLabel.Name = "orderHistoryLabel";
            this.orderHistoryLabel.Size = new System.Drawing.Size(121, 24);
            this.orderHistoryLabel.TabIndex = 7;
            this.orderHistoryLabel.Text = "Order History";
            this.orderHistoryLabel.Visible = false;
            // 
            // viewCustomerInfoButton
            // 
            this.viewCustomerInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCustomerInfoButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.viewCustomerInfoButton.Location = new System.Drawing.Point(38, 417);
            this.viewCustomerInfoButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewCustomerInfoButton.Name = "viewCustomerInfoButton";
            this.viewCustomerInfoButton.Size = new System.Drawing.Size(148, 45);
            this.viewCustomerInfoButton.TabIndex = 8;
            this.viewCustomerInfoButton.Text = "View Customer Info";
            this.viewCustomerInfoButton.UseVisualStyleBackColor = true;
            this.viewCustomerInfoButton.Click += new System.EventHandler(this.viewCustomerInfoButton_Click);
            // 
            // viewOrderButton
            // 
            this.viewOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrderButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.viewOrderButton.Location = new System.Drawing.Point(589, 417);
            this.viewOrderButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewOrderButton.Name = "viewOrderButton";
            this.viewOrderButton.Size = new System.Drawing.Size(148, 45);
            this.viewOrderButton.TabIndex = 9;
            this.viewOrderButton.Text = "View Order";
            this.viewOrderButton.UseVisualStyleBackColor = true;
            this.viewOrderButton.Visible = false;
            this.viewOrderButton.Click += new System.EventHandler(this.viewOrderButton_Click);
            // 
            // orderHistoryPanel
            // 
            this.orderHistoryPanel.Controls.Add(this.orderHistoryListBox);
            this.orderHistoryPanel.Location = new System.Drawing.Point(542, 58);
            this.orderHistoryPanel.Name = "orderHistoryPanel";
            this.orderHistoryPanel.Size = new System.Drawing.Size(242, 355);
            this.orderHistoryPanel.TabIndex = 10;
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.goBackButton.Location = new System.Drawing.Point(589, 418);
            this.goBackButton.Margin = new System.Windows.Forms.Padding(2);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(148, 45);
            this.goBackButton.TabIndex = 11;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Visible = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // CustomerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.orderHistoryPanel);
            this.Controls.Add(this.viewOrderButton);
            this.Controls.Add(this.viewCustomerInfoButton);
            this.Controls.Add(this.orderHistoryLabel);
            this.Controls.Add(this.customerInfoPanel);
            this.Controls.Add(this.customerInfoLabel);
            this.Controls.Add(this.customerListLabel);
            this.Controls.Add(this.customerListBox);
            this.Name = "CustomerControl";
            this.Size = new System.Drawing.Size(800, 500);
            this.customerInfoPanel.ResumeLayout(false);
            this.customerInfoPanel.PerformLayout();
            this.orderHistoryPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox customerListBox;
        private System.Windows.Forms.Label customerListLabel;
        private System.Windows.Forms.Label customerInfoLabel;
        private System.Windows.Forms.Panel customerInfoPanel;
        private System.Windows.Forms.Label orderHistoryLabel;
        private System.Windows.Forms.Button viewCustomerInfoButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label address1Label;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label address1ValueLabel;
        private System.Windows.Forms.Label emailValueLabel;
        private System.Windows.Forms.Label nameValueLabel;
        private System.Windows.Forms.Label phoneValueLabel;
        private System.Windows.Forms.Button viewOrderButton;
        private System.Windows.Forms.Panel orderHistoryPanel;
        private System.Windows.Forms.ListBox orderHistoryListBox;
        private System.Windows.Forms.Button goBackButton;
    }
}
