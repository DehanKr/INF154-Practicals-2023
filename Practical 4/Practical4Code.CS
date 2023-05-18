using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF154Prac4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const string USERNAME = "user";
        const string PASSWORD = "1234";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == USERNAME)
            {
                if (txtPass.Text == PASSWORD)
                {
                    lblLoginStatus.Text = "Logged In";
                    MessageBox.Show("You have been successfully logged in!");
                    btnCalculate.Enabled = true;
                    txtName.Enabled = true;
                    txtUnitsUsed.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Incorrect Password! Please enter the correct password.");
                }
            }
            else
            {
                MessageBox.Show("Please enter the correct Username");
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double Units = Convert.ToDouble(txtUnitsUsed.Text);
            string CusName = txtName.Text;
            double Bill = 0;
            double Supercharge = 0;
            string Rate = "";

            if (Units >= 0 && Units <= 40)
            {
                Bill = 100;
                Rate = "R2,5 per unit used.";
            }
            else if (Units >= 41 && Units <= 200)
            {
                Bill = Units * 2.5;
                Rate = "R2,5 per unit used.";
            }
            else if (Units >= 201 && Units <= 400)
            {
                Bill = Units * 5;
                Rate = "R5 per unit used.";
            }
            else if (Units >= 401 && Units <= 600)
            {
                Bill = Units * 7.5;
                Supercharge = Bill * 0.12;
                Bill = Bill + Supercharge;
                Rate = "R7,5 per unit used.";
            }
            else if (Units >= 601)
            {
                Bill = Units * 10;
                Supercharge = Bill * 0.12;
                Bill = Bill + Supercharge;
                Rate = "R10 per unit used.";
            }

            rtbOutput.Text = "Monthly Electricity Bill\n" +
                             "\nCustomer Name : " + CusName +
                             "\nUnit Used : " + Units +
                             "\nCharge Rate : " + Rate +
                             "\nSupercharged Amount: R" + Supercharge +
                             "\nMonthly Bill Due: R" + Bill;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
            lblLoginStatus.Text = "Logged Out";
            txtName.Text = "";
            txtUnitsUsed.Text = "";
            txtName.Enabled = false;
            txtUnitsUsed.Enabled = false;
            btnCalculate.Enabled = false;
            rtbOutput.Text = "";
        }
    }
}
