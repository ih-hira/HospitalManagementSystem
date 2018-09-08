namespace Hospital_Management_System
{
    partial class Pharmacist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacist));
            this.button_logout = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_billing = new System.Windows.Forms.Button();
            this.button_stock = new System.Windows.Forms.Button();
            this.button_item = new System.Windows.Forms.Button();
            this.label_menu = new System.Windows.Forms.Label();
            this.panel_pharmacist = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(118, 456);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(90, 50);
            this.button_logout.TabIndex = 9;
            this.button_logout.Text = "Log Out";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(34, 456);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(78, 50);
            this.button_close.TabIndex = 10;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_billing
            // 
            this.button_billing.Location = new System.Drawing.Point(34, 302);
            this.button_billing.Name = "button_billing";
            this.button_billing.Size = new System.Drawing.Size(174, 39);
            this.button_billing.TabIndex = 16;
            this.button_billing.Text = "Billing";
            this.button_billing.UseVisualStyleBackColor = true;
            // 
            // button_stock
            // 
            this.button_stock.Location = new System.Drawing.Point(34, 258);
            this.button_stock.Name = "button_stock";
            this.button_stock.Size = new System.Drawing.Size(174, 38);
            this.button_stock.TabIndex = 8;
            this.button_stock.Text = "Stock Maintainance";
            this.button_stock.UseVisualStyleBackColor = true;
            // 
            // button_item
            // 
            this.button_item.Location = new System.Drawing.Point(34, 217);
            this.button_item.Name = "button_item";
            this.button_item.Size = new System.Drawing.Size(174, 35);
            this.button_item.TabIndex = 7;
            this.button_item.Text = "Item Details";
            this.button_item.UseVisualStyleBackColor = true;
            this.button_item.Click += new System.EventHandler(this.button_item_Click);
            // 
            // label_menu
            // 
            this.label_menu.AutoSize = true;
            this.label_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu.Location = new System.Drawing.Point(73, 102);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(85, 31);
            this.label_menu.TabIndex = 6;
            this.label_menu.Text = "Menu";
            // 
            // panel_pharmacist
            // 
            this.panel_pharmacist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_pharmacist.Location = new System.Drawing.Point(234, 107);
            this.panel_pharmacist.Name = "panel_pharmacist";
            this.panel_pharmacist.Size = new System.Drawing.Size(800, 560);
            this.panel_pharmacist.TabIndex = 5;
            // 
            // Pharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_billing);
            this.Controls.Add(this.button_stock);
            this.Controls.Add(this.button_item);
            this.Controls.Add(this.label_menu);
            this.Controls.Add(this.panel_pharmacist);
            this.Name = "Pharmacist";
            this.Text = "Pharmacist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_billing;
        private System.Windows.Forms.Button button_stock;
        private System.Windows.Forms.Button button_item;
        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.Panel panel_pharmacist;
    }
}