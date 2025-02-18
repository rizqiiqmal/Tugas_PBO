namespace Management_Employees
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Admin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Password = new System.Windows.Forms.RichTextBox();
            this.CrossBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sistem Menejemen Karyawan";
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.Location = new System.Drawing.Point(51, 190);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(90, 22);
            this.Admin.TabIndex = 5;
            this.Admin.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // LoginBtn
            // 
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginBtn.Location = new System.Drawing.Point(156, 268);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(140, 23);
            this.LoginBtn.TabIndex = 7;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.richTextBox1.Location = new System.Drawing.Point(156, 190);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(140, 21);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.SkyBlue;
            this.Password.Location = new System.Drawing.Point(156, 225);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(140, 22);
            this.Password.TabIndex = 9;
            this.Password.Text = "";
            // 
            // CrossBtn
            // 
            this.CrossBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CrossBtn.Location = new System.Drawing.Point(404, 0);
            this.CrossBtn.Name = "CrossBtn";
            this.CrossBtn.Size = new System.Drawing.Size(34, 35);
            this.CrossBtn.TabIndex = 10;
            this.CrossBtn.Text = "X";
            this.CrossBtn.UseVisualStyleBackColor = true;
            this.CrossBtn.Click += new System.EventHandler(this.CrossBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Management_Employees.Properties.Resources.business_people;
            this.pictureBox1.Location = new System.Drawing.Point(156, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(438, 343);
            this.Controls.Add(this.CrossBtn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox Password;
        private System.Windows.Forms.Button CrossBtn;
    }
}

