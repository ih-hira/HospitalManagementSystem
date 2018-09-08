namespace Hospital_Management_System
{
    partial class UserControl_Schedule
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
            this.dataGridView_schedule = new System.Windows.Forms.DataGridView();
            this.comboBox_jobtitle = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button_show = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_schedule)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "Scheduling";
            // 
            // dataGridView_schedule
            // 
            this.dataGridView_schedule.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_schedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_schedule.GridColor = System.Drawing.Color.White;
            this.dataGridView_schedule.Location = new System.Drawing.Point(21, 109);
            this.dataGridView_schedule.Name = "dataGridView_schedule";
            this.dataGridView_schedule.RowHeadersVisible = false;
            this.dataGridView_schedule.Size = new System.Drawing.Size(658, 436);
            this.dataGridView_schedule.TabIndex = 77;
            this.dataGridView_schedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_schedule_CellContentClick);
            // 
            // comboBox_jobtitle
            // 
            this.comboBox_jobtitle.FormattingEnabled = true;
            this.comboBox_jobtitle.Items.AddRange(new object[] {
            "Doctor",
            "Receptionist",
            "Nurse",
            "Stuff"});
            this.comboBox_jobtitle.Location = new System.Drawing.Point(242, 68);
            this.comboBox_jobtitle.Name = "comboBox_jobtitle";
            this.comboBox_jobtitle.Size = new System.Drawing.Size(266, 21);
            this.comboBox_jobtitle.TabIndex = 76;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(124, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 75;
            this.label12.Text = "Job Title";
            // 
            // button_show
            // 
            this.button_show.Location = new System.Drawing.Point(704, 206);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(75, 23);
            this.button_show.TabIndex = 73;
            this.button_show.Text = "Show";
            this.button_show.UseVisualStyleBackColor = true;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(704, 250);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 74;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(704, 379);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 72;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(704, 290);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 74;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(704, 328);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 74;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // UserControl_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView_schedule);
            this.Controls.Add(this.comboBox_jobtitle);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label3);
            this.Name = "UserControl_Schedule";
            this.Size = new System.Drawing.Size(800, 560);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_schedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_schedule;
        private System.Windows.Forms.ComboBox comboBox_jobtitle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
    }
}
