namespace Management_Employees
{
    partial class ParentForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.EmployeeBtn = new System.Windows.Forms.Button();
            this.btn_jabatan = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.CrossBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(525, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sistem Manajemen Karyawan";
            // 
            // EmployeeBtn
            // 
            this.EmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EmployeeBtn.Location = new System.Drawing.Point(105, 297);
            this.EmployeeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmployeeBtn.Name = "EmployeeBtn";
            this.EmployeeBtn.Size = new System.Drawing.Size(200, 44);
            this.EmployeeBtn.TabIndex = 8;
            this.EmployeeBtn.Text = "Employee";
            this.EmployeeBtn.UseVisualStyleBackColor = true;
            this.EmployeeBtn.Click += new System.EventHandler(this.EmployeeBtn_Click);
            // 
            // btn_jabatan
            // 
            this.btn_jabatan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_jabatan.Location = new System.Drawing.Point(345, 297);
            this.btn_jabatan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_jabatan.Name = "btn_jabatan";
            this.btn_jabatan.Size = new System.Drawing.Size(200, 44);
            this.btn_jabatan.TabIndex = 9;
            this.btn_jabatan.Text = "Jabatan";
            this.btn_jabatan.UseVisualStyleBackColor = true;
            this.btn_jabatan.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogoutBtn.Location = new System.Drawing.Point(585, 297);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(200, 44);
            this.LogoutBtn.TabIndex = 10;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // CrossBtn
            // 
            this.CrossBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CrossBtn.Location = new System.Drawing.Point(851, -1);
            this.CrossBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CrossBtn.Name = "CrossBtn";
            this.CrossBtn.Size = new System.Drawing.Size(45, 43);
            this.CrossBtn.TabIndex = 14;
            this.CrossBtn.Text = "X";
            this.CrossBtn.UseVisualStyleBackColor = true;
            this.CrossBtn.Click += new System.EventHandler(this.CrossBtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Management_Employees.Properties.Resources.logout;
            this.pictureBox3.Location = new System.Drawing.Point(625, 176);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(133, 95);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Management_Employees.Properties.Resources.businessman;
            this.pictureBox2.Location = new System.Drawing.Point(383, 176);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Management_Employees.Properties.Resources.team;
            this.pictureBox1.Location = new System.Drawing.Point(141, 176);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(896, 481);
            this.Controls.Add(this.CrossBtn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.btn_jabatan);
            this.Controls.Add(this.EmployeeBtn);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ParentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParentForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EmployeeBtn;
        private System.Windows.Forms.Button btn_jabatan;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button CrossBtn;
    }
}