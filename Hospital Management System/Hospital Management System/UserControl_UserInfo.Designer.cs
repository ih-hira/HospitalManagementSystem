namespace Hospital_Management_System
{
    partial class UserControl_UserInfo
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
            this.button_delete = new System.Windows.Forms.Button();
            this.button_new = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_changepw = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.dataGridView_userList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_userList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "User Information";
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(614, 220);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(146, 32);
            this.button_delete.TabIndex = 21;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_new
            // 
            this.button_new.Location = new System.Drawing.Point(614, 167);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(146, 32);
            this.button_new.TabIndex = 21;
            this.button_new.Text = "New";
            this.button_new.UseVisualStyleBackColor = true;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(614, 324);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(146, 32);
            this.button_close.TabIndex = 21;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_changepw
            // 
            this.button_changepw.Location = new System.Drawing.Point(614, 271);
            this.button_changepw.Name = "button_changepw";
            this.button_changepw.Size = new System.Drawing.Size(146, 32);
            this.button_changepw.TabIndex = 21;
            this.button_changepw.Text = "Change Password";
            this.button_changepw.UseVisualStyleBackColor = true;
            this.button_changepw.Click += new System.EventHandler(this.button_changepw_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(614, 399);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(146, 32);
            this.button_refresh.TabIndex = 21;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // dataGridView_userList
            // 
            this.dataGridView_userList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_userList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_userList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_userList.GridColor = System.Drawing.Color.White;
            this.dataGridView_userList.Location = new System.Drawing.Point(83, 114);
            this.dataGridView_userList.Name = "dataGridView_userList";
            this.dataGridView_userList.RowHeadersVisible = false;
            this.dataGridView_userList.Size = new System.Drawing.Size(488, 365);
            this.dataGridView_userList.TabIndex = 22;
            this.dataGridView_userList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_userList_CellContentClick);
            // 
            // UserControl_UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView_userList);
            this.Controls.Add(this.button_changepw);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_new);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_UserInfo";
            this.Size = new System.Drawing.Size(800, 560);
            this.Load += new System.EventHandler(this.UserControl_UserInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_userList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_changepw;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.DataGridView dataGridView_userList;
    }
}
