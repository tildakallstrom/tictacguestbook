using System;
using System.Drawing;
using System.Windows.Forms;

namespace CTicTacToe
{    //class for this project
    public partial class Form1 : Form
    {
        //Code for tic tac toe
        int plusone;
        //who = which player
        char who = 'O';
        short movement = 0;
        public Form1()
        {
            InitializeComponent();
        }
       

        //if new game button is clicked - new game is started with the scoreboard from the last game
        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            who = 'O';
            movement = 0;
            //clear the buttons
            b1.Enabled = true; b1.BackColor = Color.PowderBlue; b1.Text = "";
            b2.Enabled = true; b2.BackColor = Color.PowderBlue; b2.Text = "";
            b3.Enabled = true; b3.BackColor = Color.PowderBlue; b3.Text = "";
            b4.Enabled = true; b4.BackColor = Color.PowderBlue; b4.Text = "";
            b5.Enabled = true; b5.BackColor = Color.PowderBlue; b5.Text = "";
            b6.Enabled = true; b6.BackColor = Color.PowderBlue; b6.Text = "";
            b7.Enabled = true; b7.BackColor = Color.PowderBlue; b7.Text = "";
            b8.Enabled = true; b8.BackColor = Color.PowderBlue; b8.Text = "";
            b9.Enabled = true; b9.BackColor = Color.PowderBlue; b9.Text = "";
            tableLayoutPanel1.Enabled = true;
            

        }

     

        //if info button is clicked
        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //messagebox with info about this game
            MessageBox.Show("This is a Tic Tac Toe game with a fuestbook created by Tilda Källström for the course Programmering i C#.NET at Mid Sweden University.\n\n" +
                "Start the game by clicking on a square (Player O always starts first), then let your component player X play.\n" +
                "Points are counted at the ScoreBoard. To play again simply click on Play again button.\n" +
                "To reset the game and loose your points, click on New Game.\n\n" +
                "To use the guestbook - fill in your name and message.\n" +
                "You can delete or update a written message by clicking on the buttons.\n\n" +
                "HAPPY GAMING!");
            
        }

        //If new game is clicked, the game restarts
        private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            who = 'O';
            movement = 0;
            //clear the buttons
            b1.Enabled = true; b1.BackColor = Color.PowderBlue; b1.Text = "";
            b2.Enabled = true; b2.BackColor = Color.PowderBlue; b2.Text = "";
            b3.Enabled = true; b3.BackColor = Color.PowderBlue; b3.Text = "";
            b4.Enabled = true; b4.BackColor = Color.PowderBlue; b4.Text = "";
            b5.Enabled = true; b5.BackColor = Color.PowderBlue; b5.Text = "";
            b6.Enabled = true; b6.BackColor = Color.PowderBlue; b6.Text = "";
            b7.Enabled = true; b7.BackColor = Color.PowderBlue; b7.Text = "";
            b8.Enabled = true; b8.BackColor = Color.PowderBlue; b8.Text = "";
            b9.Enabled = true; b9.BackColor = Color.PowderBlue; b9.Text = "";
            tableLayoutPanel1.Enabled = true;
            lblPlayerX.Text = "0";
            lblPlayerO.Text = "0";
        }


        //if gamebuttons are clicked
        private void Button_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            //make sure a clicked button cant be clicked again
            bt.Enabled = false;
            //change color on clicked buttons
            bt.BackColor = Color.Orange;
            if(who == 'O')
            {
                //if three in a row - winner is O
                bt.Text = "O";
                if((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "") ||
                    (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") ||
                    (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") ||
                    (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                    (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                    (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "") ||
                    (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "") ||
                    (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))
                { //{who.ToString().ToUpper()}
                    MessageBox.Show(($"The winner is Player O!"));
                    tableLayoutPanel1.Enabled = false;
                    plusone = int.Parse(lblPlayerO.Text);
                    lblPlayerO.Text = Convert.ToString(plusone + 1);
                } else if(movement == 8)
                {
                    MessageBox.Show("Draw!");
                }
                who = 'X';
            }
            else if (who == 'X'){
                //change backcolor and text if clicked by player X
                bt.BackColor = Color.Yellow;
                bt.Text = "X";
                //if three in a row
                if ((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "") ||
                   (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") ||
                   (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") ||
                   (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                   (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                   (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "") ||
                   (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "") ||
                   (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))
                {
                    MessageBox.Show(($"The winner is Player X!"));
                    tableLayoutPanel1.Enabled = false;
                    plusone = int.Parse(lblPlayerX.Text);
                    lblPlayerX.Text = Convert.ToString(plusone + 1);
                }
                else if (movement == 8)
                {
                    MessageBox.Show("Draw!");
                }
                who = 'O';
            }
            movement++;
        
        }
        //
        //code for guestbook

        //add button to add message
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //if its not filled in correctly - send messagebox
            if (txtName.Text == "" || txtMessage.Text == "") {
                MessageBox.Show("Fill in correctly!");
                
            } else
            {
                //add to Data Grid View
                dgv.Rows.Add(txtName.Text, txtMessage.Text);
            }
        }

        //update message, click on cells to choose which to update (name or message)
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //if data grid view is not empty
            if (dgv.CurrentRow != null)
            {
                
                if (txtName.Text == "" || txtMessage.Text == "")
                {
                    MessageBox.Show("Fill in correctly!");

                }
                else
                {
                    dgv.CurrentRow.Cells["name"].Value = txtName.Text;
                    dgv.CurrentRow.Cells["message"].Value = txtMessage.Text;
                }
            }
        }

        //delete a single message
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //if dgv is not empty
            if (dgv.CurrentRow != null)
            {
                //remove the selected row
                dgv.Rows.RemoveAt(dgv.CurrentRow.Index);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
   
}
