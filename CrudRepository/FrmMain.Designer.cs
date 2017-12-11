namespace CrudRepository
{
    partial class FrmMain
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
            this.Student = new System.Windows.Forms.Label();
            this.labelStudentId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_StudentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboDept = new System.Windows.Forms.ComboBox();
            this.AddDept = new System.Windows.Forms.Button();
            this.AddNewStudent = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumInsc = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Location = new System.Drawing.Point(13, 13);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(62, 13);
            this.Student.TabIndex = 0;
            this.Student.Text = "Student Id :";
            // 
            // labelStudentId
            // 
            this.labelStudentId.AutoSize = true;
            this.labelStudentId.Location = new System.Drawing.Point(111, 13);
            this.labelStudentId.Name = "labelStudentId";
            this.labelStudentId.Size = new System.Drawing.Size(13, 13);
            this.labelStudentId.TabIndex = 1;
            this.labelStudentId.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name student";
            // 
            // Txt_StudentName
            // 
            this.Txt_StudentName.Location = new System.Drawing.Point(114, 45);
            this.Txt_StudentName.Name = "Txt_StudentName";
            this.Txt_StudentName.Size = new System.Drawing.Size(237, 20);
            this.Txt_StudentName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Departement";
            // 
            // comboDept
            // 
            this.comboDept.FormattingEnabled = true;
            this.comboDept.Location = new System.Drawing.Point(114, 82);
            this.comboDept.Name = "comboDept";
            this.comboDept.Size = new System.Drawing.Size(121, 21);
            this.comboDept.TabIndex = 5;
            // 
            // AddDept
            // 
            this.AddDept.Location = new System.Drawing.Point(253, 79);
            this.AddDept.Name = "AddDept";
            this.AddDept.Size = new System.Drawing.Size(98, 23);
            this.AddDept.TabIndex = 6;
            this.AddDept.Text = "Add new dept";
            this.AddDept.UseVisualStyleBackColor = true;
            this.AddDept.Click += new System.EventHandler(this.AddDept_Click);
            // 
            // AddNewStudent
            // 
            this.AddNewStudent.Location = new System.Drawing.Point(114, 121);
            this.AddNewStudent.Name = "AddNewStudent";
            this.AddNewStudent.Size = new System.Drawing.Size(75, 23);
            this.AddNewStudent.TabIndex = 7;
            this.AddNewStudent.Text = "Save";
            this.AddNewStudent.UseVisualStyleBackColor = true;
            this.AddNewStudent.Click += new System.EventHandler(this.AddNewStudent_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(205, 121);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 8;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(666, 175);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(474, 86);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(214, 20);
            this.txtMail.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Email :";
            // 
            // txtNumInsc
            // 
            this.txtNumInsc.Location = new System.Drawing.Point(473, 55);
            this.txtNumInsc.Name = "txtNumInsc";
            this.txtNumInsc.Size = new System.Drawing.Size(214, 20);
            this.txtNumInsc.TabIndex = 27;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(473, 23);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(214, 20);
            this.txtPrenom.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Prénom :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Num inscription :";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 460);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumInsc);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.AddNewStudent);
            this.Controls.Add(this.AddDept);
            this.Controls.Add(this.comboDept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_StudentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelStudentId);
            this.Controls.Add(this.Student);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Student;
        private System.Windows.Forms.Label labelStudentId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_StudentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboDept;
        private System.Windows.Forms.Button AddDept;
        private System.Windows.Forms.Button AddNewStudent;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumInsc;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}