namespace Hospital_Management_System
{
    partial class UserControl_BloodBank
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
            this.label_bloodType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_noOfBags = new System.Windows.Forms.TextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.dataGridView_bloodList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bloodList)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Blood Bank";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Blood Type";
            // 
            // label_bloodType
            // 
            this.label_bloodType.AutoSize = true;
            this.label_bloodType.Location = new System.Drawing.Point(525, 164);
            this.label_bloodType.Name = "label_bloodType";
            this.label_bloodType.Size = new System.Drawing.Size(0, 13);
            this.label_bloodType.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "No. of Bags";
            // 
            // textBox_noOfBags
            // 
            this.textBox_noOfBags.Location = new System.Drawing.Point(528, 206);
            this.textBox_noOfBags.Name = "textBox_noOfBags";
            this.textBox_noOfBags.Size = new System.Drawing.Size(100, 20);
            this.textBox_noOfBags.TabIndex = 14;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(436, 305);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 15;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(553, 305);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 16;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // dataGridView_bloodList
            // 
            this.dataGridView_bloodList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_bloodList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_bloodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_bloodList.Location = new System.Drawing.Point(69, 113);
            this.dataGridView_bloodList.Name = "dataGridView_bloodList";
            this.dataGridView_bloodList.RowHeadersVisible = false;
            this.dataGridView_bloodList.Size = new System.Drawing.Size(202, 369);
            this.dataGridView_bloodList.TabIndex = 10;
            this.dataGridView_bloodList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_bloodList_CellContentClick);
            // 
            // UserControl_BloodBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.textBox_noOfBags);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_bloodType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_bloodList);
            this.Controls.Add(this.label3);
            this.Name = "UserControl_BloodBank";
            this.Size = new System.Drawing.Size(800, 560);
            this.Load += new System.EventHandler(this.UserControl_BloodBank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bloodList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_bloodType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_noOfBags;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.DataGridView dataGridView_bloodList;
    }
}
