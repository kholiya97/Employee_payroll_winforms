using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Employee_Payroll
{
    public partial class Form1 : Form
    {
        string path = @"Data Source=LAPTOP-BM4J1NMI;Initial Catalog=EMPLOYEE_PAYROLLWIN;Integrated Security=True";
        SqlConnection connection;
        SqlCommand command;
        public string Gender, profileimage;
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(path);
        }

      
      

        //private void IDtextBox_Leave(object sender, EventArgs e)
        //{
        //    if(string.IsNullOrEmpty(IDtextBox.Text))
        //    {
        //        IDtextBox.Focus();
        //        errorProvider1.SetError(this.IDtextBox, "please enter ID...!!");
        //    }
        //    else
        //    {
        //        errorProvider1.Clear();
        //    }
        //}

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
            //IDtextBox.Clear();
            NAME_textBox.Clear();
            DESIG_textBox.Clear();
            BASICPAY_textBox.Clear();
            M_textBox.Clear();
            HR_textBox.Clear();
            GROSS_textBox.Clear();
            TAX_textBox.Clear();
            NS_textBox.Clear();

        }

        private void Submit_button_Click(object sender, EventArgs e)
        {
            if (NAME_textBox.Text == "")
            {
                MessageBox.Show("Please Fill All Feild");
            }
            else
            {
                try
                {

                    if (M_GENDER.Checked == true)
                    {
                        Gender = "Male";
                    }
                    else if (F_GENDER.Checked == true)
                    {
                        Gender = "Female";
                    }
                    else if (O_GENDER.Checked == true)
                    {
                        Gender = "others";
                    }
                    else
                    {
                        MessageBox.Show("Please select a gender");
                    }
                    if (profilepic1.Checked)
                    {
                        profileimage = "1";
                    }
                    else if (profilepic2.Checked)
                    {
                        profileimage = "2";
                    }
                    else if (profilepic3.Checked)
                    {
                        profileimage = "3";
                    }
                    else if(profilepic4.Checked)
                    {
                        profileimage = "4";
                    }
                    else if (profilepic5.Checked)
                    {
                        profileimage = "5";
                    }
                    else
                    {
                        MessageBox.Show("Please select a Profile pic");
                    }
                    connection.Open();
                    SqlCommand command = new SqlCommand("AddEmployee", this.connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NAME", NAME_textBox.Text);
                    command.Parameters.AddWithValue("@GENDER", Gender);
                    command.Parameters.AddWithValue("@PROFILE_pic", profileimage);
                    command.Parameters.AddWithValue("@START_DATE", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@DESIGNATION", DESIG_textBox.Text);
                    command.Parameters.AddWithValue("@BASIC_PAY", BASICPAY_textBox.Text);
                    command.Parameters.AddWithValue("@MEDICAL_ALLOWANCE", M_textBox.Text);
                    command.Parameters.AddWithValue("@HOUSERENT_ALLOWANCE", HR_textBox.Text);
                    command.Parameters.AddWithValue("@GROSS_PAY", GROSS_textBox.Text);
                    command.Parameters.AddWithValue("@NET_SALARY", NS_textBox.Text);
                    command.Parameters.AddWithValue("@INCOME_TAX", TAX_textBox.Text);
                    command.Parameters.AddWithValue("@NOTES", notes_txt.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("FORM SUBMITTED SUCESSFULLY");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        //if(dateTimePicker1.Checked==true)
        //{
        //    MessageBox.Show(dateTimePicker1.Value.ToString());
        //}
        //else
        //{
        //    MessageBox.Show("Please select date ");
        //}

    }
//                catch (Exception ex)
//                {
//                    MessageBox.Show(ex.Message);
//                }

//            }
//        }
//    }
}
