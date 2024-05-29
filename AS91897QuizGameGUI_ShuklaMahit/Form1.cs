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
    public partial class Form1 : Form
    {
        //declare costants
        const int MOVE = 5;
        //declare variables
        int gravity = 2;
        int jumpUp = 20;
        bool left;
        bool right;
        bool fall;
        bool jump;
        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //declare variables
            

        }
        //private void Questions()
        //{
        //    //string line;
        //    using (StreamReader things = File.OpenText("QuizQuestions.csv"))
        //    {
        //        while (things.ReadLine() != null)
        //        {
        //            MessageBox.Show($"Getting questions; {things}");
        //        }
        //    }
        //}

        private void Form1_KeyDown(object sender, KeyEventArgs e)
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

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
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

        private void timer_Tick(object sender, EventArgs e)
        {

            
            if (right == true)
            {
                player.Left += MOVE; 
            }
            else if (left == true)
            {
                player.Left -= MOVE;
            }
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
            if (player.Bounds.IntersectsWith(answerA.Bounds) == false && player.Bounds.IntersectsWith(answerB.Bounds) == false && player.Bounds.IntersectsWith(answerC.Bounds) == false && player.Bounds.IntersectsWith(answerD.Bounds) == false && player.Bounds.IntersectsWith(block1.Bounds) == false && player.Bounds.IntersectsWith(block2.Bounds) == false && player.Bounds.IntersectsWith(block3.Bounds) == false && player.Bounds.IntersectsWith(block4.Bounds) == false)
            {
                
            }
            if (player.Bottom < this.Height)
            {
                //if (player.Bottom == answerD.Top && (player.Right > answerD.Left && player.Left < answerD.Right))
                //{
                //    fall = false;
                //}
                //else if (player.Bottom == answerC.Top && (player.Right > answerC.Left && player.Left < answerC.Right))
                //{
                //    fall = false;
                //}
                //else if (player.Bottom == answerB.Top && (player.Right > answerB.Left && player.Left < answerB.Right))
                //{
                //    fall = false;
                //}
                //else if (player.Bottom == answerA.Top && (player.Right > answerA.Left && player.Left < answerA.Right))
                //{
                //    fall = false;
                //}
                //else if (player.Bottom == block1.Top && (player.Right > block1.Left && player.Left < block1.Right))
                //{
                //    fall = false;
                //}
                //else if (player.Bottom == block2.Top && (player.Right > block2.Left && player.Left < block2.Right) && fall == true)
                //{
                //    fall = false;
                //}
                //else if (player.Bottom == block3.Top && (player.Right > block3.Left && player.Left < block3.Right))
                //{
                //    fall = false;
                //}
                //else if (player.Bottom == block4.Top && (player.Right > block4.Left && player.Left < block4.Right))
                //{
                //    fall = false;
                //}
                
                    fall = true;
                
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "object")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && fall ==true)
                    {
                        fall = false;
                    }
                }
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
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        ////    Questions();
        //}
    }   
}
