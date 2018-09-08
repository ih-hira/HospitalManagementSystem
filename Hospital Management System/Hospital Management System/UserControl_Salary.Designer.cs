namespace Hospital_Management_System
{
    partial class UserControl_Salary
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
            this.dataGridView_salary = new System.Windows.Forms.DataGridView();
            this.comboBox_jobtitle = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button_show = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_salary)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Salary Details";
            // 
            // dataGridView_salary
            // 
            this.dataGridView_salary.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_salary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_salary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_salary.GridColor = System.Drawing.Color.White;
            this.dataGridView_salary.Location = new System.Drawing.Point(19, 107);
            this.dataGridView_salary.Name = "dataGridView_salary";
            this.dataGridView_salary.RowHeadersVisible = false;
            this.dataGridView_salary.Size = new System.Drawing.Size(658, 436);
            this.dataGridView_salary.TabIndex = 70;
            // 
            // comboBox_jobtitle
            // 
            this.comboBox_jobtitle.FormattingEnabled = true;
            this.comboBox_jobtitle.Items.AddRange(new object[] {
            "Doctor",
            "Receptionist",
            "Nurse",
            "Stuff"});
            this.comboBox_jobtitle.Location = new System.Drawing.Point(240, 66);
            this.comboBox_jobtitle.Name = "comboBox_jobtitle";
            this.comboBox_jobtitle.Size = new System.Drawing.Size(266, 21);
            this.comboBox_jobtitle.TabIndex = 69;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(89, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 68;
            this.label12.Text = "Job Title";
            // 
            // button_show
            // 
            this.button_show.Location = new System.Drawing.Point(702, 282);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(75, 23);
            this.button_show.TabIndex = 66;
            this.button_show.Text = "Show";
            this.button_show.UseVisualStyleBackColor = true;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(702, 326);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 67;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(702, 377);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 64;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // UserControl_Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView_salary);
            this.Controls.Add(this.comboBox_jobtitle);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label3);
            this.Name = "UserControl_Salary";
            this.Size = new System.Drawing.Size(800, 560);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_salary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_salary;
        private System.Windows.Forms.ComboBox comboBox_jobtitle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_close;
    }
}
