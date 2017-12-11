namespace CrudRepository
{
    partial class frmManageDepartment
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
            this.Label_DeptId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deptLabel = new System.Windows.Forms.TextBox();
            this.SaveDept = new System.Windows.Forms.Button();
            this.ClearDep = new System.Windows.Forms.Button();
            this.GridDepartement = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridDepartement)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departement Id:";
            // 
            // Label_DeptId
            // 
            this.Label_DeptId.AutoSize = true;
            this.Label_DeptId.Location = new System.Drawing.Point(135, 13);
            this.Label_DeptId.Name = "Label_DeptId";
            this.Label_DeptId.Size = new System.Drawing.Size(13, 13);
            this.Label_DeptId.TabIndex = 1;
            this.Label_DeptId.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Departement label";
            // 
            // deptLabel
            // 
            this.deptLabel.Location = new System.Drawing.Point(138, 44);
            this.deptLabel.Name = "deptLabel";
            this.deptLabel.Size = new System.Drawing.Size(127, 20);
            this.deptLabel.TabIndex = 3;
            // 
            // SaveDept
            // 
            this.SaveDept.Location = new System.Drawing.Point(19, 82);
            this.SaveDept.Name = "SaveDept";
            this.SaveDept.Size = new System.Drawing.Size(75, 23);
            this.SaveDept.TabIndex = 4;
            this.SaveDept.Text = "Save";
            this.SaveDept.UseVisualStyleBackColor = true;
            this.SaveDept.Click += new System.EventHandler(this.SaveDept_Click);
            // 
            // ClearDep
            // 
            this.ClearDep.Location = new System.Drawing.Point(138, 81);
            this.ClearDep.Name = "ClearDep";
            this.ClearDep.Size = new System.Drawing.Size(75, 23);
            this.ClearDep.TabIndex = 5;
            this.ClearDep.Text = "Clear";
            this.ClearDep.UseVisualStyleBackColor = true;
            this.ClearDep.Click += new System.EventHandler(this.ClearDep_Click);
            // 
            // GridDepartement
            // 
            this.GridDepartement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDepartement.Location = new System.Drawing.Point(19, 114);
            this.GridDepartement.Name = "GridDepartement";
            this.GridDepartement.Size = new System.Drawing.Size(443, 150);
            this.GridDepartement.TabIndex = 6;
            // 
            // frmManageDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 276);
            this.Controls.Add(this.GridDepartement);
            this.Controls.Add(this.ClearDep);
            this.Controls.Add(this.SaveDept);
            this.Controls.Add(this.deptLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label_DeptId);
            this.Controls.Add(this.label1);
            this.Name = "frmManageDepartment";
            this.Text = "frmManageDepartment";
            this.Load += new System.EventHandler(this.frmManageDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDepartement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_DeptId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox deptLabel;
        private System.Windows.Forms.Button SaveDept;
        private System.Windows.Forms.Button ClearDep;
        private System.Windows.Forms.DataGridView GridDepartement;
    }
}