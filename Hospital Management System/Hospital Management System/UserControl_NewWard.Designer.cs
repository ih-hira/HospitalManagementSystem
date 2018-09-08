namespace Hospital_Management_System
{
    partial class UserControl_NewWard
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_close = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.comboBox_roomtype = new System.Windows.Forms.ComboBox();
            this.comboBox_floor = new System.Windows.Forms.ComboBox();
            this.comboBox_building = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_numbed = new System.Windows.Forms.TextBox();
            this.textBox_roomno = new System.Windows.Forms.TextBox();
            this.textBox_unitprice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Add New Ward";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_close);
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Controls.Add(this.comboBox_roomtype);
            this.groupBox1.Controls.Add(this.comboBox_floor);
            this.groupBox1.Controls.Add(this.comboBox_building);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox_numbed);
            this.groupBox1.Controls.Add(this.textBox_roomno);
            this.groupBox1.Controls.Add(this.textBox_unitprice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(123, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 413);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ward";
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(283, 313);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(97, 36);
            this.button_close.TabIndex = 79;
            this.button_close.Text = "CLOSE";
            this.button_close.UseVisualStyleBackColor = true;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(147, 313);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(89, 36);
            this.button_add.TabIndex = 78;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // comboBox_roomtype
            // 
            this.comboBox_roomtype.FormattingEnabled = true;
            this.comboBox_roomtype.Items.AddRange(new object[] {
            "Normal",
            "Medium",
            "VIP"});
            this.comboBox_roomtype.Location = new System.Drawing.Point(220, 161);
            this.comboBox_roomtype.Name = "comboBox_roomtype";
            this.comboBox_roomtype.Size = new System.Drawing.Size(160, 21);
            this.comboBox_roomtype.TabIndex = 75;
            // 
            // comboBox_floor
            // 
            this.comboBox_floor.FormattingEnabled = true;
            this.comboBox_floor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBox_floor.Location = new System.Drawing.Point(220, 99);
            this.comboBox_floor.Name = "comboBox_floor";
            this.comboBox_floor.Size = new System.Drawing.Size(160, 21);
            this.comboBox_floor.TabIndex = 76;
            // 
            // comboBox_building
            // 
            this.comboBox_building.FormattingEnabled = true;
            this.comboBox_building.Items.AddRange(new object[] {
            "A",
            "B"});
            this.comboBox_building.Location = new System.Drawing.Point(220, 67);
            this.comboBox_building.Name = "comboBox_building";
            this.comboBox_building.Size = new System.Drawing.Size(160, 21);
            this.comboBox_building.TabIndex = 77;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(124, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 74;
            this.label9.Text = "Unit Price";
            // 
            // textBox_numbed
            // 
            this.textBox_numbed.Location = new System.Drawing.Point(220, 193);
            this.textBox_numbed.Name = "textBox_numbed";
            this.textBox_numbed.Size = new System.Drawing.Size(160, 20);
            this.textBox_numbed.TabIndex = 72;
            // 
            // textBox_roomno
            // 
            this.textBox_roomno.Location = new System.Drawing.Point(220, 130);
            this.textBox_roomno.Name = "textBox_roomno";
            this.textBox_roomno.Size = new System.Drawing.Size(160, 20);
            this.textBox_roomno.TabIndex = 73;
            // 
            // textBox_unitprice
            // 
            this.textBox_unitprice.Location = new System.Drawing.Point(220, 226);
            this.textBox_unitprice.Name = "textBox_unitprice";
            this.textBox_unitprice.Size = new System.Drawing.Size(160, 20);
            this.textBox_unitprice.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 70;
            this.label7.Text = "Number of Bed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "Room Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Room No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Floor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Building";
            // 
            // UserControl_NewWard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_NewWard";
            this.Size = new System.Drawing.Size(800, 560);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ComboBox comboBox_roomtype;
        private System.Windows.Forms.ComboBox comboBox_floor;
        private System.Windows.Forms.ComboBox comboBox_building;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_numbed;
        private System.Windows.Forms.TextBox textBox_roomno;
        private System.Windows.Forms.TextBox textBox_unitprice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
