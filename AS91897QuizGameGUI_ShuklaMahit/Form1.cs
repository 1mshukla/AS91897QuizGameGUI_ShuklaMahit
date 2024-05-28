using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                if (player.Bottom == answerD.Top && (player.Right > answerD.Left && player.Left < answerD.Right))
                {
                    fall = false;
                }
                else
                {
                    fall = true;
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
    }
}
