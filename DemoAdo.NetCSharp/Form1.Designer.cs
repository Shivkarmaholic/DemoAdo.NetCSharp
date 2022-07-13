namespace DemoAdo.NetCSharp
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
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.txt_EmpId = new System.Windows.Forms.TextBox();
            this.txt_EmpName = new System.Windows.Forms.TextBox();
            this.txt_EmpSalary = new System.Windows.Forms.TextBox();
            this.btn_SearchById = new System.Windows.Forms.Button();
            this.dgv_ShowDataGrid = new System.Windows.Forms.DataGridView();
            this.btn_ShowAllEmp = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ShowDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emp_Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emp_Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Emp_Salary";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(44, 154);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(227, 154);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(320, 154);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // txt_EmpId
            // 
            this.txt_EmpId.Location = new System.Drawing.Point(149, 48);
            this.txt_EmpId.Name = "txt_EmpId";
            this.txt_EmpId.Size = new System.Drawing.Size(144, 20);
            this.txt_EmpId.TabIndex = 6;
            // 
            // txt_EmpName
            // 
            this.txt_EmpName.Location = new System.Drawing.Point(149, 79);
            this.txt_EmpName.Name = "txt_EmpName";
            this.txt_EmpName.Size = new System.Drawing.Size(144, 20);
            this.txt_EmpName.TabIndex = 7;
            // 
            // txt_EmpSalary
            // 
            this.txt_EmpSalary.Location = new System.Drawing.Point(149, 112);
            this.txt_EmpSalary.Name = "txt_EmpSalary";
            this.txt_EmpSalary.Size = new System.Drawing.Size(144, 20);
            this.txt_EmpSalary.TabIndex = 8;
            // 
            // btn_SearchById
            // 
            this.btn_SearchById.Location = new System.Drawing.Point(320, 46);
            this.btn_SearchById.Name = "btn_SearchById";
            this.btn_SearchById.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchById.TabIndex = 9;
            this.btn_SearchById.Text = "SearchById";
            this.btn_SearchById.UseVisualStyleBackColor = true;
            // 
            // dgv_ShowDataGrid
            // 
            this.dgv_ShowDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ShowDataGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_ShowDataGrid.Location = new System.Drawing.Point(12, 203);
            this.dgv_ShowDataGrid.Name = "dgv_ShowDataGrid";
            this.dgv_ShowDataGrid.Size = new System.Drawing.Size(417, 170);
            this.dgv_ShowDataGrid.TabIndex = 10;
            // 
            // btn_ShowAllEmp
            // 
            this.btn_ShowAllEmp.Location = new System.Drawing.Point(320, 110);
            this.btn_ShowAllEmp.Name = "btn_ShowAllEmp";
            this.btn_ShowAllEmp.Size = new System.Drawing.Size(75, 23);
            this.btn_ShowAllEmp.TabIndex = 11;
            this.btn_ShowAllEmp.Text = "ShowAllEmployee";
            this.btn_ShowAllEmp.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(136, 154);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 12;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 424);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ShowDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox txt_EmpId;
        private System.Windows.Forms.TextBox txt_EmpName;
        private System.Windows.Forms.TextBox txt_EmpSalary;
        private System.Windows.Forms.Button btn_SearchById;
        private System.Windows.Forms.DataGridView dgv_ShowDataGrid;
        private System.Windows.Forms.Button btn_ShowAllEmp;
        private System.Windows.Forms.Button btn_Clear;
    }
}

