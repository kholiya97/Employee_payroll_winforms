
namespace DashBoard_emppayroll
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.EMP_logo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.empdetails = new System.Windows.Forms.Label();
            this.add_emp = new System.Windows.Forms.Label();
            this.ADD_employee_grid = new System.Windows.Forms.DataGridView();
            this.delete_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ADD_employee_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // EMP_logo
            // 
            this.EMP_logo.AutoSize = true;
            this.EMP_logo.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EMP_logo.ForeColor = System.Drawing.Color.OliveDrab;
            this.EMP_logo.Location = new System.Drawing.Point(199, 55);
            this.EMP_logo.Name = "EMP_logo";
            this.EMP_logo.Size = new System.Drawing.Size(166, 50);
            this.EMP_logo.TabIndex = 0;
            this.EMP_logo.Text = "EMPLOYEE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(210, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "PAYROLL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(79, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // empdetails
            // 
            this.empdetails.AutoSize = true;
            this.empdetails.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empdetails.ForeColor = System.Drawing.Color.Gray;
            this.empdetails.Location = new System.Drawing.Point(79, 229);
            this.empdetails.Name = "empdetails";
            this.empdetails.Size = new System.Drawing.Size(286, 33);
            this.empdetails.TabIndex = 3;
            this.empdetails.Text = "Employee Details";
            // 
            // add_emp
            // 
            this.add_emp.AutoSize = true;
            this.add_emp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.add_emp.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_emp.Location = new System.Drawing.Point(1034, 231);
            this.add_emp.Name = "add_emp";
            this.add_emp.Size = new System.Drawing.Size(198, 31);
            this.add_emp.TabIndex = 4;
            this.add_emp.Text = "+ ADD EMPLOYEE";
            this.add_emp.Click += new System.EventHandler(this.add_emp_Click);
            // 
            // ADD_employee_grid
            // 
            this.ADD_employee_grid.AllowUserToOrderColumns = true;
            this.ADD_employee_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ADD_employee_grid.Location = new System.Drawing.Point(39, 302);
            this.ADD_employee_grid.Name = "ADD_employee_grid";
            this.ADD_employee_grid.RowHeadersWidth = 51;
            this.ADD_employee_grid.RowTemplate.Height = 29;
            this.ADD_employee_grid.Size = new System.Drawing.Size(1281, 290);
            this.ADD_employee_grid.TabIndex = 5;
            this.ADD_employee_grid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ADD_employee_grid_CellContentDoubleClick);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(596, 158);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(94, 29);
            this.delete_button.TabIndex = 6;
            this.delete_button.Text = "DELETE";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 657);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.ADD_employee_grid);
            this.Controls.Add(this.add_emp);
            this.Controls.Add(this.empdetails);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EMP_logo);
            this.Name = "Form2";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ADD_employee_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EMP_logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label empdetails;
        private System.Windows.Forms.Label add_emp;
        private System.Windows.Forms.DataGridView ADD_employee_grid;
        private System.Windows.Forms.Button delete_button;
    }
}

