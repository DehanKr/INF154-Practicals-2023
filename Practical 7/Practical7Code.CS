using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF154Prac7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Global declaration for timer variables
        int sec = 00, min = 00, hour, ms;

        private void btnDraw_Click(object sender, EventArgs e)
        {
            //Get length and height input from numeric dropdowns
            int height = Convert.ToInt32(nudHeight.Value);
            int length = Convert.ToInt32(nudLength.Value);

            //Conditional check for radio button shape selection
            //Rectangle full draw
            if (radRectangle.Checked == true)
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        rtxOutput.Text += "*\t";
                    }
                    rtxOutput.Text += "\n";
                }
            }
            //Triangle full draw
            else if (radTriangle.Checked == true)
            {
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        rtxOutput.Text += "*\t";
                    }
                    rtxOutput.Text += "\n";
                }
            }
            //Prompt to select a shape
            else
            {
                MessageBox.Show("Please select a shape.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear rich text box
            rtxOutput.Clear();
        }

        private void btnHollow_Click(object sender, EventArgs e)
        {
            //Get length and height input from numeric dropdowns
            int height = Convert.ToInt32(nudHeight.Value);
            int length = Convert.ToInt32(nudLength.Value);

            //Conditional check for radio button shape selection
            //Rectangle hollow draw
            if (radRectangle.Checked == true)
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        if (i == 0 || j == 0 || i == height - 1 || j == length - 1)
                        {
                            rtxOutput.Text += "*\t";
                        }
                        else
                        {
                            rtxOutput.Text += "\t";
                        }
                    }
                    rtxOutput.Text += "\n";
                }
            }
            //Triangle hollow draw
            else if (radTriangle.Checked == true)
            {
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        if (j == 0 || j == i || i == length - 1)
                        {
                            rtxOutput.Text += "*\t";
                        }
                        else
                        {
                            rtxOutput.Text += "\t";
                        }
                    }
                    rtxOutput.Text += "\n";
                }
            }
            //Prompt to select a shape
            else
            {
                MessageBox.Show("Please select a shape.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Update timer label on tick event and add milliseconds
            lblTimer.Text = Convert.ToString(hour + " : " + min + " : " + sec);
            ms++;
            
            //Check if a second has passed
            if (ms == 10)
            {
                sec = sec + 1;
                ms = 1;
            }
            //Check if a minute has passed
            if (sec == 60)
            {
                min = min + 1;
                sec = 0;
            }
            //Check if an hour has passed
            if (min == 60)
            {
                hour = hour + 1;
                min = 1;
            }
        }
    }
}
