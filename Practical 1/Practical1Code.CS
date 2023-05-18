using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF154Prac1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            this.pnlRed.Visible = true;
            this.pnlYellow.Visible = false;
            this.pnlGreen.Visible = false;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            this.pnlRed.Visible = false;
            this.pnlYellow.Visible = true;
            this.pnlGreen.Visible = false;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            this.pnlRed.Visible = false;
            this.pnlYellow.Visible = false;
            this.pnlGreen.Visible = true;
        }
    }
}
