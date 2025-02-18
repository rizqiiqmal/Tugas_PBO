namespace Management_Employees.View
{
    partial class Jabatan
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
            this.text_jabatan = new System.Windows.Forms.TextBox();
            this.btn_jabatan = new System.Windows.Forms.Button();
            this.dataGridJabatan = new System.Windows.Forms.DataGridView();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJabatan)).BeginInit();
            this.SuspendLayout();
            // 
            // text_jabatan
            // 
            this.text_jabatan.Location = new System.Drawing.Point(92, 104);
            this.text_jabatan.Name = "text_jabatan";
            this.text_jabatan.Size = new System.Drawing.Size(155, 22);
            this.text_jabatan.TabIndex = 0;
            // 
            // btn_jabatan
            // 
            this.btn_jabatan.Location = new System.Drawing.Point(92, 145);
            this.btn_jabatan.Name = "btn_jabatan";
            this.btn_jabatan.Size = new System.Drawing.Size(155, 23);
            this.btn_jabatan.TabIndex = 1;
            this.btn_jabatan.Text = "Simpan";
            this.btn_jabatan.UseVisualStyleBackColor = true;
            this.btn_jabatan.Click += new System.EventHandler(this.btn_jabatan_Click_1);
            // 
            // dataGridJabatan
            // 
            this.dataGridJabatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridJabatan.Location = new System.Drawing.Point(306, 104);
            this.dataGridJabatan.Name = "dataGridJabatan";
            this.dataGridJabatan.RowHeadersWidth = 51;
            this.dataGridJabatan.RowTemplate.Height = 24;
            this.dataGridJabatan.Size = new System.Drawing.Size(240, 200);
            this.dataGridJabatan.TabIndex = 2;
            this.dataGridJabatan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridJabatan_CellContentClick);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(92, 185);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(155, 23);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(92, 228);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(155, 23);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Jabatan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(590, 354);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.dataGridJabatan);
            this.Controls.Add(this.btn_jabatan);
            this.Controls.Add(this.text_jabatan);
            this.Name = "Jabatan";
            this.Text = "Jabatan";
            this.Load += new System.EventHandler(this.Jabatan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJabatan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_jabatan;
        private System.Windows.Forms.Button btn_jabatan;
        private System.Windows.Forms.DataGridView dataGridJabatan;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
    }
}