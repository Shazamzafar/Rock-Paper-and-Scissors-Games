//Name:     Shazam Zafar
//Class:    C#
//Date:     02/22/2019
//Project   RockPaperScissors


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperZafar
{
    public partial class Form1 : Form
    {
        //array for elements
        string[] element = new string[] { "rock", "paper", "scissors" };
        Random ran = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        //getting the computer choice
        public int getChoice()
        {
            // Getting computer choice and Displaying Picture 
            int C;
            C=  ran.Next(1, 4);
            if (C == 1)
            {
                pictureBox4.Image = RockPaperZafar.Properties.Resources.rock_paper_scissors_emoji_cartoon_007_512;
            }
            else
            {
                if (C == 2)
                {
                    pictureBox4.Image = RockPaperZafar.Properties.Resources.stack_of_paper_vector_293431;
                }
                else
                {
                    if (C == 3)

                    {
                        pictureBox4.Image = RockPaperZafar.Properties.Resources.download;
                    }

                }
            }
            return C;
        }
        //when rock picture was clicked
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

            int c = getChoice();
        
            winner(c, 1);
        }
        
        public void winner(int comp, int player)
        {
            //if tie
            if (comp == player)
            {
                Result_Label.Text=("its a tie, you both choose " + element[comp - 1]);
            }
            //else determaining the winner
            else if (comp == 1 && player == 2)
            {
                Result_Label.Text = ("you choose " + element[player - 1] + " computer choose " + element[comp - 1] + ", you win");
            }
            else if (comp == 1 && player == 3)
            {
                Result_Label.Text = ("you choose " + element[player - 1] + " computer choose " + element[comp - 1] + ", you lose");
            }
            else if (comp == 2 && player == 1)
            {
                Result_Label.Text = ("you choose " + element[player - 1] + " computer choose " + element[comp - 1] + ", you lose");
            }
            else if (comp == 2 && player == 3)
            {
                Result_Label.Text = ("you choose " + element[player - 1] + " computer choose " + element[comp - 1] + ", you win");
            }
            else if (comp == 3 && player == 1)
            {
                Result_Label.Text = ("you choose " + element[player - 1] + " computer choose " + element[comp - 1] + ", you win");
            }
            else if (comp == 3 && player == 2)
            {
                Result_Label.Text = ("you choose " + element[player - 1] + " computer choose " + element[comp - 1] + ", you lose");
            }
        }
        //when paper was selected
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            int c = getChoice();
            winner(c, 2);
        }
        //when scissors was selected
        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            int c = getChoice();
            winner(c, 3);
        }
        

        private void Exit_button_Click(object sender, EventArgs e)
        {
            // closes the program
            this.Close();
        }
    }
}
