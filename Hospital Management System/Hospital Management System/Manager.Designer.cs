namespace Hospital_Management_System
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.button_logout = new System.Windows.Forms.Button();
            this.button_reports = new System.Windows.Forms.Button();
            this.button_scheduling = new System.Windows.Forms.Button();
            this.button_addemp = new System.Windows.Forms.Button();
            this.button_salary = new System.Windows.Forms.Button();
            this.label_menu = new System.Windows.Forms.Label();
            this.panel_manager = new System.Windows.Forms.Panel();
            this.button_empinfo = new System.Windows.Forms.Button();
            this.button_roominfo = new System.Windows.Forms.Button();
            this.button_newward = new System.Windows.Forms.Button();
            this.button_patientinfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(65, 580);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(90, 50);
            this.button_logout.TabIndex = 9;
            this.button_logout.Text = "Log Out";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // button_reports
            // 
            this.button_reports.Location = new System.Drawing.Point(30, 349);
            this.button_reports.Name = "button_reports";
            this.button_reports.Size = new System.Drawing.Size(174, 40);
            this.button_reports.TabIndex = 15;
            this.button_reports.Text = "Lab Reports";
            this.button_reports.UseVisualStyleBackColor = true;
            this.button_reports.Click += new System.EventHandler(this.button_reports_Click);
            // 
            // button_scheduling
            // 
            this.button_scheduling.Location = new System.Drawing.Point(30, 263);
            this.button_scheduling.Name = "button_scheduling";
            this.button_scheduling.Size = new System.Drawing.Size(174, 39);
            this.button_scheduling.TabIndex = 16;
            this.button_scheduling.Text = "Scheduling";
            this.button_scheduling.UseVisualStyleBackColor = true;
            this.button_scheduling.Click += new System.EventHandler(this.button_scheduling_Click);
            // 
            // button_addemp
            // 
            this.button_addemp.Location = new System.Drawing.Point(30, 173);
            this.button_addemp.Name = "button_addemp";
            this.button_addemp.Size = new System.Drawing.Size(174, 38);
            this.button_addemp.TabIndex = 8;
            this.button_addemp.Text = "Add Employee";
            this.button_addemp.UseVisualStyleBackColor = true;
            this.button_addemp.Click += new System.EventHandler(this.button_addemp_Click);
            // 
            // button_salary
            // 
            this.button_salary.Location = new System.Drawing.Point(30, 308);
            this.button_salary.Name = "button_salary";
            this.button_salary.Size = new System.Drawing.Size(174, 35);
            this.button_salary.TabIndex = 7;
            this.button_salary.Text = "Salary Details";
            this.button_salary.UseVisualStyleBackColor = true;
            this.button_salary.Click += new System.EventHandler(this.button_salary_Click);
            // 
            // label_menu
            // 
            this.label_menu.AutoSize = true;
            this.label_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu.Location = new System.Drawing.Point(70, 84);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(85, 31);
            this.label_menu.TabIndex = 6;
            this.label_menu.Text = "Menu";
            // 
            // panel_manager
            // 
            this.panel_manager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_manager.Location = new System.Drawing.Point(232, 84);
            this.panel_manager.Name = "panel_manager";
            this.panel_manager.Size = new System.Drawing.Size(800, 560);
            this.panel_manager.TabIndex = 5;
            // 
            // button_empinfo
            // 
            this.button_empinfo.Location = new System.Drawing.Point(30, 217);
            this.button_empinfo.Name = "button_empinfo";
            this.button_empinfo.Size = new System.Drawing.Size(174, 40);
            this.button_empinfo.TabIndex = 17;
            this.button_empinfo.Text = "Employee Information";
            this.button_empinfo.UseVisualStyleBackColor = true;
            this.button_empinfo.Click += new System.EventHandler(this.button_empinfo_Click);
            // 
            // button_roominfo
            // 
            this.button_roominfo.Location = new System.Drawing.Point(30, 395);
            this.button_roominfo.Name = "button_roominfo";
            this.button_roominfo.Size = new System.Drawing.Size(174, 40);
            this.button_roominfo.TabIndex = 18;
            this.button_roominfo.Text = "Room Information";
            this.button_roominfo.UseVisualStyleBackColor = true;
            this.button_roominfo.Click += new System.EventHandler(this.button_roominfo_Click);
            // 
            // button_newward
            // 
            this.button_newward.Location = new System.Drawing.Point(30, 441);
            this.button_newward.Name = "button_newward";
            this.button_newward.Size = new System.Drawing.Size(174, 34);
            this.button_newward.TabIndex = 19;
            this.button_newward.Text = "Add New Ward";
            this.button_newward.UseVisualStyleBackColor = true;
            this.button_newward.Click += new System.EventHandler(this.button_newward_Click);
            // 
            // button_patientinfo
            // 
            this.button_patientinfo.Location = new System.Drawing.Point(30, 481);
            this.button_patientinfo.Name = "button_patientinfo";
            this.button_patientinfo.Size = new System.Drawing.Size(174, 38);
            this.button_patientinfo.TabIndex = 20;
            this.button_patientinfo.Text = "Patient Information";
            this.button_patientinfo.UseVisualStyleBackColor = true;
            this.button_patientinfo.Click += new System.EventHandler(this.button_patientinfo_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.button_patientinfo);
            this.Controls.Add(this.button_newward);
            this.Controls.Add(this.button_roominfo);
            this.Controls.Add(this.button_empinfo);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_reports);
            this.Controls.Add(this.button_scheduling);
            this.Controls.Add(this.button_addemp);
            this.Controls.Add(this.button_salary);
            this.Controls.Add(this.label_menu);
            this.Controls.Add(this.panel_manager);
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_reports;
        private System.Windows.Forms.Button button_scheduling;
        private System.Windows.Forms.Button button_addemp;
        private System.Windows.Forms.Button button_salary;
        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.Panel panel_manager;
        private System.Windows.Forms.Button button_empinfo;
        private System.Windows.Forms.Button button_roominfo;
        private System.Windows.Forms.Button button_newward;
        private System.Windows.Forms.Button button_patientinfo;
    }
}