using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF154Prac6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            //Reset listbox and create new instance of Random class
            lstGrades.Items.Clear();
            Random RandomGrade = new Random();

            int i = 0;

            //Add a random double value to listbox for 10 counts
            while (i < 10) 
            {
                decimal Grade = Convert.ToDecimal((RandomGrade.NextDouble()) * 100);
                Grade = Decimal.Round(Grade, 1);
                lstGrades.Items.Add(Grade);
                i++;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
        //Conditional statements to check for radio button selection
            if (radAvgGrade.Checked == true)
            {
                double sum = 0;
                int lstCount = lstGrades.Items.Count;
                int i = 0;

                //Cycle through and add all values from listbox and store in sum variable
                while(i < lstCount)
                {
                    sum += Convert.ToDouble(lstGrades.Items[i]);
                    i++;
                }

                //Divide sum of grades by the count of grades
                double avg = sum / lstCount;

                MessageBox.Show("The average grade is " + avg);
            }
            else if (radCatGrades.Checked == true)
            {
                int lstCount = lstGrades.Items.Count;
                int i = 0;
                int PassCount = 0, FailCount = 0;

                //Cycle through all items in listbox
                while (i < lstCount)
                {
                    //If grade is >=50 increment passed counter, otherwise increment fail counter
                    if (Convert.ToDouble(lstGrades.Items[i]) >= 50.0)
                    {
                        PassCount++;
                    }
                    else
                    {
                        FailCount++;
                    }
                    i++;
                }

                MessageBox.Show("Passed:" + PassCount + "\n" + "Failed:" + FailCount);
            }
            else if (radSort.Checked == true)
            {
                int lstCount = lstGrades.Items.Count;
                int i = 0;

                //Initiate array with 10 values to store grades in
                decimal[] GradeArray = {0.0m, 0.0m, 0.0m, 0.0m, 0.0m, 0.0m, 0.0m, 0.0m, 0.0m, 0.0m};

                //Cycle through grades in listbox and add each grade to previously created array
                while (i < lstCount)
                {
                    GradeArray[i] = Convert.ToDecimal(lstGrades.Items[i]);
                    i++;
                }

                //Sort the array in numercial ascending order
                Array.Sort(GradeArray);

                //Reset counter variable to use in another while loop
                i = 0;

                //Cycle through all values in the sorted array and add them to listbox, replacing the unsorted grades
                while (i < lstCount)
                {
                    lstGrades.Items[i] = Decimal.Round(Convert.ToDecimal(GradeArray[i]), 1);
                    i++;
                }
            }

            //If no radio button is selected, display error message
            else
            {
                MessageBox.Show("Please select an option before submitting");
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Update label to display selected number
            lblFactorial.Text = "The Factorial of " + nudNumber.Value + " is:";

            int Number = Convert.ToInt32(nudNumber.Value);
            int Answer = 1;

            //Decrement number and multiply each instance of the number from its original value until it reaches 1
            while (Number > 0)
            {
                Answer = Number * Answer;
                Number--;
            }

            //Display answer in text box
            txtFactorial.Text = Convert.ToString(Answer);
        }
    }
}
