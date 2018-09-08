namespace Hospital_Management_System
{
    partial class Receptionist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receptionist));
            this.button_addapp = new System.Windows.Forms.Button();
            this.label_menu = new System.Windows.Forms.Label();
            this.panel_receptionist = new System.Windows.Forms.Panel();
            this.button_doctorSchedule = new System.Windows.Forms.Button();
            this.button_reports = new System.Windows.Forms.Button();
            this.button_blood = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_roominfo = new System.Windows.Forms.Button();
            this.button_showapp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_addapp
            // 
            this.button_addapp.Location = new System.Drawing.Point(38, 127);
            this.button_addapp.Name = "button_addapp";
            this.button_addapp.Size = new System.Drawing.Size(174, 35);
            this.button_addapp.TabIndex = 6;
            this.button_addapp.Text = "Add Appointment";
            this.button_addapp.UseVisualStyleBackColor = true;
            this.button_addapp.Click += new System.EventHandler(this.button_addapp_Click);
            // 
            // label_menu
            // 
            this.label_menu.AutoSize = true;
            this.label_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu.Location = new System.Drawing.Point(78, 79);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(85, 31);
            this.label_menu.TabIndex = 5;
            this.label_menu.Text = "Menu";
            // 
            // panel_receptionist
            // 
            this.panel_receptionist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_receptionist.Location = new System.Drawing.Point(239, 79);
            this.panel_receptionist.Name = "panel_receptionist";
            this.panel_receptionist.Size = new System.Drawing.Size(800, 560);
            this.panel_receptionist.TabIndex = 11;
            // 
            // button_doctorSchedule
            // 
            this.button_doctorSchedule.Location = new System.Drawing.Point(38, 209);
            this.button_doctorSchedule.Name = "button_doctorSchedule";
            this.button_doctorSchedule.Size = new System.Drawing.Size(174, 35);
            this.button_doctorSchedule.TabIndex = 6;
            this.button_doctorSchedule.Text = "Doctor Schedule";
            this.button_doctorSchedule.UseVisualStyleBackColor = true;
            this.button_doctorSchedule.Click += new System.EventHandler(this.button_doctorSchedule_Click);
            // 
            // button_reports
            // 
            this.button_reports.Location = new System.Drawing.Point(38, 250);
            this.button_reports.Name = "button_reports";
            this.button_reports.Size = new System.Drawing.Size(174, 35);
            this.button_reports.TabIndex = 6;
            this.button_reports.Text = "Reports";
            this.button_reports.UseVisualStyleBackColor = true;
            this.button_reports.Click += new System.EventHandler(this.button_reports_Click);
            // 
            // button_blood
            // 
            this.button_blood.Location = new System.Drawing.Point(38, 291);
            this.button_blood.Name = "button_blood";
            this.button_blood.Size = new System.Drawing.Size(174, 35);
            this.button_blood.TabIndex = 6;
            this.button_blood.Text = "Blood Bank";
            this.button_blood.UseVisualStyleBackColor = true;
            this.button_blood.Click += new System.EventHandler(this.button_blood_Click);
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(60, 493);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(122, 52);
            this.button_logout.TabIndex = 12;
            this.button_logout.Text = "Log Out";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // button_roominfo
            // 
            this.button_roominfo.Location = new System.Drawing.Point(38, 332);
            this.button_roominfo.Name = "button_roominfo";
            this.button_roominfo.Size = new System.Drawing.Size(174, 40);
            this.button_roominfo.TabIndex = 13;
            this.button_roominfo.Text = "Room Information";
            this.button_roominfo.UseVisualStyleBackColor = true;
            this.button_roominfo.Click += new System.EventHandler(this.button_roominfo_Click);
            // 
            // button_showapp
            // 
            this.button_showapp.Location = new System.Drawing.Point(38, 168);
            this.button_showapp.Name = "button_showapp";
            this.button_showapp.Size = new System.Drawing.Size(174, 35);
            this.button_showapp.TabIndex = 6;
            this.button_showapp.Text = "Show Appointment";
            this.button_showapp.UseVisualStyleBackColor = true;
            this.button_showapp.Click += new System.EventHandler(this.button_showapp_Click);
            // 
            // Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.button_roominfo);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.panel_receptionist);
            this.Controls.Add(this.button_blood);
            this.Controls.Add(this.button_reports);
            this.Controls.Add(this.button_doctorSchedule);
            this.Controls.Add(this.button_showapp);
            this.Controls.Add(this.button_addapp);
            this.Controls.Add(this.label_menu);
            this.Name = "Receptionist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receptionist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_addapp;
        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.Panel panel_receptionist;
        private System.Windows.Forms.Button button_doctorSchedule;
        private System.Windows.Forms.Button button_reports;
        private System.Windows.Forms.Button button_blood;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_roominfo;
        private System.Windows.Forms.Button button_showapp;
    }
}