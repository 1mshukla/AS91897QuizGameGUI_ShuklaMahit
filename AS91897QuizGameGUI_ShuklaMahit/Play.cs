using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AS91897QuizGameGUI_ShuklaMahit
{
    
    
    public partial class Play : Form
    {
        //declare arrays
        // declare multidimensional array
        string[,] questionBank = new string[10, 7];
        //declare costants
        const int MOVE = 5;
        //declare variables
        int gravity = 2;
        int jumpUp = 20;
        int counter = 0;
        bool left;
        bool right;
        bool fall;
        bool jump;

        public Play()
        {
            InitializeComponent();

            
            //string line;
            using (StreamReader things = File.OpenText("K:/2024_SR_12IT1/Programming/AS91897QuizGameGUI_ShuklaMahit/QuizQuestions final.csv"))
            {
                while (things != null)
                {
                    //if (i+1 <= questionBank.GetLength(2))
                    //{
                        string[] line = new string[7];
                        line = things.ReadLine().Split(',');

                        for (int j = 0; j < line.Length; j++)
                        {
                            //MessageBox.Show($"{line[j]}");
                            //string quest = ;
                            questionBank[i - 1, j] = line[j]; //things.ReadLine().Split(',');
                        MessageBox.Show(j.ToString());
                            //MessageBox.Show($"{questionBank[i - 1, j]}");

                        }
                    //}
                    //else
                    //{   
                    //    MessageBox.Show($"break");
                    //    break;

                    //}

                }
                
            }
        }

        private void Play_KeyDown_1(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Left)
            {

                left = true;
            }
            else if (e.KeyCode == Keys.Right)
            {

                right = true;
            }
            if (jump != true && fall != true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    jump = true;
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
                //this.Close();
            }
        }

        private void Play_KeyUp_1(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
        }
        

        private void timerTick_Tick(object sender, EventArgs e)
        {
            //if (counter > questionBank.GetLength(2))
            //{
            //    MessageBox.Show("THANK YOU FOR PLAYING, QUIZ FINISHED!");
            //    Application.Exit();
            //}

            listBox1.Items.Add($"Question: {questionBank[counter, 0]}");
            listBox1.Items.Add($"Answer A is {questionBank[counter, 1]}");
            listBox1.Items.Add($"Answer B is {questionBank[counter, 2]}");
            listBox1.Items.Add($"Answer C is {questionBank[counter, 3]}");
            listBox1.Items.Add($"Answer D is {questionBank[counter, 4]}");


            if (jump == true)
            {
                if (jumpUp > 0)
                {
                    player.Top -= jumpUp;
                    jumpUp -= 1;
                }
                else
                {
                    jump = false;
                    jumpUp = 20;
                }


            }

            if (player.Bottom < this.Height)
            {
                fall = true;

            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "object")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && jump == true && player.Top < x.Bottom)
                    {
                        //jump = false;
                        fall = true;
                    }
                    if (player.Bounds.IntersectsWith(x.Bounds) && right == true && fall == true && player.Bottom - 2 > x.Top)
                    {
                        right = false;
                    }
                    if (player.Bounds.IntersectsWith(x.Bounds) && left == true && fall == true && player.Bottom - 2 > x.Top)
                    {
                        left = false;
                    }
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        fall = false;
                    }
                }
            }

            if (right == true)
            {
                player.Left += MOVE;
            }
            else if (left == true)
            {
                player.Left -= MOVE;
            }

            //induces fall and stops if reached bottom
            if (fall == true)
            {
                if (player.Bottom > this.Height - 40)
                {
                    fall = false;
                }
                else
                {
                    player.Top += gravity;
                }
            }
            //checks answer
            if (player.Bounds.IntersectsWith(answerA.Bounds))
            {
                if (questionBank[counter, 5] == "A")
                {
                    MessageBox.Show($"CORRECT. THE ANSWER IS: {questionBank[counter, 6]}");
                    player.Location = new Point(408, 231);
                    counter++;
                }
                else
                {
                    MessageBox.Show($"INCORRECT. THE ANSWER IS: {questionBank[counter, 6]}");
                    player.Location = new Point(408, 231);
                    counter++;
                }
            }
            if (player.Bounds.IntersectsWith(answerB.Bounds))
            {
                if (questionBank[counter, 5] == "B")
                {
                    MessageBox.Show($"CORRECT. THE ANSWER IS: {questionBank[counter, 6]}");
                    player.Location = new Point(408, 231);
                    counter++;
                }
                else
                {
                    MessageBox.Show($"INCORRECT. THE ANSWER IS: {questionBank[counter, 6]}");
                    player.Location = new Point(408, 231);
                    counter++;
                }
            }
            if (player.Bounds.IntersectsWith(answerC.Bounds))
            {
                if (questionBank[counter, 5] == "C")
                {
                    MessageBox.Show($"CORRECT. THE ANSWER IS: {questionBank[counter, 6]}");
                    player.Location = new Point(408, 231);
                    counter++;
                }
                else
                {
                    MessageBox.Show($"INCORRECT. THE ANSWER IS: {questionBank[counter, 6]}");
                    player.Location = new Point(408, 231);
                    counter++;
                }
            }
            if (player.Bounds.IntersectsWith(answerD.Bounds))
            {
                if (questionBank[counter, 5] == "D")
                {
                    MessageBox.Show($"CORRECT. THE ANSWER IS: {questionBank[counter, 6]}");
                    player.Location = new Point(408, 231);
                    counter++;
                }
                else
                {
                    MessageBox.Show($"INCORRECT. THE ANSWER IS: {questionBank[counter, 6]}");
                    player.Location = new Point(408, 231);
                    counter++;
                }
            }

        }

        

    }
}
