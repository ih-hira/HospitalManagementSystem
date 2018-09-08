namespace Hospital_Management_System
{
    partial class UserControl_Reports
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
            this.textBox_patientid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_testRequest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_testComplete = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_patientList = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_searchid = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_patientList)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Reports";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Patient ID";
            // 
            // textBox_patientid
            // 
            this.textBox_patientid.Location = new System.Drawing.Point(449, 136);
            this.textBox_patientid.Name = "textBox_patientid";
            this.textBox_patientid.Size = new System.Drawing.Size(200, 20);
            this.textBox_patientid.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "No. of Test Requested";
            // 
            // textBox_testRequest
            // 
            this.textBox_testRequest.Location = new System.Drawing.Point(449, 192);
            this.textBox_testRequest.Name = "textBox_testRequest";
            this.textBox_testRequest.Size = new System.Drawing.Size(200, 20);
            this.textBox_testRequest.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "No. of Test Complete";
            // 
            // textBox_testComplete
            // 
            this.textBox_testComplete.Location = new System.Drawing.Point(449, 260);
            this.textBox_testComplete.Name = "textBox_testComplete";
            this.textBox_testComplete.Size = new System.Drawing.Size(200, 20);
            this.textBox_testComplete.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Delivery Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(449, 336);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // dataGridView_patientList
            // 
            this.dataGridView_patientList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_patientList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_patientList.Location = new System.Drawing.Point(54, 176);
            this.dataGridView_patientList.Name = "dataGridView_patientList";
            this.dataGridView_patientList.RowHeadersVisible = false;
            this.dataGridView_patientList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView_patientList.Size = new System.Drawing.Size(163, 266);
            this.dataGridView_patientList.TabIndex = 18;
            this.dataGridView_patientList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_patientList_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Enter Search ID";
            // 
            // textBox_searchid
            // 
            this.textBox_searchid.Location = new System.Drawing.Point(57, 140);
            this.textBox_searchid.Name = "textBox_searchid";
            this.textBox_searchid.Size = new System.Drawing.Size(160, 20);
            this.textBox_searchid.TabIndex = 20;
            this.textBox_searchid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_searchid_KeyPress);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(323, 402);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 21;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(449, 402);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 22;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(566, 401);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 23;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // UserControl_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_searchid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView_patientList);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_testComplete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_testRequest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_patientid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "UserControl_Reports";
            this.Size = new System.Drawing.Size(720, 560);
            this.Load += new System.EventHandler(this.UserControl_Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_patientList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_patientid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_testRequest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_testComplete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView_patientList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_searchid;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_close;
    }
}
