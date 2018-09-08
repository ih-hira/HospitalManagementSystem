namespace Hospital_Management_System
{
    partial class UserControl_Roominfo
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
            this.button_delete = new System.Windows.Forms.Button();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_numbed = new System.Windows.Forms.TextBox();
            this.textBox_roomtype = new System.Windows.Forms.TextBox();
            this.textBox_roomno = new System.Windows.Forms.TextBox();
            this.textBox_building = new System.Windows.Forms.TextBox();
            this.textBox_status = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.button_show = new System.Windows.Forms.Button();
            this.dataGridView_roomList = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_floorno = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_roomtype = new System.Windows.Forms.GroupBox();
            this.radioButton_normal = new System.Windows.Forms.RadioButton();
            this.radioButton_medium = new System.Windows.Forms.RadioButton();
            this.radioButton_vip = new System.Windows.Forms.RadioButton();
            this.comboBox_building = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_roomList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox_roomtype.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(482, 469);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 46;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(385, 469);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 45;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(591, 290);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(160, 20);
            this.textBox_price.TabIndex = 34;
            // 
            // textBox_numbed
            // 
            this.textBox_numbed.Location = new System.Drawing.Point(591, 264);
            this.textBox_numbed.Name = "textBox_numbed";
            this.textBox_numbed.Size = new System.Drawing.Size(160, 20);
            this.textBox_numbed.TabIndex = 33;
            // 
            // textBox_roomtype
            // 
            this.textBox_roomtype.Location = new System.Drawing.Point(591, 238);
            this.textBox_roomtype.Name = "textBox_roomtype";
            this.textBox_roomtype.Size = new System.Drawing.Size(160, 20);
            this.textBox_roomtype.TabIndex = 35;
            // 
            // textBox_roomno
            // 
            this.textBox_roomno.Location = new System.Drawing.Point(591, 186);
            this.textBox_roomno.Name = "textBox_roomno";
            this.textBox_roomno.Size = new System.Drawing.Size(160, 20);
            this.textBox_roomno.TabIndex = 32;
            // 
            // textBox_building
            // 
            this.textBox_building.Location = new System.Drawing.Point(591, 160);
            this.textBox_building.Name = "textBox_building";
            this.textBox_building.Size = new System.Drawing.Size(160, 20);
            this.textBox_building.TabIndex = 31;
            // 
            // textBox_status
            // 
            this.textBox_status.Location = new System.Drawing.Point(591, 316);
            this.textBox_status.Name = "textBox_status";
            this.textBox_status.Size = new System.Drawing.Size(160, 20);
            this.textBox_status.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(495, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Number of Bed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Room Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Room No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Building";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Room Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Room No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(495, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Status";
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(287, 469);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 52;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_show
            // 
            this.button_show.Location = new System.Drawing.Point(189, 469);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(75, 23);
            this.button_show.TabIndex = 51;
            this.button_show.Text = "Show";
            this.button_show.UseVisualStyleBackColor = true;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // dataGridView_roomList
            // 
            this.dataGridView_roomList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_roomList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_roomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_roomList.ColumnHeadersVisible = false;
            this.dataGridView_roomList.GridColor = System.Drawing.Color.White;
            this.dataGridView_roomList.Location = new System.Drawing.Point(273, 115);
            this.dataGridView_roomList.Name = "dataGridView_roomList";
            this.dataGridView_roomList.RowHeadersVisible = false;
            this.dataGridView_roomList.Size = new System.Drawing.Size(150, 313);
            this.dataGridView_roomList.TabIndex = 58;
            this.dataGridView_roomList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_roomList_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(495, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Floor No";
            // 
            // textBox_floorno
            // 
            this.textBox_floorno.Location = new System.Drawing.Point(591, 212);
            this.textBox_floorno.Name = "textBox_floorno";
            this.textBox_floorno.Size = new System.Drawing.Size(160, 20);
            this.textBox_floorno.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox_roomtype);
            this.groupBox1.Controls.Add(this.comboBox_building);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 307);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // groupBox_roomtype
            // 
            this.groupBox_roomtype.Controls.Add(this.radioButton_normal);
            this.groupBox_roomtype.Controls.Add(this.radioButton_medium);
            this.groupBox_roomtype.Controls.Add(this.radioButton_vip);
            this.groupBox_roomtype.Location = new System.Drawing.Point(21, 111);
            this.groupBox_roomtype.Name = "groupBox_roomtype";
            this.groupBox_roomtype.Size = new System.Drawing.Size(129, 108);
            this.groupBox_roomtype.TabIndex = 52;
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
            // comboBox_building
            // 
            this.comboBox_building.FormattingEnabled = true;
            this.comboBox_building.Items.AddRange(new object[] {
            "A",
            "B"});
            this.comboBox_building.Location = new System.Drawing.Point(21, 64);
            this.comboBox_building.Name = "comboBox_building";
            this.comboBox_building.Size = new System.Drawing.Size(129, 21);
            this.comboBox_building.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Building";
            // 
            // UserControl_Roominfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_roomList);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_numbed);
            this.Controls.Add(this.textBox_roomtype);
            this.Controls.Add(this.textBox_floorno);
            this.Controls.Add(this.textBox_roomno);
            this.Controls.Add(this.textBox_building);
            this.Controls.Add(this.textBox_status);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_Roominfo";
            this.Size = new System.Drawing.Size(800, 560);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_roomList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_roomtype.ResumeLayout(false);
            this.groupBox_roomtype.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_numbed;
        private System.Windows.Forms.TextBox textBox_roomtype;
        private System.Windows.Forms.TextBox textBox_roomno;
        private System.Windows.Forms.TextBox textBox_building;
        private System.Windows.Forms.TextBox textBox_status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.DataGridView dataGridView_roomList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_floorno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_roomtype;
        private System.Windows.Forms.RadioButton radioButton_normal;
        private System.Windows.Forms.RadioButton radioButton_medium;
        private System.Windows.Forms.RadioButton radioButton_vip;
        private System.Windows.Forms.ComboBox comboBox_building;
        private System.Windows.Forms.Label label2;
    }
}
