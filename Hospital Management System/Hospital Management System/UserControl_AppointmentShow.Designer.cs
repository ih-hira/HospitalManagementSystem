namespace Hospital_Management_System
{
    partial class UserControl_AppointmentShow
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_givenName = new System.Windows.Forms.TextBox();
            this.dataGridView_patientList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_appoid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_patientName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_gender = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_roomno = new System.Windows.Forms.TextBox();
            this.textBox_disease = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_docid = new System.Windows.Forms.TextBox();
            this.richTextBox_add = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_docname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_patientList)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Show Appointments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Input Patient Name";
            // 
            // textBox_givenName
            // 
            this.textBox_givenName.Location = new System.Drawing.Point(21, 129);
            this.textBox_givenName.Name = "textBox_givenName";
            this.textBox_givenName.Size = new System.Drawing.Size(212, 20);
            this.textBox_givenName.TabIndex = 10;
            this.textBox_givenName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_givenName_KeyPress);
            // 
            // dataGridView_patientList
            // 
            this.dataGridView_patientList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_patientList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_patientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_patientList.Location = new System.Drawing.Point(21, 178);
            this.dataGridView_patientList.Name = "dataGridView_patientList";
            this.dataGridView_patientList.RowHeadersVisible = false;
            this.dataGridView_patientList.Size = new System.Drawing.Size(212, 280);
            this.dataGridView_patientList.TabIndex = 11;
            this.dataGridView_patientList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_patientList_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Appointment ID";
            // 
            // textBox_appoid
            // 
            this.textBox_appoid.Location = new System.Drawing.Point(360, 125);
            this.textBox_appoid.Name = "textBox_appoid";
            this.textBox_appoid.Size = new System.Drawing.Size(161, 20);
            this.textBox_appoid.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Patient Name";
            // 
            // textBox_patientName
            // 
            this.textBox_patientName.Location = new System.Drawing.Point(360, 161);
            this.textBox_patientName.Name = "textBox_patientName";
            this.textBox_patientName.Size = new System.Drawing.Size(161, 20);
            this.textBox_patientName.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Gender";
            // 
            // textBox_gender
            // 
            this.textBox_gender.Location = new System.Drawing.Point(360, 197);
            this.textBox_gender.Name = "textBox_gender";
            this.textBox_gender.Size = new System.Drawing.Size(161, 20);
            this.textBox_gender.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Age";
            // 
            // textBox_age
            // 
            this.textBox_age.Location = new System.Drawing.Point(360, 235);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(161, 20);
            this.textBox_age.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Phone";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(360, 267);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(161, 20);
            this.textBox_phone.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(541, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Room No";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(274, 423);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Disease";
            // 
            // textBox_roomno
            // 
            this.textBox_roomno.Location = new System.Drawing.Point(617, 197);
            this.textBox_roomno.Name = "textBox_roomno";
            this.textBox_roomno.Size = new System.Drawing.Size(161, 20);
            this.textBox_roomno.TabIndex = 13;
            // 
            // textBox_disease
            // 
            this.textBox_disease.Location = new System.Drawing.Point(360, 423);
            this.textBox_disease.Name = "textBox_disease";
            this.textBox_disease.Size = new System.Drawing.Size(161, 20);
            this.textBox_disease.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(541, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Doctor ID";
            // 
            // textBox_docid
            // 
            this.textBox_docid.Location = new System.Drawing.Point(617, 125);
            this.textBox_docid.Name = "textBox_docid";
            this.textBox_docid.Size = new System.Drawing.Size(161, 20);
            this.textBox_docid.TabIndex = 13;
            // 
            // richTextBox_add
            // 
            this.richTextBox_add.Location = new System.Drawing.Point(360, 305);
            this.richTextBox_add.Name = "richTextBox_add";
            this.richTextBox_add.Size = new System.Drawing.Size(161, 96);
            this.richTextBox_add.TabIndex = 14;
            this.richTextBox_add.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(541, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Date";
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(617, 238);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(161, 20);
            this.textBox_date.TabIndex = 13;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(446, 498);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 15;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(567, 498);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 15;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(675, 498);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 15;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(83, 478);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 23);
            this.button_refresh.TabIndex = 16;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(541, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Doctor Name";
            // 
            // textBox_docname
            // 
            this.textBox_docname.Location = new System.Drawing.Point(617, 162);
            this.textBox_docname.Name = "textBox_docname";
            this.textBox_docname.Size = new System.Drawing.Size(161, 20);
            this.textBox_docname.TabIndex = 13;
            // 
            // UserControl_AppointmentShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.richTextBox_add);
            this.Controls.Add(this.textBox_docname);
            this.Controls.Add(this.textBox_docid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_gender);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_disease);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_date);
            this.Controls.Add(this.textBox_roomno);
            this.Controls.Add(this.textBox_patientName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_age);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_appoid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_patientList);
            this.Controls.Add(this.textBox_givenName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "UserControl_AppointmentShow";
            this.Size = new System.Drawing.Size(790, 560);
            this.Load += new System.EventHandler(this.UserControl_AppointmentShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_patientList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_givenName;
        private System.Windows.Forms.DataGridView dataGridView_patientList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_appoid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_patientName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_gender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_roomno;
        private System.Windows.Forms.TextBox textBox_disease;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_docid;
        private System.Windows.Forms.RichTextBox richTextBox_add;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_docname;
    }
}
