namespace OrderManagementSystem
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titlePanel = new System.Windows.Forms.Panel();
            this.storeTitleLabel = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.storeTitleLabel);
            this.titlePanel.Location = new System.Drawing.Point(9, 12);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(966, 55);
            this.titlePanel.TabIndex = 5;
            // 
            // storeTitleLabel
            // 
            this.storeTitleLabel.AutoSize = true;
            this.storeTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeTitleLabel.Location = new System.Drawing.Point(323, 14);
            this.storeTitleLabel.Name = "storeTitleLabel";
            this.storeTitleLabel.Size = new System.Drawing.Size(302, 31);
            this.storeTitleLabel.TabIndex = 0;
            this.storeTitleLabel.Text = "Big Apple Pizza Bistro";
            // 
            // contentPanel
            // 
            this.contentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contentPanel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.contentPanel.Location = new System.Drawing.Point(175, 73);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(800, 500);
            this.contentPanel.TabIndex = 4;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonsPanel.Location = new System.Drawing.Point(9, 73);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(161, 501);
            this.buttonsPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 582);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.buttonsPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Order Management System";
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label storeTitleLabel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel buttonsPanel;
    }
}

