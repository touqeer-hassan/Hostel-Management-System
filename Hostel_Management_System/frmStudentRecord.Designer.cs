namespace Hostel_Management_System
{
    partial class frmStudentRecord
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
            this.btnAddAStudent = new System.Windows.Forms.Button();
            this.btnRemoveAStudent = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Students";
            // 
            // btnAddAStudent
            // 
            this.btnAddAStudent.Location = new System.Drawing.Point(782, 17);
            this.btnAddAStudent.Name = "btnAddAStudent";
            this.btnAddAStudent.Size = new System.Drawing.Size(104, 31);
            this.btnAddAStudent.TabIndex = 1;
            this.btnAddAStudent.Text = "Add New Student";
            this.btnAddAStudent.UseVisualStyleBackColor = true;
            this.btnAddAStudent.Click += new System.EventHandler(this.btnAddAStudent_Click);
            // 
            // btnRemoveAStudent
            // 
            this.btnRemoveAStudent.Location = new System.Drawing.Point(892, 17);
            this.btnRemoveAStudent.Name = "btnRemoveAStudent";
            this.btnRemoveAStudent.Size = new System.Drawing.Size(106, 31);
            this.btnRemoveAStudent.TabIndex = 2;
            this.btnRemoveAStudent.Text = "Remove a Student";
            this.btnRemoveAStudent.UseVisualStyleBackColor = true;
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(6, 61);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.Size = new System.Drawing.Size(992, 451);
            this.dgvStudent.TabIndex = 3;
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(689, 21);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmStudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 515);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.btnRemoveAStudent);
            this.Controls.Add(this.btnAddAStudent);
            this.Controls.Add(this.label1);
            this.Name = "frmStudentRecord";
            this.Text = "Student Record";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddAStudent;
        private System.Windows.Forms.Button btnRemoveAStudent;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button btnRefresh;
    }
}