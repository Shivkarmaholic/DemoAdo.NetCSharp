namespace DemoAdo.NetCSharp
{
    partial class Form2
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
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_ShowAllEmp = new System.Windows.Forms.Button();
            this.dgv_ShowDataGrid = new System.Windows.Forms.DataGridView();
            this.btn_SearchById = new System.Windows.Forms.Button();
            this.txt_EmpSalary = new System.Windows.Forms.TextBox();
            this.txt_EmpName = new System.Windows.Forms.TextBox();
            this.txt_EmpId = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ShowDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(136, 130);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 25;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_ShowAllEmp
            // 
            this.btn_ShowAllEmp.Location = new System.Drawing.Point(320, 86);
            this.btn_ShowAllEmp.Name = "btn_ShowAllEmp";
            this.btn_ShowAllEmp.Size = new System.Drawing.Size(75, 23);
            this.btn_ShowAllEmp.TabIndex = 24;
            this.btn_ShowAllEmp.Text = "ShowAllEmployee";
            this.btn_ShowAllEmp.UseVisualStyleBackColor = true;
            this.btn_ShowAllEmp.Click += new System.EventHandler(this.btn_ShowAllEmp_Click);
            // 
            // dgv_ShowDataGrid
            // 
            this.dgv_ShowDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ShowDataGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_ShowDataGrid.Location = new System.Drawing.Point(12, 179);
            this.dgv_ShowDataGrid.Name = "dgv_ShowDataGrid";
            this.dgv_ShowDataGrid.Size = new System.Drawing.Size(417, 170);
            this.dgv_ShowDataGrid.TabIndex = 23;
            // 
            // btn_SearchById
            // 
            this.btn_SearchById.Location = new System.Drawing.Point(320, 22);
            this.btn_SearchById.Name = "btn_SearchById";
            this.btn_SearchById.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchById.TabIndex = 22;
            this.btn_SearchById.Text = "SearchById";
            this.btn_SearchById.UseVisualStyleBackColor = true;
            this.btn_SearchById.Click += new System.EventHandler(this.btn_SearchById_Click);
            // 
            // txt_EmpSalary
            // 
            this.txt_EmpSalary.Location = new System.Drawing.Point(149, 88);
            this.txt_EmpSalary.Name = "txt_EmpSalary";
            this.txt_EmpSalary.Size = new System.Drawing.Size(144, 20);
            this.txt_EmpSalary.TabIndex = 21;
            // 
            // txt_EmpName
            // 
            this.txt_EmpName.Location = new System.Drawing.Point(149, 55);
            this.txt_EmpName.Name = "txt_EmpName";
            this.txt_EmpName.Size = new System.Drawing.Size(144, 20);
            this.txt_EmpName.TabIndex = 20;
            // 
            // txt_EmpId
            // 
            this.txt_EmpId.Location = new System.Drawing.Point(149, 24);
            this.txt_EmpId.Name = "txt_EmpId";
            this.txt_EmpId.Size = new System.Drawing.Size(144, 20);
            this.txt_EmpId.TabIndex = 19;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(320, 130);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 18;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(227, 130);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 17;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(44, 130);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 16;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Emp_Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Emp_Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Emp_Id";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 367);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_ShowAllEmp);
            this.Controls.Add(this.dgv_ShowDataGrid);
            this.Controls.Add(this.btn_SearchById);
            this.Controls.Add(this.txt_EmpSalary);
            this.Controls.Add(this.txt_EmpName);
            this.Controls.Add(this.txt_EmpId);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ShowDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_ShowAllEmp;
        private System.Windows.Forms.DataGridView dgv_ShowDataGrid;
        private System.Windows.Forms.Button btn_SearchById;
        private System.Windows.Forms.TextBox txt_EmpSalary;
        private System.Windows.Forms.TextBox txt_EmpName;
        private System.Windows.Forms.TextBox txt_EmpId;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}