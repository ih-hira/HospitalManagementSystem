using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;

namespace Hospital_Management_System
{
    public partial class UserControl_Patientreg : UserControl
    {
        private Label label1;
        private GroupBox groupBox_regid;
        private BackgroundWorker backgroundWorker1;
        private GroupBox groupBox_pinfo;
        private GroupBox groupBox_roomtype;
        private GroupBox groupBox_roominfo;
        private Button button_add;
        private Button button_close;
        private Label label3;
        private Label label2;
        private TextBox textBox_number;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox_pid;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private RadioButton radioButton_normal;
        private RadioButton radioButton_medium;
        private RadioButton radioButton_vip;
        private TextBox textBox_status;
        private TextBox textBox_disease;
        private Label label11;
        private Label label10;
        private RichTextBox richTextBox_address;
        private ComboBox comboBox_gender;
        private TextBox textBox_phone;
        private TextBox textBox_age;
        private TextBox textBox_name;
        private ComboBox comboBox_building;
        private Label label13;
        private Label label12;
        private static UserControl_Patientreg _instance;

        public static UserControl_Patientreg Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_Patientreg();
                return _instance;
            }

        }

        public UserControl_Patientreg()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_regid = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox_pinfo = new System.Windows.Forms.GroupBox();
            this.textBox_status = new System.Windows.Forms.TextBox();
            this.textBox_disease = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBox_address = new System.Windows.Forms.RichTextBox();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_pid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_roomtype = new System.Windows.Forms.GroupBox();
            this.radioButton_normal = new System.Windows.Forms.RadioButton();
            this.radioButton_medium = new System.Windows.Forms.RadioButton();
            this.radioButton_vip = new System.Windows.Forms.RadioButton();
            this.groupBox_roominfo = new System.Windows.Forms.GroupBox();
            this.textBox_roomno = new System.Windows.Forms.TextBox();
            this.comboBox_building = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.groupBox_regid.SuspendLayout();
            this.groupBox_pinfo.SuspendLayout();
            this.groupBox_roomtype.SuspendLayout();
            this.groupBox_roominfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pateint Registration";
            // 
            // groupBox_regid
            // 
            this.groupBox_regid.Controls.Add(this.dateTimePicker1);
            this.groupBox_regid.Controls.Add(this.textBox_number);
            this.groupBox_regid.Controls.Add(this.label3);
            this.groupBox_regid.Controls.Add(this.label2);
            this.groupBox_regid.Location = new System.Drawing.Point(20, 67);
            this.groupBox_regid.Name = "groupBox_regid";
            this.groupBox_regid.Size = new System.Drawing.Size(272, 100);
            this.groupBox_regid.TabIndex = 1;
            this.groupBox_regid.TabStop = false;
            this.groupBox_regid.Text = "Registration ID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(72, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // textBox_number
            // 
            this.textBox_number.Location = new System.Drawing.Point(72, 23);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(182, 20);
            this.textBox_number.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number";
            // 
            // groupBox_pinfo
            // 
            this.groupBox_pinfo.Controls.Add(this.textBox_status);
            this.groupBox_pinfo.Controls.Add(this.textBox_disease);
            this.groupBox_pinfo.Controls.Add(this.label11);
            this.groupBox_pinfo.Controls.Add(this.label10);
            this.groupBox_pinfo.Controls.Add(this.richTextBox_address);
            this.groupBox_pinfo.Controls.Add(this.comboBox_gender);
            this.groupBox_pinfo.Controls.Add(this.textBox_phone);
            this.groupBox_pinfo.Controls.Add(this.textBox_age);
            this.groupBox_pinfo.Controls.Add(this.textBox_name);
            this.groupBox_pinfo.Controls.Add(this.textBox_pid);
            this.groupBox_pinfo.Controls.Add(this.label9);
            this.groupBox_pinfo.Controls.Add(this.label8);
            this.groupBox_pinfo.Controls.Add(this.label7);
            this.groupBox_pinfo.Controls.Add(this.label6);
            this.groupBox_pinfo.Controls.Add(this.label5);
            this.groupBox_pinfo.Controls.Add(this.label4);
            this.groupBox_pinfo.Location = new System.Drawing.Point(20, 175);
            this.groupBox_pinfo.Name = "groupBox_pinfo";
            this.groupBox_pinfo.Size = new System.Drawing.Size(395, 360);
            this.groupBox_pinfo.TabIndex = 2;
            this.groupBox_pinfo.TabStop = false;
            this.groupBox_pinfo.Text = "Patient\'s Information";
            // 
            // textBox_status
            // 
            this.textBox_status.Location = new System.Drawing.Point(120, 313);
            this.textBox_status.Name = "textBox_status";
            this.textBox_status.Size = new System.Drawing.Size(182, 20);
            this.textBox_status.TabIndex = 13;
            // 
            // textBox_disease
            // 
            this.textBox_disease.Location = new System.Drawing.Point(120, 274);
            this.textBox_disease.Name = "textBox_disease";
            this.textBox_disease.Size = new System.Drawing.Size(182, 20);
            this.textBox_disease.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Status of Disease";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Disease";
            // 
            // richTextBox_address
            // 
            this.richTextBox_address.Location = new System.Drawing.Point(120, 176);
            this.richTextBox_address.Name = "richTextBox_address";
            this.richTextBox_address.Size = new System.Drawing.Size(182, 73);
            this.richTextBox_address.TabIndex = 10;
            this.richTextBox_address.Text = "";
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.comboBox_gender.Location = new System.Drawing.Point(120, 90);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(182, 21);
            this.comboBox_gender.TabIndex = 9;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(120, 149);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(182, 20);
            this.textBox_phone.TabIndex = 8;
            // 
            // textBox_age
            // 
            this.textBox_age.Location = new System.Drawing.Point(120, 119);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(182, 20);
            this.textBox_age.TabIndex = 8;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(120, 58);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(182, 20);
            this.textBox_name.TabIndex = 8;
            // 
            // textBox_pid
            // 
            this.textBox_pid.Location = new System.Drawing.Point(120, 32);
            this.textBox_pid.Name = "textBox_pid";
            this.textBox_pid.Size = new System.Drawing.Size(182, 20);
            this.textBox_pid.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Age";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "PID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name";
            // 
            // groupBox_roomtype
            // 
            this.groupBox_roomtype.Controls.Add(this.radioButton_normal);
            this.groupBox_roomtype.Controls.Add(this.radioButton_medium);
            this.groupBox_roomtype.Controls.Add(this.radioButton_vip);
            this.groupBox_roomtype.Location = new System.Drawing.Point(317, 67);
            this.groupBox_roomtype.Name = "groupBox_roomtype";
            this.groupBox_roomtype.Size = new System.Drawing.Size(98, 100);
            this.groupBox_roomtype.TabIndex = 2;
            this.groupBox_roomtype.TabStop = false;
            this.groupBox_roomtype.Text = "Room Type";
            // 
            // radioButton_normal
            // 
            this.radioButton_normal.AutoSize = true;
            this.radioButton_normal.Location = new System.Drawing.Point(7, 24);
            this.radioButton_normal.Name = "radioButton_normal";
            this.radioButton_normal.Size = new System.Drawing.Size(58, 17);
            this.radioButton_normal.TabIndex = 4;
            this.radioButton_normal.TabStop = true;
            this.radioButton_normal.Text = "Normal";
            this.radioButton_normal.UseVisualStyleBackColor = true;
            // 
            // radioButton_medium
            // 
            this.radioButton_medium.AutoSize = true;
            this.radioButton_medium.Location = new System.Drawing.Point(7, 47);
            this.radioButton_medium.Name = "radioButton_medium";
            this.radioButton_medium.Size = new System.Drawing.Size(62, 17);
            this.radioButton_medium.TabIndex = 0;
            this.radioButton_medium.TabStop = true;
            this.radioButton_medium.Text = "Medium";
            this.radioButton_medium.UseVisualStyleBackColor = true;
            // 
            // radioButton_vip
            // 
            this.radioButton_vip.AutoSize = true;
            this.radioButton_vip.Location = new System.Drawing.Point(7, 70);
            this.radioButton_vip.Name = "radioButton_vip";
            this.radioButton_vip.Size = new System.Drawing.Size(42, 17);
            this.radioButton_vip.TabIndex = 0;
            this.radioButton_vip.TabStop = true;
            this.radioButton_vip.Text = "VIP";
            this.radioButton_vip.UseVisualStyleBackColor = true;
            // 
            // groupBox_roominfo
            // 
            this.groupBox_roominfo.Controls.Add(this.textBox_roomno);
            this.groupBox_roominfo.Controls.Add(this.comboBox_building);
            this.groupBox_roominfo.Controls.Add(this.label13);
            this.groupBox_roominfo.Controls.Add(this.label12);
            this.groupBox_roominfo.Location = new System.Drawing.Point(509, 67);
            this.groupBox_roominfo.Name = "groupBox_roominfo";
            this.groupBox_roominfo.Size = new System.Drawing.Size(254, 121);
            this.groupBox_roominfo.TabIndex = 2;
            this.groupBox_roominfo.TabStop = false;
            this.groupBox_roominfo.Text = "Room Information";
            // 
            // textBox_roomno
            // 
            this.textBox_roomno.Location = new System.Drawing.Point(102, 79);
            this.textBox_roomno.Name = "textBox_roomno";
            this.textBox_roomno.Size = new System.Drawing.Size(131, 20);
            this.textBox_roomno.TabIndex = 11;
            // 
            // comboBox_building
            // 
            this.comboBox_building.FormattingEnabled = true;
            this.comboBox_building.Items.AddRange(new object[] {
            "A",
            "B"});
            this.comboBox_building.Location = new System.Drawing.Point(102, 47);
            this.comboBox_building.Name = "comboBox_building";
            this.comboBox_building.Size = new System.Drawing.Size(131, 21);
            this.comboBox_building.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Room No";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Building";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(548, 384);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(651, 384);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 5;
            this.button_close.Text = "CLOSE";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // UserControl_Patientreg
            // 
            this.Controls.Add(this.groupBox_roomtype);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.groupBox_roominfo);
            this.Controls.Add(this.groupBox_pinfo);
            this.Controls.Add(this.groupBox_regid);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_Patientreg";
            this.Size = new System.Drawing.Size(800, 560);
            this.groupBox_regid.ResumeLayout(false);
            this.groupBox_regid.PerformLayout();
            this.groupBox_pinfo.ResumeLayout(false);
            this.groupBox_pinfo.PerformLayout();
            this.groupBox_roomtype.ResumeLayout(false);
            this.groupBox_roomtype.PerformLayout();
            this.groupBox_roominfo.ResumeLayout(false);
            this.groupBox_roominfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            ArrayList patientInfo = new ArrayList();
            

            patientInfo.Add(textBox_number.Text);
            patientInfo.Add(dateTimePicker1.Text);
            if (radioButton_normal.Checked)
            {
                patientInfo.Add("Normal");
                
            }
            else if (radioButton_medium.Checked)
            {
                patientInfo.Add("Medium");
                
            }
            else if(radioButton_vip.Checked)
            {
                patientInfo.Add("VIP");
                
            }
            patientInfo.Add(textBox_pid.Text);
            patientInfo.Add(textBox_name.Text);
            patientInfo.Add(comboBox_gender.Text);
            patientInfo.Add(textBox_age.Text);
            patientInfo.Add(textBox_phone.Text);
            patientInfo.Add(richTextBox_address.Text);
            patientInfo.Add(textBox_disease.Text);
            patientInfo.Add(textBox_status.Text);
            patientInfo.Add(comboBox_building.Text);
            patientInfo.Add(textBox_roomno.Text);


            DatabaseHelperClass ob = new DatabaseHelperClass(patientInfo);
            if (ob.insertData())
            {
                MessageBox.Show("Patient Added");
            }
            else
            {
                MessageBox.Show("Error Adding Patient");
            }

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
            _instance = null;

        }
    }
}
