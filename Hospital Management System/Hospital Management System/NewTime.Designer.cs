namespace Hospital_Management_System
{
    partial class NewTime
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
            this.comboBox_jobtitle = new System.Windows.Forms.ComboBox();
            this.button_close = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_days = new System.Windows.Forms.TextBox();
            this.textBox_etime = new System.Windows.Forms.TextBox();
            this.textBox_stime = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_jobtitle
            // 
            this.comboBox_jobtitle.FormattingEnabled = true;
            this.comboBox_jobtitle.Items.AddRange(new object[] {
            "Doctor",
            "Receptionist",
            "Nurse",
            "Stuff"});
            this.comboBox_jobtitle.Location = new System.Drawing.Point(226, 118);
            this.comboBox_jobtitle.Name = "comboBox_jobtitle";
            this.comboBox_jobtitle.Size = new System.Drawing.Size(142, 21);
            this.comboBox_jobtitle.TabIndex = 80;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(281, 267);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 79;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(191, 267);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 78;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "End Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(127, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "Start Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Job Title";
            // 
            // textBox_days
            // 
            this.textBox_days.Location = new System.Drawing.Point(226, 197);
            this.textBox_days.Name = "textBox_days";
            this.textBox_days.Size = new System.Drawing.Size(142, 20);
            this.textBox_days.TabIndex = 74;
            // 
            // textBox_etime
            // 
            this.textBox_etime.Location = new System.Drawing.Point(226, 171);
            this.textBox_etime.Name = "textBox_etime";
            this.textBox_etime.Size = new System.Drawing.Size(142, 20);
            this.textBox_etime.TabIndex = 76;
            // 
            // textBox_stime
            // 
            this.textBox_stime.Location = new System.Drawing.Point(226, 145);
            this.textBox_stime.Name = "textBox_stime";
            this.textBox_stime.Size = new System.Drawing.Size(142, 20);
            this.textBox_stime.TabIndex = 75;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(226, 67);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(142, 20);
            this.textBox_id.TabIndex = 72;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(127, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 69;
            this.label11.Text = "ID";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(226, 93);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(142, 20);
            this.textBox_name.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 33);
            this.label1.TabIndex = 62;
            this.label1.Text = "Add Schedule";
            // 
            // NewTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 337);
            this.Controls.Add(this.comboBox_jobtitle);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_days);
            this.Controls.Add(this.textBox_etime);
            this.Controls.Add(this.textBox_stime);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "NewTime";
            this.Text = "NewTime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_jobtitle;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_days;
        private System.Windows.Forms.TextBox textBox_etime;
        private System.Windows.Forms.TextBox textBox_stime;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}