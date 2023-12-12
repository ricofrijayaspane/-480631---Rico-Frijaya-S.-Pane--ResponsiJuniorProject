using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using System;

namespace ResponsiRico
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNama = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ID_Departemen = new ListBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dgvData = new DataGridView();
            btnLoadData = new Button();
            txtDep = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // txtNama
            // 
            txtNama.Location = new System.Drawing.Point(156, 105);
            txtNama.Name = "txtNama";
            txtNama.Size = new System.Drawing.Size(164, 23);
            txtNama.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(42, 108);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(99, 15);
            label1.TabIndex = 2;
            label1.Text = "Nama Karyawan :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(50, 153);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 15);
            label2.TabIndex = 3;
            label2.Text = "Dep. Karyawan :";
            label2.Click += label2_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new System.Drawing.Point(50, 196);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new System.Drawing.Size(121, 26);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(215, 196);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(121, 26);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(380, 196);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(121, 26);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // ID_Departemen
            // 
            ID_Departemen.FormattingEnabled = true;
            ID_Departemen.ItemHeight = 15;
            ID_Departemen.Location = new System.Drawing.Point(380, 34);
            ID_Departemen.Name = "ID_Departemen";
            ID_Departemen.Size = new System.Drawing.Size(120, 139);
            ID_Departemen.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(388, 58);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(48, 15);
            label3.TabIndex = 8;
            label3.Text = "HR : HR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(388, 83);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(85, 15);
            label4.TabIndex = 9;
            label4.Text = "ENG : Engineer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(388, 105);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(90, 15);
            label5.TabIndex = 10;
            label5.Text = "DEV : Developer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(388, 129);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(90, 15);
            label6.TabIndex = 11;
            label6.Text = "PM : Product M";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(388, 153);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(75, 15);
            label7.TabIndex = 12;
            label7.Text = "FIN : Finance";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new System.Drawing.Point(42, 251);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new System.Drawing.Size(459, 217);
            dgvData.TabIndex = 13;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new System.Drawing.Point(379, 486);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new System.Drawing.Size(121, 26);
            btnLoadData.TabIndex = 14;
            btnLoadData.Text = "Load";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // txtDep
            // 
            txtDep.Location = new System.Drawing.Point(156, 150);
            txtDep.Name = "txtDep";
            txtDep.Size = new System.Drawing.Size(164, 23);
            txtDep.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(523, 521);
            Controls.Add(txtDep);
            Controls.Add(btnLoadData);
            Controls.Add(dgvData);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ID_Departemen);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNama);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox txtNama;
        private Label label1;
        private Label label2;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private ListBox ID_Departemen;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dgvData;
        private Button btnLoadData;
        private TextBox txtDep;
    }
}
