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
        public Form1()
        {
            InitializeComponent();

        }
        public void button1_Click_1(object sender, EventArgs e)
        {
            Play window = new Play();
            this.Hide();
            window.ShowDialog();
            this.Close();

        }
    }

    
}   
