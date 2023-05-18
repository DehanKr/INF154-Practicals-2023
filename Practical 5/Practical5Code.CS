using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF154Prac5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declaration of global variables
        string NAME, SURNAME, FULLNAME;
        int PLAYERSCORE = 0;
        int DEALERSCORE = 0;

        private void btnDeal_Click(object sender, EventArgs e)
        {
            int PlayerCard, DealerCard;
            string CardTextPlayer, CardTextDealer;

            //Create an instance of Random for card generation and generate cards
            Random randomCard = new Random();
            PlayerCard = randomCard.Next(2, 15);
            DealerCard = randomCard.Next(2, 15);

            //Switch cases to handle card names from 11-14 for player
            switch (PlayerCard)
                {
                    case 11:
                        CardTextPlayer = "JACK";
                        txtPlayerCard.Text = CardTextPlayer;
                        break;
                    case 12:
                        CardTextPlayer = "QUEEN";
                        txtPlayerCard.Text = CardTextPlayer;
                        break;
                    case 13:
                        CardTextPlayer = "KING";
                        txtPlayerCard.Text = CardTextPlayer;
                        break;
                    case 14:
                        CardTextPlayer = "ACE";
                        txtPlayerCard.Text = CardTextPlayer;
                        break;
                    default:
                        txtPlayerCard.Text = Convert.ToString(PlayerCard);
                        break;
                }

            //Switch cases to handle card names from 11-14 for dealer
            switch (DealerCard)
                {
                    case 11:
                        CardTextDealer = "JACK";
                        txtDealerCard.Text = CardTextDealer;
                        break;
                    case 12:
                        CardTextDealer = "QUEEN";
                        txtDealerCard.Text = CardTextDealer;
                        break;
                    case 13:
                        CardTextDealer = "KING";
                        txtDealerCard.Text = CardTextDealer;
                        break;
                    case 14:
                        CardTextDealer = "ACE";
                        txtDealerCard.Text = CardTextDealer;
                        break;
                    default:
                        txtDealerCard.Text = Convert.ToString(DealerCard);
                        break;
                }

            //Check for winner, increment their score and change panel color accordingly
            if (PlayerCard > DealerCard)
            {
                PLAYERSCORE++;
                txtPlayerScore.Text = Convert.ToString(PLAYERSCORE);
                pnlResult.BackColor = Color.Green;
            }
            else
            {
                DEALERSCORE++;
                txtDealerScore.Text = Convert.ToString(DEALERSCORE);
                pnlResult.BackColor = Color.Red;
            }
        }

        private void btnSetPicture_Click(object sender, EventArgs e)
        {
            //Open file select dialog, load image into picture box and make game visible
            ofdProfilePic.ShowDialog();
            pbxProfilePic.Image = Image.FromFile(ofdProfilePic.FileName);
            gbxGame.Visible = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            NAME = txtFirstName.Text;
            SURNAME = txtLastName.Text;
            FULLNAME = NAME + " " + SURNAME;

            //Check and prompt for empty fields during registration
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("Please enter details in empty fields");
            }
            else if(txtLastName.Text == "")
            {
                MessageBox.Show("Please enter details in empty fields");
            }
            else
            {
                gbxDetails.Visible = true;
                txtFullName.Text = FULLNAME;
            }
        }
    }
}
