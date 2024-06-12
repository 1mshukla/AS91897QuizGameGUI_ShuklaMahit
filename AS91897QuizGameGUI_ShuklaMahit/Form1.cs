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
       // //declare arrays
       // string[] questionBank = new string[6];
       // //declare costants
       // const int MOVE = 5;
       // //declare variables
       // int gravity = 2;
       // int jumpUp = 20;
       // bool left;
       // bool right;
       // bool fall;
       // bool jump;
       // int counter = 0;
        public Form1()
        {
            InitializeComponent();

        }
        public void button1_Click_1(object sender, EventArgs e)
        {
            Play window = new Play();
            window.ShowDialog();
            this.Hide();

            //string line;
            //using (StreamReader things = File.OpenText("QuizQuestions.csv"))
            //{
            //    for (int i = 0; i < File.ReadAllLines("QuizQuestions.csv").Length; i++)
            //    {
            //        line = things.ReadLine();
            //        questionBank[i] = line;
            //        MessageBox.Show($"{questionBank[i]}");
            //        //counter += 1;
            //    }
            //    
            //}
            //
            //foreach (string d in questionBank)
            //{
            //    listBox1.Items.Add(d);
            //}

        }
        

        //private void pictureBox1_Click(object sender, EventArgs e)
       // {
            //declare variables
            

        //}
       // private void Questions()
        //{
            
            
        //}

        //private void Form1_KeyDown(object sender, KeyEventArgs e)
        //{
           // if (e.KeyCode == Keys.Left)
           // {
           //     left = true;
           // }
           // else if (e.KeyCode == Keys.Right)
           // {
           //     
           //     right = true;
           // }
           // if (jump != true && fall != true)
           // {
           //     if (e.KeyCode == Keys.Space)
           //     {
           //         jump = true;
           //     }
           // }

        //}

       // private void Form1_KeyUp(object sender, KeyEventArgs e)
       // {//
          //  if (e.KeyCode == Keys.Left)
          //  {
          //      left = false;
          //  }
          //  else if (e.KeyCode == Keys.Right)
          //  {
          //      right = false;
          //  }

        //}

        //private void timer_Tick(object sender, EventArgs e)
        //{
            //if (jump == true)
            //{
            //    if (jumpUp > 0)
            //    {
            //        player.Top -= jumpUp;
            //        jumpUp -= 1;
            //    }
            //    else
            //    {
            //        jump = false;
            //        jumpUp = 20;
            //    }
            //    
            //
            //}
            //
            //if (player.Bottom < this.Height)
            //{
            //    fall = true;
            //
            //}
            //
            //foreach (Control x in this.Controls)
            //{
            //    if (x is PictureBox && (string)x.Tag == "object")
            //    {
            //        if (player.Bounds.IntersectsWith(x.Bounds) && jump == true && player.Top < x.Bottom)
            //        {
            //            //jump = false;
            //            fall = true;
            //        }
            //        if (player.Bounds.IntersectsWith(x.Bounds) && right == true && fall == true && player.Bottom -2 > x.Top)
            //        {
            //            right = false;
            //        }
            //        if (player.Bounds.IntersectsWith(x.Bounds) && left == true && fall == true && player.Bottom - 2 > x.Top)
            //        {
            //            left = false;
            //        }
            //        if (player.Bounds.IntersectsWith(x.Bounds))
            //        {
            //            fall = false;
            //        }
            //    }
            //}
            //
            //if (right == true)
            //{
            //    player.Left += MOVE;
            //}
            //else if (left == true)
            //{
            //    player.Left -= MOVE;
            //}
            //
            ////induces fall and stops if reached bottom
            //if (fall == true)
            //{
            //    if (player.Bottom > this.Height - 40)
            //    {
            //        fall = false;
            //    }
            //    else
            //    {
            //        player.Top += gravity;  
            //    }
            //}
        //}
    
    }

    
}   
