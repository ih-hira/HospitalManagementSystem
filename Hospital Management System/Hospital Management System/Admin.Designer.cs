namespace Hospital_Management_System
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel_admin = new System.Windows.Forms.Panel();
            this.label_menu = new System.Windows.Forms.Label();
            this.button_patientreg = new System.Windows.Forms.Button();
            this.button_patientinfo = new System.Windows.Forms.Button();
            this.button_patientcout = new System.Windows.Forms.Button();
            this.button_roominfo = new System.Windows.Forms.Button();
            this.button_newward = new System.Windows.Forms.Button();
            this.button_empinfo = new System.Windows.Forms.Button();
            this.button_userinfo = new System.Windows.Forms.Button();
            this.button_newuser = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel_admin
            // 
            this.panel_admin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_admin.Location = new System.Drawing.Point(239, 109);
            this.panel_admin.Name = "panel_admin";
            this.panel_admin.Size = new System.Drawing.Size(800, 560);
            this.panel_admin.TabIndex = 0;
            // 
            // label_menu
            // 
            this.label_menu.AutoSize = true;
            this.label_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu.Location = new System.Drawing.Point(75, 109);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(85, 31);
            this.label_menu.TabIndex = 1;
            this.label_menu.Text = "Menu";
            // 
            // button_patientreg
            // 
            this.button_patientreg.Location = new System.Drawing.Point(36, 162);
            this.button_patientreg.Name = "button_patientreg";
            this.button_patientreg.Size = new System.Drawing.Size(174, 35);
            this.button_patientreg.TabIndex = 2;
            this.button_patientreg.Text = "Patient Registration";
            this.button_patientreg.UseVisualStyleBackColor = true;
            this.button_patientreg.Click += new System.EventHandler(this.button_patientreg_Click);
            // 
            // button_patientinfo
            // 
            this.button_patientinfo.Location = new System.Drawing.Point(36, 203);
            this.button_patientinfo.Name = "button_patientinfo";
            this.button_patientinfo.Size = new System.Drawing.Size(174, 38);
            this.button_patientinfo.TabIndex = 3;
            this.button_patientinfo.Text = "Patient Information";
            this.button_patientinfo.UseVisualStyleBackColor = true;
            this.button_patientinfo.Click += new System.EventHandler(this.button_patientinfo_Click);
            // 
            // button_patientcout
            // 
            this.button_patientcout.Location = new System.Drawing.Point(36, 247);
            this.button_patientcout.Name = "button_patientcout";
            this.button_patientcout.Size = new System.Drawing.Size(174, 39);
            this.button_patientcout.TabIndex = 4;
            this.button_patientcout.Text = "Patient Checkout";
            this.button_patientcout.UseVisualStyleBackColor = true;
            this.button_patientcout.Click += new System.EventHandler(this.button_patientcout_Click);
            // 
            // button_roominfo
            // 
            this.button_roominfo.Location = new System.Drawing.Point(36, 292);
            this.button_roominfo.Name = "button_roominfo";
            this.button_roominfo.Size = new System.Drawing.Size(174, 40);
            this.button_roominfo.TabIndex = 4;
            this.button_roominfo.Text = "Room Information";
            this.button_roominfo.UseVisualStyleBackColor = true;
            this.button_roominfo.Click += new System.EventHandler(this.button_roominfo_Click);
            // 
            // button_newward
            // 
            this.button_newward.Location = new System.Drawing.Point(36, 338);
            this.button_newward.Name = "button_newward";
            this.button_newward.Size = new System.Drawing.Size(174, 34);
            this.button_newward.TabIndex = 4;
            this.button_newward.Text = "Add New Ward";
            this.button_newward.UseVisualStyleBackColor = true;
            this.button_newward.Click += new System.EventHandler(this.button_newward_Click);
            // 
            // button_empinfo
            // 
            this.button_empinfo.Location = new System.Drawing.Point(36, 378);
            this.button_empinfo.Name = "button_empinfo";
            this.button_empinfo.Size = new System.Drawing.Size(174, 40);
            this.button_empinfo.TabIndex = 4;
            this.button_empinfo.Text = "Employee Information";
            this.button_empinfo.UseVisualStyleBackColor = true;
            this.button_empinfo.Click += new System.EventHandler(this.button_empinfo_Click);
            // 
            // button_userinfo
            // 
            this.button_userinfo.Location = new System.Drawing.Point(36, 424);
            this.button_userinfo.Name = "button_userinfo";
            this.button_userinfo.Size = new System.Drawing.Size(174, 39);
            this.button_userinfo.TabIndex = 4;
            this.button_userinfo.Text = "User Information";
            this.button_userinfo.UseVisualStyleBackColor = true;
            this.button_userinfo.Click += new System.EventHandler(this.button_userinfo_Click);
            // 
            // button_newuser
            // 
            this.button_newuser.Location = new System.Drawing.Point(36, 469);
            this.button_newuser.Name = "button_newuser";
            this.button_newuser.Size = new System.Drawing.Size(174, 36);
            this.button_newuser.TabIndex = 4;
            this.button_newuser.Text = "Add NewUser";
            this.button_newuser.UseVisualStyleBackColor = true;
            this.button_newuser.Click += new System.EventHandler(this.button_newuser_Click);
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(70, 554);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(90, 50);
            this.button_logout.TabIndex = 4;
            this.button_logout.Text = "Log Out";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_newuser);
            this.Controls.Add(this.button_userinfo);
            this.Controls.Add(this.button_empinfo);
            this.Controls.Add(this.button_newward);
            this.Controls.Add(this.button_roominfo);
            this.Controls.Add(this.button_patientcout);
            this.Controls.Add(this.button_patientinfo);
            this.Controls.Add(this.button_patientreg);
            this.Controls.Add(this.label_menu);
            this.Controls.Add(this.panel_admin);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.Button button_patientreg;
        private System.Windows.Forms.Button button_patientinfo;
        private System.Windows.Forms.Button button_patientcout;
        private System.Windows.Forms.Button button_roominfo;
        private System.Windows.Forms.Button button_newward;
        private System.Windows.Forms.Button button_empinfo;
        private System.Windows.Forms.Button button_userinfo;
        private System.Windows.Forms.Button button_newuser;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Panel panel_admin;
    }
}