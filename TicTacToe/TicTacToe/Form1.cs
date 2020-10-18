using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        bool turn = true;
        int turn_count = 0;
        
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkForWinner();
        }
        private void disableButtons()
        {
            
            foreach(Control c in Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
                
            }
        }
        private void checkForWinner()
        {
            bool thereIsAWinner = false;
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text)&& (!A1.Enabled))
            {
                thereIsAWinner = true;
               // MessageBox.Show("Winner");
            }
               else if ((B1.Text == B2.Text) && (B2.Text == B3.Text)&&((!B1.Enabled)))
            {
                thereIsAWinner = true;
                //MessageBox.Show("Winner");
            }
                   else if ((C1.Text == C2.Text) && (C2.Text == C3.Text)&&(!C1.Enabled))
                    {
                        thereIsAWinner = true;
                // MessageBox.Show("Winner");

                    }
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                thereIsAWinner = true;
                // MessageBox.Show("Winner");
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                thereIsAWinner = true;
                // MessageBox.Show("Winner");
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                thereIsAWinner = true;
                // MessageBox.Show("Winner");
            }
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!C3.Enabled))
            {
                thereIsAWinner = true;
                // MessageBox.Show("Winner");
            }
            else if((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            {
                thereIsAWinner = true;
                // MessageBox.Show("Winner");
            }



            if (thereIsAWinner)
            {
                disableButtons();
                string winner = "";
                if (turn)
                {
                    winner = "O";
                }
                else
                {
                    winner = "X";
                    MessageBox.Show("Winner is " + winner);
                }
                    if (turn_count == 9)
                    {
                        MessageBox.Show("Draw");
                    }
                
                
            
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }

            }
        }
    }

}
