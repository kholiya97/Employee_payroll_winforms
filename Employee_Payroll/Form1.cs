using System;
using System.Windows.Forms;

namespace Employee_Payroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
      

        private void IDtextBox_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(IDtextBox.Text))
            {
                IDtextBox.Focus();
                errorProvider1.SetError(this.IDtextBox, "please enter ID...!!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void NAME_textBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NAME_textBox.Text))
            {
                NAME_textBox.Focus();
                errorProvider2.SetError(this.NAME_textBox, "please enter Name ..!!");
            }
            else
            {
                errorProvider2.Clear();
            }

        }

        private void DESIG_textBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DESIG_textBox.Text))
            {
                DESIG_textBox.Focus();
                errorProvider3.SetError(this.DESIG_textBox, "please enter Designation!!");
            }
            else
            {
                errorProvider3.Clear();
            }

        }

        private void BASICPAY_textBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BASICPAY_textBox.Text))
            {
                BASICPAY_textBox.Focus();
                errorProvider4.SetError(this.BASICPAY_textBox, "please enter basicpay!!");
            }
            else
            {
                errorProvider4.Clear();
            }

        }

        private void BASICPAY_textBox_TextChanged(object sender, EventArgs e)
        {
            int MA, HR, grossPay, IT,netSalary;
            int basicPay = 0;
            if(string.IsNullOrEmpty(BASICPAY_textBox.Text))
            {
                BASICPAY_textBox.Focus();
                errorProvider4.SetError(this.BASICPAY_textBox, "Please fill the required field ");
            }
            else
            {
                errorProvider4.Clear();
                basicPay = Convert.ToInt32(BASICPAY_textBox.Text);
            }
            //int basicPay = Convert.ToInt32(BASICPAY_textBox.Text);
            

            if (basicPay>=40000)
            {
                MA = (int) (basicPay * 0.30);
                M_textBox.Text = MA.ToString();
                HR = (int)(basicPay * 0.20);
                HR_textBox.Text = HR.ToString();
                grossPay = basicPay + MA + HR;
                GROSS_textBox.Text = grossPay.ToString();

                if (grossPay>=60000)
                {
                    IT = (int)(grossPay * 0.03);
                    TAX_textBox.Text = IT.ToString();
                    netSalary = grossPay - IT;
                    NS_textBox.Text = netSalary.ToString();
                }
                else if (grossPay >= 50000)
                {
                    IT = (int)(grossPay * 0.02);
                    TAX_textBox.Text = IT.ToString();
                    netSalary = grossPay - IT;
                    NS_textBox.Text = netSalary.ToString();
                }
            }

            else if (basicPay >= 30000)
            {
                MA = (int)(basicPay * 0.25);
                M_textBox.Text = MA.ToString();
                HR = (int)(basicPay * 0.15);
                HR_textBox.Text = HR.ToString();
                grossPay = basicPay + MA + HR;
                GROSS_textBox.Text = grossPay.ToString();

                if (grossPay >= 60000)
                {
                    IT = (int)(grossPay * 0.03);
                    TAX_textBox.Text = IT.ToString();
                    netSalary = grossPay - IT;
                    NS_textBox.Text = netSalary.ToString();
                }
                else if (grossPay >= 50000)
                {
                    IT = (int)(grossPay * 0.02);
                    TAX_textBox.Text = IT.ToString();
                    netSalary = grossPay - IT;
                    NS_textBox.Text = netSalary.ToString();
                }
            }

            else
            {
                MA = 2000;
                M_textBox.Text = MA.ToString();
                HR = 1000;
                HR_textBox.Text = HR.ToString();
                grossPay = basicPay + MA + HR;
                GROSS_textBox.Text = grossPay.ToString();

                
                   
                    TAX_textBox.Text = "No Tax Applied";
                    netSalary = grossPay;
                    NS_textBox.Text = netSalary.ToString();
                
            }
        }

        private void RESET_button_Click(object sender, EventArgs e)
        {
            IDtextBox.Clear();
            NAME_textBox.Clear();
            DESIG_textBox.Clear();
            BASICPAY_textBox.Clear();
            M_textBox.Clear();
            HR_textBox.Clear();
            GROSS_textBox.Clear();
            TAX_textBox.Clear();
            NS_textBox.Clear();

        }

      
    }
}
