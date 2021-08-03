
namespace Employee_Payroll
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DESIG_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NAME_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BASICPAY_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.M_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.HR_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GROSS_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TAX_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.NS_textBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.RESET_button = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.YEAR_SELECT = new System.Windows.Forms.ComboBox();
            this.MONTH_SELECT = new System.Windows.Forms.ComboBox();
            this.DAY_SELECT = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.M_GENDER = new System.Windows.Forms.RadioButton();
            this.F_GENDER = new System.Windows.Forms.RadioButton();
            this.O_GENDER = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(427, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "EMPLOYEE PAYROLL FORM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(460, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(728, 153);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(255, 30);
            this.IDtextBox.TabIndex = 0;
            this.IDtextBox.Leave += new System.EventHandler(this.IDtextBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(418, 550);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "DESIGNATION";
            // 
            // DESIG_textBox
            // 
            this.DESIG_textBox.Location = new System.Drawing.Point(740, 545);
            this.DESIG_textBox.Name = "DESIG_textBox";
            this.DESIG_textBox.Size = new System.Drawing.Size(255, 30);
            this.DESIG_textBox.TabIndex = 2;
            this.DESIG_textBox.Leave += new System.EventHandler(this.DESIG_textBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(437, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "NAME";
            // 
            // NAME_textBox
            // 
            this.NAME_textBox.Location = new System.Drawing.Point(728, 216);
            this.NAME_textBox.Name = "NAME_textBox";
            this.NAME_textBox.Size = new System.Drawing.Size(255, 30);
            this.NAME_textBox.TabIndex = 1;
            this.NAME_textBox.Leave += new System.EventHandler(this.NAME_textBox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(438, 604);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "BASIC PAY";
            // 
            // BASICPAY_textBox
            // 
            this.BASICPAY_textBox.Location = new System.Drawing.Point(740, 604);
            this.BASICPAY_textBox.Name = "BASICPAY_textBox";
            this.BASICPAY_textBox.Size = new System.Drawing.Size(255, 30);
            this.BASICPAY_textBox.TabIndex = 3;
            this.BASICPAY_textBox.TextChanged += new System.EventHandler(this.BASICPAY_textBox_TextChanged);
            this.BASICPAY_textBox.Leave += new System.EventHandler(this.BASICPAY_textBox_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(388, 673);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "MEDICAL ALLOWANCE";
            // 
            // M_textBox
            // 
            this.M_textBox.Location = new System.Drawing.Point(740, 673);
            this.M_textBox.Name = "M_textBox";
            this.M_textBox.ReadOnly = true;
            this.M_textBox.Size = new System.Drawing.Size(255, 30);
            this.M_textBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(373, 748);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "HOUSERENT ALLOWANCE";
            // 
            // HR_textBox
            // 
            this.HR_textBox.Location = new System.Drawing.Point(740, 748);
            this.HR_textBox.Name = "HR_textBox";
            this.HR_textBox.ReadOnly = true;
            this.HR_textBox.Size = new System.Drawing.Size(255, 30);
            this.HR_textBox.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(448, 802);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "GROSS PAY";
            // 
            // GROSS_textBox
            // 
            this.GROSS_textBox.Location = new System.Drawing.Point(740, 802);
            this.GROSS_textBox.Name = "GROSS_textBox";
            this.GROSS_textBox.ReadOnly = true;
            this.GROSS_textBox.Size = new System.Drawing.Size(255, 30);
            this.GROSS_textBox.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(438, 872);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "INCOME TAX";
            // 
            // TAX_textBox
            // 
            this.TAX_textBox.Location = new System.Drawing.Point(740, 872);
            this.TAX_textBox.Name = "TAX_textBox";
            this.TAX_textBox.ReadOnly = true;
            this.TAX_textBox.Size = new System.Drawing.Size(255, 30);
            this.TAX_textBox.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(429, 836);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "NET SALARY";
            // 
            // NS_textBox
            // 
            this.NS_textBox.Location = new System.Drawing.Point(735, 836);
            this.NS_textBox.Name = "NS_textBox";
            this.NS_textBox.ReadOnly = true;
            this.NS_textBox.Size = new System.Drawing.Size(255, 30);
            this.NS_textBox.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // RESET_button
            // 
            this.RESET_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RESET_button.Location = new System.Drawing.Point(460, 931);
            this.RESET_button.Name = "RESET_button";
            this.RESET_button.Size = new System.Drawing.Size(161, 33);
            this.RESET_button.TabIndex = 4;
            this.RESET_button.Text = "RESET";
            this.RESET_button.UseVisualStyleBackColor = true;
            this.RESET_button.Click += new System.EventHandler(this.RESET_button_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(418, 396);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 23);
            this.label12.TabIndex = 6;
            this.label12.Text = "PROFILE IMAGE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.OliveDrab;
            this.label11.Location = new System.Drawing.Point(90, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 50);
            this.label11.TabIndex = 7;
            this.label11.Text = "EMPLOYEE";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Agency FB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(106, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 44);
            this.label13.TabIndex = 8;
            this.label13.Text = "PAYROLL";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(422, 467);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 23);
            this.label14.TabIndex = 9;
            this.label14.Text = "START DATE";
            // 
            // YEAR_SELECT
            // 
            this.YEAR_SELECT.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YEAR_SELECT.FormattingEnabled = true;
            this.YEAR_SELECT.Items.AddRange(new object[] {
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016"});
            this.YEAR_SELECT.Location = new System.Drawing.Point(906, 459);
            this.YEAR_SELECT.Name = "YEAR_SELECT";
            this.YEAR_SELECT.Size = new System.Drawing.Size(151, 31);
            this.YEAR_SELECT.TabIndex = 10;
            this.YEAR_SELECT.Text = "PLEASE SELECT";
            // 
            // MONTH_SELECT
            // 
            this.MONTH_SELECT.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MONTH_SELECT.FormattingEnabled = true;
            this.MONTH_SELECT.Items.AddRange(new object[] {
            "JANUARY",
            "FEBRUARY",
            "MARCH",
            "APRIL",
            "MAY",
            "JUNE",
            "JULY",
            "AUGUST",
            "SEPTEMBER",
            "OCTOBER",
            "NOVEMBER",
            "DECEMBER"});
            this.MONTH_SELECT.Location = new System.Drawing.Point(740, 459);
            this.MONTH_SELECT.Name = "MONTH_SELECT";
            this.MONTH_SELECT.Size = new System.Drawing.Size(151, 31);
            this.MONTH_SELECT.TabIndex = 11;
            this.MONTH_SELECT.Text = "PLEASE SELECT";
            // 
            // DAY_SELECT
            // 
            this.DAY_SELECT.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DAY_SELECT.FormattingEnabled = true;
            this.DAY_SELECT.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.DAY_SELECT.Location = new System.Drawing.Point(571, 459);
            this.DAY_SELECT.Name = "DAY_SELECT";
            this.DAY_SELECT.Size = new System.Drawing.Size(151, 31);
            this.DAY_SELECT.TabIndex = 12;
            this.DAY_SELECT.Text = "PLEASE SELECT";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(438, 291);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 23);
            this.label15.TabIndex = 13;
            this.label15.Text = "GENDER";
            // 
            // M_GENDER
            // 
            this.M_GENDER.AutoSize = true;
            this.M_GENDER.Location = new System.Drawing.Point(597, 287);
            this.M_GENDER.Name = "M_GENDER";
            this.M_GENDER.Size = new System.Drawing.Size(77, 27);
            this.M_GENDER.TabIndex = 14;
            this.M_GENDER.TabStop = true;
            this.M_GENDER.Text = "MALE";
            this.M_GENDER.UseVisualStyleBackColor = true;
            // 
            // F_GENDER
            // 
            this.F_GENDER.AutoSize = true;
            this.F_GENDER.Location = new System.Drawing.Point(707, 287);
            this.F_GENDER.Name = "F_GENDER";
            this.F_GENDER.Size = new System.Drawing.Size(95, 27);
            this.F_GENDER.TabIndex = 15;
            this.F_GENDER.TabStop = true;
            this.F_GENDER.Text = "FEMALE";
            this.F_GENDER.UseVisualStyleBackColor = true;
            // 
            // O_GENDER
            // 
            this.O_GENDER.AutoSize = true;
            this.O_GENDER.Location = new System.Drawing.Point(846, 287);
            this.O_GENDER.Name = "O_GENDER";
            this.O_GENDER.Size = new System.Drawing.Size(86, 27);
            this.O_GENDER.TabIndex = 16;
            this.O_GENDER.TabStop = true;
            this.O_GENDER.Text = "OTHER";
            this.O_GENDER.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 1055);
            this.Controls.Add(this.O_GENDER);
            this.Controls.Add(this.F_GENDER);
            this.Controls.Add(this.M_GENDER);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.DAY_SELECT);
            this.Controls.Add(this.MONTH_SELECT);
            this.Controls.Add(this.YEAR_SELECT);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.RESET_button);
            this.Controls.Add(this.NAME_textBox);
            this.Controls.Add(this.NS_textBox);
            this.Controls.Add(this.TAX_textBox);
            this.Controls.Add(this.GROSS_textBox);
            this.Controls.Add(this.HR_textBox);
            this.Controls.Add(this.M_textBox);
            this.Controls.Add(this.BASICPAY_textBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DESIG_textBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "PAYROLL";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DESIG_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NAME_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BASICPAY_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox M_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox HR_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox GROSS_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TAX_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox NS_textBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.Button RESET_button;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox YEAR_SELECT;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox MONTH_SELECT;
        private System.Windows.Forms.ComboBox DAY_SELECT;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton M_GENDER;
        private System.Windows.Forms.RadioButton O_GENDER;
        private System.Windows.Forms.RadioButton F_GENDER;
    }
}

