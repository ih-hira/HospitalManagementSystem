namespace Hospital_Management_System
{
    partial class UserControl_Checkout
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
            this.button_close = new System.Windows.Forms.Button();
            this.button_submit = new System.Windows.Forms.Button();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_show = new System.Windows.Forms.Button();
            this.dataGridView_patientList = new System.Windows.Forms.DataGridView();
            this.button_refresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_checked = new System.Windows.Forms.TextBox();
            this.textBox_days = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_dateout = new System.Windows.Forms.TextBox();
            this.textBox_datein = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_docCharge = new System.Windows.Forms.TextBox();
            this.textBox_medCharge = new System.Windows.Forms.TextBox();
            this.textBox_service = new System.Windows.Forms.TextBox();
            this.textBox_building = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox_unit = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_roomtype = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_roomno = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.richTextBox_address = new System.Windows.Forms.RichTextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.textBox_gender = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_billid = new System.Windows.Forms.TextBox();
            this.textBox_rid = new System.Windows.Forms.TextBox();
            this.textBox_pid = new System.Windows.Forms.TextBox();
            this.textBox_disease = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_patientList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(594, 522);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 46;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(484, 522);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 23);
            this.button_submit.TabIndex = 45;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(15, 124);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(206, 20);
            this.textBox_input.TabIndex = 19;
            this.textBox_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_input_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Input Patient Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Patient Checkout";
            // 
            // button_show
            // 
            this.button_show.Location = new System.Drawing.Point(368, 522);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(75, 23);
            this.button_show.TabIndex = 46;
            this.button_show.Text = "Show";
            this.button_show.UseVisualStyleBackColor = true;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // dataGridView_patientList
            // 
            this.dataGridView_patientList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_patientList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_patientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_patientList.GridColor = System.Drawing.Color.White;
            this.dataGridView_patientList.Location = new System.Drawing.Point(15, 181);
            this.dataGridView_patientList.Name = "dataGridView_patientList";
            this.dataGridView_patientList.RowHeadersVisible = false;
            this.dataGridView_patientList.Size = new System.Drawing.Size(206, 300);
            this.dataGridView_patientList.TabIndex = 57;
            this.dataGridView_patientList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_patientList_CellClick);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(60, 500);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 23);
            this.button_refresh.TabIndex = 58;
            this.button_refresh.Text = "Refresh ";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_checked);
            this.groupBox1.Controls.Add(this.textBox_days);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.textBox_dateout);
            this.groupBox1.Controls.Add(this.textBox_datein);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.comboBox_status);
            this.groupBox1.Controls.Add(this.textBox_price);
            this.groupBox1.Controls.Add(this.textBox_docCharge);
            this.groupBox1.Controls.Add(this.textBox_medCharge);
            this.groupBox1.Controls.Add(this.textBox_service);
            this.groupBox1.Controls.Add(this.textBox_building);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.textBox_unit);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.textBox_roomtype);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.textBox_roomno);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.richTextBox_address);
            this.groupBox1.Controls.Add(this.textBox_phone);
            this.groupBox1.Controls.Add(this.textBox_age);
            this.groupBox1.Controls.Add(this.textBox_gender);
            this.groupBox1.Controls.Add(this.textBox_name);
            this.groupBox1.Controls.Add(this.textBox_billid);
            this.groupBox1.Controls.Add(this.textBox_rid);
            this.groupBox1.Controls.Add(this.textBox_pid);
            this.groupBox1.Controls.Add(this.textBox_disease);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(242, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 439);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Checkout Information";
            // 
            // textBox_checked
            // 
            this.textBox_checked.Location = new System.Drawing.Point(380, 368);
            this.textBox_checked.Name = "textBox_checked";
            this.textBox_checked.Size = new System.Drawing.Size(147, 20);
            this.textBox_checked.TabIndex = 103;
            // 
            // textBox_days
            // 
            this.textBox_days.Location = new System.Drawing.Point(380, 29);
            this.textBox_days.Name = "textBox_days";
            this.textBox_days.Size = new System.Drawing.Size(147, 20);
            this.textBox_days.TabIndex = 102;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(281, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 13);
            this.label19.TabIndex = 101;
            this.label19.Text = "Number of days";
            // 
            // textBox_dateout
            // 
            this.textBox_dateout.Location = new System.Drawing.Point(94, 392);
            this.textBox_dateout.Name = "textBox_dateout";
            this.textBox_dateout.Size = new System.Drawing.Size(160, 20);
            this.textBox_dateout.TabIndex = 100;
            // 
            // textBox_datein
            // 
            this.textBox_datein.Location = new System.Drawing.Point(94, 363);
            this.textBox_datein.Name = "textBox_datein";
            this.textBox_datein.Size = new System.Drawing.Size(160, 20);
            this.textBox_datein.TabIndex = 99;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 392);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 98;
            this.label12.Text = "Date Out";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 97;
            this.label11.Text = "Date In";
            // 
            // comboBox_status
            // 
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Items.AddRange(new object[] {
            "Serious",
            "Well",
            "Under Rest"});
            this.comboBox_status.Location = new System.Drawing.Point(380, 208);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(147, 21);
            this.comboBox_status.TabIndex = 96;
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(380, 336);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(147, 20);
            this.textBox_price.TabIndex = 89;
            // 
            // textBox_docCharge
            // 
            this.textBox_docCharge.Location = new System.Drawing.Point(380, 294);
            this.textBox_docCharge.Name = "textBox_docCharge";
            this.textBox_docCharge.Size = new System.Drawing.Size(147, 20);
            this.textBox_docCharge.TabIndex = 91;
            // 
            // textBox_medCharge
            // 
            this.textBox_medCharge.Location = new System.Drawing.Point(380, 268);
            this.textBox_medCharge.Name = "textBox_medCharge";
            this.textBox_medCharge.Size = new System.Drawing.Size(147, 20);
            this.textBox_medCharge.TabIndex = 90;
            // 
            // textBox_service
            // 
            this.textBox_service.Location = new System.Drawing.Point(380, 239);
            this.textBox_service.Name = "textBox_service";
            this.textBox_service.Size = new System.Drawing.Size(147, 20);
            this.textBox_service.TabIndex = 95;
            // 
            // textBox_building
            // 
            this.textBox_building.Location = new System.Drawing.Point(380, 175);
            this.textBox_building.Name = "textBox_building";
            this.textBox_building.Size = new System.Drawing.Size(147, 20);
            this.textBox_building.TabIndex = 92;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(279, 296);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 13);
            this.label21.TabIndex = 87;
            this.label21.Text = "Doctor Charge";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(281, 335);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 86;
            this.label18.Text = "Total Price";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(279, 270);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 13);
            this.label20.TabIndex = 85;
            this.label20.Text = "Medicine Charge";
            // 
            // textBox_unit
            // 
            this.textBox_unit.Location = new System.Drawing.Point(380, 138);
            this.textBox_unit.Name = "textBox_unit";
            this.textBox_unit.Size = new System.Drawing.Size(147, 20);
            this.textBox_unit.TabIndex = 93;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(279, 241);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 13);
            this.label17.TabIndex = 84;
            this.label17.Text = "Service Charge";
            // 
            // textBox_roomtype
            // 
            this.textBox_roomtype.Location = new System.Drawing.Point(380, 105);
            this.textBox_roomtype.Name = "textBox_roomtype";
            this.textBox_roomtype.Size = new System.Drawing.Size(147, 20);
            this.textBox_roomtype.TabIndex = 94;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(281, 212);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 83;
            this.label16.Text = "Status";
            // 
            // textBox_roomno
            // 
            this.textBox_roomno.Location = new System.Drawing.Point(380, 73);
            this.textBox_roomno.Name = "textBox_roomno";
            this.textBox_roomno.Size = new System.Drawing.Size(147, 20);
            this.textBox_roomno.TabIndex = 88;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(281, 178);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 82;
            this.label15.Text = "Building";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(281, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 81;
            this.label10.Text = "Unit Price";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(281, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 80;
            this.label14.Text = "Room Type";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(281, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 79;
            this.label13.Text = "Room No";
            // 
            // richTextBox_address
            // 
            this.richTextBox_address.Location = new System.Drawing.Point(94, 247);
            this.richTextBox_address.Name = "richTextBox_address";
            this.richTextBox_address.Size = new System.Drawing.Size(160, 67);
            this.richTextBox_address.TabIndex = 78;
            this.richTextBox_address.Text = "";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(94, 209);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(160, 20);
            this.textBox_phone.TabIndex = 76;
            // 
            // textBox_age
            // 
            this.textBox_age.Location = new System.Drawing.Point(94, 177);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(160, 20);
            this.textBox_age.TabIndex = 75;
            // 
            // textBox_gender
            // 
            this.textBox_gender.Location = new System.Drawing.Point(94, 143);
            this.textBox_gender.Name = "textBox_gender";
            this.textBox_gender.Size = new System.Drawing.Size(160, 20);
            this.textBox_gender.TabIndex = 77;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(94, 112);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(160, 20);
            this.textBox_name.TabIndex = 74;
            // 
            // textBox_billid
            // 
            this.textBox_billid.Location = new System.Drawing.Point(94, 26);
            this.textBox_billid.Name = "textBox_billid";
            this.textBox_billid.Size = new System.Drawing.Size(160, 20);
            this.textBox_billid.TabIndex = 71;
            // 
            // textBox_rid
            // 
            this.textBox_rid.Location = new System.Drawing.Point(94, 78);
            this.textBox_rid.Name = "textBox_rid";
            this.textBox_rid.Size = new System.Drawing.Size(160, 20);
            this.textBox_rid.TabIndex = 72;
            // 
            // textBox_pid
            // 
            this.textBox_pid.Location = new System.Drawing.Point(94, 52);
            this.textBox_pid.Name = "textBox_pid";
            this.textBox_pid.Size = new System.Drawing.Size(160, 20);
            this.textBox_pid.TabIndex = 73;
            // 
            // textBox_disease
            // 
            this.textBox_disease.Location = new System.Drawing.Point(94, 324);
            this.textBox_disease.Name = "textBox_disease";
            this.textBox_disease.Size = new System.Drawing.Size(160, 20);
            this.textBox_disease.TabIndex = 70;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 69;
            this.label9.Text = "Disease";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Gender";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(11, 29);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 13);
            this.label22.TabIndex = 63;
            this.label22.Text = "Bill ID";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(11, 81);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(26, 13);
            this.label23.TabIndex = 62;
            this.label23.Text = "RID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "PID";
            // 
            // UserControl_Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.dataGridView_patientList);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_Checkout";
            this.Size = new System.Drawing.Size(800, 560);
            this.Load += new System.EventHandler(this.UserControl_Checkout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_patientList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.DataGridView dataGridView_patientList;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_checked;
        private System.Windows.Forms.TextBox textBox_days;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox_dateout;
        private System.Windows.Forms.TextBox textBox_datein;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_docCharge;
        private System.Windows.Forms.TextBox textBox_medCharge;
        private System.Windows.Forms.TextBox textBox_service;
        private System.Windows.Forms.TextBox textBox_building;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox_unit;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_roomtype;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_roomno;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox richTextBox_address;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.TextBox textBox_gender;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_billid;
        private System.Windows.Forms.TextBox textBox_rid;
        private System.Windows.Forms.TextBox textBox_pid;
        private System.Windows.Forms.TextBox textBox_disease;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
