using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashBoard_emppayroll
{

    public partial class Form2 : Form
    {
        string path = @"Data Source=LAPTOP-BM4J1NMI;Initial Catalog=EMPLOYEE_PAYROLLWIN;Integrated Security=True";
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adp;
        DataTable dt;
        public static int ID;
        public Form2()
        {
            InitializeComponent();
            connection = new SqlConnection(path);
            display();
        }

        private void add_emp_Click(object sender, EventArgs e)
        
            {
            connection.Open();
                SqlCommand command = new SqlCommand("AddEmployee", this.connection);

            connection.Close();
                MessageBox.Show("Your record added sucessfully ");

            }
        
        public void display()
        {
            try
            {
                dt = new DataTable();
                connection.Open();
                adp = new SqlDataAdapter("SELECT Employee.ID,Employee.Name,Employee.Gender,Employee.PROFILE_pic,Employee.START_DATE,Employee.DESIGNATION,Employee.BASIC_PAY,Employee.MEDICAL_ALLOWANCE,Employee.HOUSERENT_ALLOWANCE,Employee.GROSS_PAY,Employee.NET_SALARY,Employee.INCOME_TAX,Employee.NOTES from Employee", connection);
                adp.Fill(dt);
                ADD_employee_grid.DataSource = dt;
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            
                //id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (ID > 0)
                {
                connection.Open();
                    command = new SqlCommand("DELETE FROM Employee WHERE ID='" + ID + "'", connection);
                    command.ExecuteNonQuery();
                connection.Close();
                    MessageBox.Show("Record Deleted From Data");
                    display();
                }
                else
                {
                    MessageBox.Show("Please select Row");
                }

            
        }

        private void ADD_employee_grid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(ADD_employee_grid.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
