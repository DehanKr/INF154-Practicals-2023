using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF154Prac2u22507176
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Name, Surname, FullName;

            Name = txtName.Text;
            Surname = txtSurname.Text;
            FullName = Name + " " + Surname;

            this.lbxTeamA.Items.Add(FullName);

            MessageBox.Show(FullName + " has successfully been added to Team A");
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            string Item;
            Item = (string)lbxTeamA.SelectedItems[0];
            lbxTeamB.Items.Add(Item);
            lbxTeamA.Items.Remove(Item);
            
            MessageBox.Show("The selected player: " + Item + " has been transferred successfully to Team B");
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            string Item;
            Item = (string)lbxTeamB.SelectedItems[0];
            lbxTeamA.Items.Add(Item);
            lbxTeamB.Items.Remove(Item);

            MessageBox.Show("The selected player: " + Item + " has been transferred successfully to Team A");
        }

        private void btnWithoutCommission_Click(object sender, EventArgs e)
        {
            int Salary = 500;

            MessageBox.Show("Your weekly salary without commission is: R" + Salary);
        }

        private void btnIncludingCommission_Click(object sender, EventArgs e)
        {
            double Salary = 500;
            double Percent, Amount, Total;

            Percent = Convert.ToDouble(txtCommissionPercentage.Text);
            Amount = Convert.ToDouble(txtAmountSold.Text);

            Total = (Percent * 0.01 * Amount) + Salary;

            Total = Convert.ToInt32(Total);

            MessageBox.Show("Your weekly salary, including commission is: R" + Total);
        }
    }
}
