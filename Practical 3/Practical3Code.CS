using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF154Prac3u22507176
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Global variable declarations
        double TOTAL = 0;

        // Constant lifetime limit
        const double LIFE_LIMIT = 500000;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Defining contribution and adding to list
            double Contribution = Convert.ToDouble(nudContribution.Text);
            lbxSavings.Items.Add(Contribution);
            
            // Updating total contributions with new amount
            TOTAL = TOTAL + Contribution;

            // Updating read-only information with their relevant calculations
            txtTotal.Text = Convert.ToString(TOTAL);
            txtRemaining.Text = Convert.ToString(LIFE_LIMIT - TOTAL);
            txtPercentageLimit.Text = Convert.ToString(TOTAL/LIFE_LIMIT*100);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Reset total contributions variable to zero
            TOTAL = 0;

            // Clear list of contributions
            lbxSavings.Items.Clear();

            // Clear all read-only and modifiable boxes and dropdowns
            txtTotal.Text = "";
            txtRemaining.Text = "";
            txtPercentageLimit.Text = "";
            nudAnnualContribution.Value = 0;
            nudContribution.Value = 0;
            txtYearsUntilLimit.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Defining annual contribution and calculation for years left with rounded value
            double AnnualContribution = Convert.ToDouble(nudAnnualContribution.Value);
            double YearsLeft = Math.Round(LIFE_LIMIT / AnnualContribution);

            // Update years left textbox
            txtYearsUntilLimit.Text = Convert.ToString(YearsLeft);
        }
    }
}
