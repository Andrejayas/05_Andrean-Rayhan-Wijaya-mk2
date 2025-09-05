namespace Ulangan.walahi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.comboBoxListTugas = new System.Windows.Forms.ComboBox();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.dateDeadline = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTugas = new System.Windows.Forms.DataGridView();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.lblMapel = new System.Windows.Forms.Label();
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTugas)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxListTugas
            // 
            this.comboBoxListTugas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxListTugas.FormattingEnabled = true;
            this.comboBoxListTugas.Location = new System.Drawing.Point(120, 20);
            this.comboBoxListTugas.Name = "comboBoxListTugas";
            this.comboBoxListTugas.Size = new System.Drawing.Size(200, 23);
            this.comboBoxListTugas.TabIndex = 0;
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Location = new System.Drawing.Point(120, 60);
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(200, 23);
            this.txtDeskripsi.TabIndex = 1;
            // 
            // dateDeadline
            // 
            this.dateDeadline.Location = new System.Drawing.Point(120, 100);
            this.dateDeadline.Name = "dateDeadline";
            this.dateDeadline.Size = new System.Drawing.Size(200, 23);
            this.dateDeadline.TabIndex = 2;
            // 
            // dataGridViewTugas
            // 
            this.dataGridViewTugas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTugas.Location = new System.Drawing.Point(20, 180);
            this.dataGridViewTugas.Name = "dataGridViewTugas";
            this.dataGridViewTugas.RowTemplate.Height = 25;
            this.dataGridViewTugas.Size = new System.Drawing.Size(500, 200);
            this.dataGridViewTugas.TabIndex = 3;
            this.dataGridViewTugas.AllowUserToAddRows = false;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(350, 20);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(350, 60);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(350, 100);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 6;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblMapel
            // 
            this.lblMapel.AutoSize = true;
            this.lblMapel.Location = new System.Drawing.Point(20, 23);
            this.lblMapel.Name = "lblMapel";
            this.lblMapel.Size = new System.Drawing.Size(49, 15);
            this.lblMapel.TabIndex = 7;
            this.lblMapel.Text = "Mapel :";
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Location = new System.Drawing.Point(20, 63);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(61, 15);
            this.lblDeskripsi.TabIndex = 8;
            this.lblDeskripsi.Text = "Deskripsi :";
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Location = new System.Drawing.Point(20, 103);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(60, 15);
            this.lblDeadline.TabIndex = 9;
            this.lblDeadline.Text = "Deadline :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.lblDeskripsi);
            this.Controls.Add(this.lblMapel);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.dataGridViewTugas);
            this.Controls.Add(this.dateDeadline);
            this.Controls.Add(this.txtDeskripsi);
            this.Controls.Add(this.comboBoxListTugas);
            this.Name = "Form1";
            this.Text = "Daftar Tugas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTugas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxListTugas;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.DateTimePicker dateDeadline;
        private System.Windows.Forms.DataGridView dataGridViewTugas;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblMapel;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.Label lblDeadline;
    }
}
