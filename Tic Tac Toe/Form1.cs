using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        Boolean checker=false;
        int plusone;
        
        void Enable_False()
        {
            button1.Enabled = false;  
            button2.Enabled = false;    
            button6.Enabled = false;
            button7.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;   
            button11.Enabled = false;
            
            //button1.BackColor = Color.White;
            //button3.BackColor = Color.White;
            //button6.BackColor = Color.White;
            //button7.BackColor = Color.White;
            //button4.BackColor = Color.White;
            //button5.BackColor = Color.White;
            //button9.BackColor = Color.White;
            //button10.BackColor = Color.White;
            //button11.BackColor = Color.White;
        }

        void score()
        {
            if(button1.Text=="X" && button2.Text=="X" && button6.Text=="X")
            {

                button1.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                MessageBox.Show("The winner is player 1", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text=Convert.ToString(plusone);
                Enable_False();
              
            }
            
            if (button7.Text == "X" && button4.Text == "X" && button5.Text == "X")
            {
                button7.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                MessageBox.Show("The winner is player 1", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone);
                Enable_False();
            }

            if (button9.Text == "X" && button10.Text == "X" && button11.Text == "X")
            {
                button9.BackColor = Color.Green;
                button10.BackColor = Color.Green;
                button11.BackColor = Color.Green;

                MessageBox.Show("The winner is player 1", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone);
                Enable_False();
            }

            if (button1.Text == "X" && button7.Text == "X" && button9.Text == "X")
            {
                button1.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                button9.BackColor = Color.Green;
                MessageBox.Show("The winner is player 1", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button4.Text == "X" && button2.Text == "X" && button10.Text == "X")
            {
                button4.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button10.BackColor = Color.Green;
                MessageBox.Show("The winner is player 1", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button11.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button11.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button6.BackColor = Color.Green;

                MessageBox.Show("The winner is player 1", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button1.Text == "X" && button4.Text == "X" && button11.Text == "X")
            {
                button1.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button11.BackColor = Color.Green;
                MessageBox.Show("The winner is player 1", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button9.Text == "X" && button4.Text == "X" && button6.Text == "X")
            {
                button9.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button6.BackColor = Color.Green;

                MessageBox.Show("The winner is player 1", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone+1);
                Enable_False();
            }

            //--------------------------------------------------------------------------------------


            if (button1.Text == "O" && button2.Text == "O" && button6.Text == "O")
            {
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                MessageBox.Show("The winner is player 2", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone);
                Enable_False();

                
            }

            if (button7.Text == "O" && button4.Text == "O" && button5.Text == "O")
            {
                button7.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                MessageBox.Show("The winner is player 2", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone);
                Enable_False();
            }

            if (button9.Text == "O" && button10.Text == "O" && button11.Text == "O")
            {
                button9.BackColor = Color.Green;
                button10.BackColor = Color.Green;
                button11.BackColor = Color.Green;
                MessageBox.Show("The winner is player 2", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone);
                Enable_False();
            }

            if (button1.Text == "O" && button7.Text == "O" && button9.Text == "O")
            {
                button1.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                button9.BackColor = Color.Green;
                MessageBox.Show("The winner is player 2", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button4.Text == "O" && button2.Text == "O" && button10.Text == "O")
            {
                button4.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button10.BackColor = Color.Green;

                MessageBox.Show("The winner is player 2", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button11.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                button11.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button6.BackColor = Color.Green;

                MessageBox.Show("The winner is player 2", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button1.Text == "O" && button4.Text == "O" && button11.Text == "O")
            {
                button1.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button11.BackColor = Color.Green;

                MessageBox.Show("The winner is player 2", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button9.Text == "O" && button4.Text == "O" && button6.Text == "O")
            {
                button9.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                MessageBox.Show("The winner is player 2", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();/////////
            }



        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button1.Text = "X";
                checker = true;
                label7.Text = "Player 2";
            }
            else
            {
                button1.Text = "O";
                checker = false;
                label7.Text = "Player 1";
            }
            score();
            button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button2.Text = "X";
                checker = true;
                label7.Text = "Player 2";
            }
            else
            {
                button2.Text = "O";
                checker = false;
                label7.Text = "Player 1";
            }
            score();
            button2.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button6.Text = "X";
                checker = true;
                label7.Text = "Player 2";
            }
            else
            {
                button6.Text = "O";
                checker = false;
                label7.Text = "Player 1";
            }
            score();
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button7.Text = "X";
                checker = true;
                label7.Text = "Player 2";
            }
            else
            {
                button7.Text = "O";
                checker = false;
                label7.Text = "Player 1";
            }
            score();
            button7.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button4.Text = "X";
                checker = true;
                label7.Text = "Player 2";
            }
            else
            {
                button4.Text = "O";
                checker = false;
                label7.Text = "Player 1";
            }
            score();
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button5.Text = "X";
                checker = true;
                label7.Text = "Player 2";
            }
            else
            {
                button5.Text = "O";
                checker = false;
                label7.Text = "Player 1";
            }
            score();
            button5.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button9.Text = "X";
                checker = true;
                label7.Text = "Player 2";
            }
            else
            {
                button9.Text = "O";
                checker = false;
                label7.Text = "Player 1";
            }
            score();
            button9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button10.Text = "X";
                checker = true;
                label7.Text = "Player 2";
            }
            else
            {
                button10.Text = "O";
                checker = false;
                label7.Text = "Player 1";
            }
            score();
            button10.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button11.Text = "X";
                checker = true;
                label7.Text = "Player 2";
            }
            else
            {
                button11.Text = "O";
                checker = false;
                label7.Text = "Player 1";
            }
            score();
            button11.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;

            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button9.BackColor = Color.White;
            button10.BackColor = Color.White;
            button11.BackColor = Color.White;

            button1.Text = "";
            button2.Text = "";
            button6.Text = "";
            button7.Text = "";
            button4.Text = "";
            button5.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";

            label4.Text = "0";
            label5.Text = "0";
            label7.Text = "Player 1";

            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;

            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button9.BackColor = Color.White;
            button10.BackColor = Color.White;
            button11.BackColor = Color.White;

            button1.Text = "";
            button2.Text = "";
            button6.Text = "";
            button7.Text = "";
            button4.Text = "";
            button5.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            label7.Text = "Player 1";

            button14.Enabled = true;

        }

       

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
