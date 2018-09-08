namespace Hospital_Management_System
{
    partial class UserControl_Patientinfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.dataGridView_patientList = new System.Windows.Forms.DataGridView();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.groupBox_info = new System.Windows.Forms.GroupBox();
            this.textBox_building = new System.Windows.Forms.TextBox();
            this.textBox_roomtype = new System.Windows.Forms.TextBox();
            this.textBox_roomno = new System.Windows.Forms.TextBox();
            this.textBox_checkin = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.richTextBox_address = new System.Windows.Forms.RichTextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.textBox_gender = new System.Windows.Forms.TextBox();
            this.textBox_pid = new System.Windows.Forms.TextBox();
            this.textBox_rid = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_status = new System.Windows.Forms.TextBox();
            this.textBox_disease = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_patientList)).BeginInit();
            this.groupBox_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input Patient Name";
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(20, 110);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(203, 20);
            this.textBox_input.TabIndex = 3;
            this.textBox_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_input_KeyPress);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(462, 499);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 15;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(567, 499);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 16;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // dataGridView_patientList
            // 
            this.dataGridView_patientList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_patientList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_patientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_patientList.GridColor = System.Drawing.Color.White;
            this.dataGridView_patientList.Location = new System.Drawing.Point(20, 168);
            this.dataGridView_patientList.Name = "dataGridView_patientList";
            this.dataGridView_patientList.RowHeadersVisible = false;
            this.dataGridView_patientList.Size = new System.Drawing.Size(203, 298);
            this.dataGridView_patientList.TabIndex = 17;
            this.dataGridView_patientList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_patientList_CellClick);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(71, 499);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 23);
            this.button_refresh.TabIndex = 18;
            this.button_refresh.Text = "Refresh ";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(671, 499);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 16;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // groupBox_info
            // 
            this.groupBox_info.Controls.Add(this.textBox_building);
            this.groupBox_info.Controls.Add(this.textBox_roomtype);
            this.groupBox_info.Controls.Add(this.textBox_roomno);
            this.groupBox_info.Controls.Add(this.textBox_checkin);
            this.groupBox_info.Controls.Add(this.label14);
            this.groupBox_info.Controls.Add(this.label13);
            this.groupBox_info.Controls.Add(this.label12);
            this.groupBox_info.Controls.Add(this.label11);
            this.groupBox_info.Controls.Add(this.richTextBox_address);
            this.groupBox_info.Controls.Add(this.textBox_phone);
            this.groupBox_info.Controls.Add(this.textBox_age);
            this.groupBox_info.Controls.Add(this.textBox_gender);
            this.groupBox_info.Controls.Add(this.textBox_pid);
            this.groupBox_info.Controls.Add(this.textBox_rid);
            this.groupBox_info.Controls.Add(this.textBox_name);
            this.groupBox_info.Controls.Add(this.textBox_status);
            this.groupBox_info.Controls.Add(this.textBox_disease);
            this.groupBox_info.Controls.Add(this.label10);
            this.groupBox_info.Controls.Add(this.label9);
            this.groupBox_info.Controls.Add(this.label8);
            this.groupBox_info.Controls.Add(this.label7);
            this.groupBox_info.Controls.Add(this.label6);
            this.groupBox_info.Controls.Add(this.label5);
            this.groupBox_info.Controls.Add(this.label15);
            this.groupBox_info.Controls.Add(this.label4);
            this.groupBox_info.Controls.Add(this.label3);
            this.groupBox_info.Location = new System.Drawing.Point(240, 61);
            this.groupBox_info.Name = "groupBox_info";
            this.groupBox_info.Size = new System.Drawing.Size(547, 417);
            this.groupBox_info.TabIndex = 19;
            this.groupBox_info.TabStop = false;
            this.groupBox_info.Text = "Information";
            // 
            // textBox_building
            // 
            this.textBox_building.Location = new System.Drawing.Point(366, 127);
            this.textBox_building.Name = "textBox_building";
            this.textBox_building.Size = new System.Drawing.Size(165, 20);
            this.textBox_building.TabIndex = 40;
            // 
            // textBox_roomtype
            // 
            this.textBox_roomtype.Location = new System.Drawing.Point(366, 95);
            this.textBox_roomtype.Name = "textBox_roomtype";
            this.textBox_roomtype.Size = new System.Drawing.Size(165, 20);
            this.textBox_roomtype.TabIndex = 39;
            // 
            // textBox_roomno
            // 
            this.textBox_roomno.Location = new System.Drawing.Point(366, 69);
            this.textBox_roomno.Name = "textBox_roomno";
            this.textBox_roomno.Size = new System.Drawing.Size(165, 20);
            this.textBox_roomno.TabIndex = 38;
            // 
            // textBox_checkin
            // 
            this.textBox_checkin.Location = new System.Drawing.Point(366, 40);
            this.textBox_checkin.Name = "textBox_checkin";
            this.textBox_checkin.Size = new System.Drawing.Size(165, 20);
            this.textBox_checkin.TabIndex = 37;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(304, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Building";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(304, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Room Type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(304, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Room No";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(304, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Check In";
            // 
            // richTextBox_address
            // 
            this.richTextBox_address.Location = new System.Drawing.Point(115, 244);
            this.richTextBox_address.Name = "richTextBox_address";
            this.richTextBox_address.Size = new System.Drawing.Size(160, 67);
            this.richTextBox_address.TabIndex = 32;
            this.richTextBox_address.Text = "";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(115, 206);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(160, 20);
            this.textBox_phone.TabIndex = 30;
            // 
            // textBox_age
            // 
            this.textBox_age.Location = new System.Drawing.Point(115, 174);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(160, 20);
            this.textBox_age.TabIndex = 29;
            // 
            // textBox_gender
            // 
            this.textBox_gender.Location = new System.Drawing.Point(115, 140);
            this.textBox_gender.Name = "textBox_gender";
            this.textBox_gender.Size = new System.Drawing.Size(160, 20);
            this.textBox_gender.TabIndex = 31;
            // 
            // textBox_pid
            // 
            this.textBox_pid.Location = new System.Drawing.Point(115, 40);
            this.textBox_pid.Name = "textBox_pid";
            this.textBox_pid.Size = new System.Drawing.Size(160, 20);
            this.textBox_pid.TabIndex = 28;
            // 
            // textBox_rid
            // 
            this.textBox_rid.Location = new System.Drawing.Point(115, 71);
            this.textBox_rid.Name = "textBox_rid";
            this.textBox_rid.Size = new System.Drawing.Size(160, 20);
            this.textBox_rid.TabIndex = 27;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(115, 109);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(160, 20);
            this.textBox_name.TabIndex = 26;
            // 
            // textBox_status
            // 
            this.textBox_status.Location = new System.Drawing.Point(115, 357);
            this.textBox_status.Name = "textBox_status";
            this.textBox_status.Size = new System.Drawing.Size(160, 20);
            this.textBox_status.TabIndex = 25;
            // 
            // textBox_disease
            // 
            this.textBox_disease.Location = new System.Drawing.Point(115, 321);
            this.textBox_disease.Name = "textBox_disease";
            this.textBox_disease.Size = new System.Drawing.Size(160, 20);
            this.textBox_disease.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Status of Disease";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Disease";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Gender";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "RID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "PID";
            // 
            // UserControl_Patientinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_info);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.dataGridView_patientList);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_Patientinfo";
            this.Size = new System.Drawing.Size(800, 560);
            this.Load += new System.EventHandler(this.UserControl_Patientinfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_patientList)).EndInit();
            this.groupBox_info.ResumeLayout(false);
            this.groupBox_info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.DataGridView dataGridView_patientList;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.GroupBox groupBox_info;
        private System.Windows.Forms.TextBox textBox_building;
        private System.Windows.Forms.TextBox textBox_roomtype;
        private System.Windows.Forms.TextBox textBox_roomno;
        private System.Windows.Forms.TextBox textBox_checkin;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox richTextBox_address;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.TextBox textBox_gender;
        private System.Windows.Forms.TextBox textBox_pid;
        private System.Windows.Forms.TextBox textBox_rid;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_status;
        private System.Windows.Forms.TextBox textBox_disease;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
