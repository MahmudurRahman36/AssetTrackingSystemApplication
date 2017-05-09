namespace AssetTrackingSystemApplication.UI
{
    partial class IndexUI
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
            this.organizationButton = new System.Windows.Forms.Button();
            this.catagoryButton = new System.Windows.Forms.Button();
            this.vendorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // organizationButton
            // 
            this.organizationButton.Location = new System.Drawing.Point(140, 131);
            this.organizationButton.Name = "organizationButton";
            this.organizationButton.Size = new System.Drawing.Size(456, 32);
            this.organizationButton.TabIndex = 0;
            this.organizationButton.Text = "Organization Sector";
            this.organizationButton.UseVisualStyleBackColor = true;
            this.organizationButton.Click += new System.EventHandler(this.organizationButton_Click);
            // 
            // catagoryButton
            // 
            this.catagoryButton.Location = new System.Drawing.Point(140, 212);
            this.catagoryButton.Name = "catagoryButton";
            this.catagoryButton.Size = new System.Drawing.Size(456, 32);
            this.catagoryButton.TabIndex = 0;
            this.catagoryButton.Text = "Product Catagory Sector";
            this.catagoryButton.UseVisualStyleBackColor = true;
            this.catagoryButton.Click += new System.EventHandler(this.catagoryButton_Click);
            // 
            // vendorButton
            // 
            this.vendorButton.Location = new System.Drawing.Point(140, 296);
            this.vendorButton.Name = "vendorButton";
            this.vendorButton.Size = new System.Drawing.Size(456, 32);
            this.vendorButton.TabIndex = 0;
            this.vendorButton.Text = "Vendor";
            this.vendorButton.UseVisualStyleBackColor = true;
            this.vendorButton.Click += new System.EventHandler(this.vendorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "INDEX";
            // 
            // IndexUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 479);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vendorButton);
            this.Controls.Add(this.catagoryButton);
            this.Controls.Add(this.organizationButton);
            this.Name = "IndexUI";
            this.Text = "IndexUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button organizationButton;
        private System.Windows.Forms.Button catagoryButton;
        private System.Windows.Forms.Button vendorButton;
        private System.Windows.Forms.Label label1;
    }
}