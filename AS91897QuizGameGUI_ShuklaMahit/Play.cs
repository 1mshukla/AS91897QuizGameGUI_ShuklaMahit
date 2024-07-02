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
        // declare multidimensional array
        string[,] questionBank = new string[11, 7];
        //declare lists
        List<string> correctAnswers = new List<string>();
        List<string> incorrectAnswers = new List<string>();
        List<int> usedQuestions = new List<int>();
        //declare costants
        const int MOVE = 5;
        //declare variables
        int gravity = 4;
        int jumpUp = 20;
        int lineNum = 0;
        int lives = 3;
        Random sequence = new Random();
        int currentQuestion; 
        bool left;
        bool right;
        bool fall;
        bool jump;
        bool showMessage;
        bool correct;
        bool constantJump = true;

        public Play()
        {
            InitializeComponent();

            fall = true;
            //"K:/2024_SR_12IT1/Programming/AS91897QuizGameGUI_ShuklaMahit/QuizQuestions final.csv"
            //"C:/Users/ANJANA/Documents/Visual Studio 2022/12IT AS91897QuizGameGUI/QuizQuestions final.csv"
            using (StreamReader things = File.OpenText("C:/Users/ANJANA/Documents/Visual Studio 2022/12IT AS91897QuizGameGUI/QuizQuestions final.csv"))
            {
                string currentLine;
                while ((currentLine = things.ReadLine()) != null)
                {
                    //if (i+1 <= questionBank.GetLength(2))
                    //{
                    string[] line = new string[7];
                    line = currentLine.Split(',');

                    for (int j = 0; j < line.Length; j++)
                    {
                        //MessageBox.Show($"{line[j]}");
                        //string quest = ;
                        questionBank[lineNum, j] = line[j]; //things.ReadLine().Split(',');
                                                            //MessageBox.Show(j.ToString());
                                                            //MessageBox.Show($"{questionBank[i - 1, j]}");

                    }
                    lineNum++;
                    //}
                    //else
                    //{   
                    //    MessageBox.Show($"break");
                    //    break;

                    //}

                }

            }
            
            ShowQuestions();
            textBoxLives.Text = lives.ToString();
            
        }


        private void Play_KeyDown_1(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                constantJump = false;
                left = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                constantJump = false;
                right = true;
            }
            if (jump != true && fall != true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    constantJump = false;
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
            if (constantJump == true && fall == false)
            {
                jump = true;
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
                    if (player.Bounds.IntersectsWith(x.Bounds) && right == true && fall == true && player.Bottom - gravity > x.Top)
                    {
                        right = false;
                    }
                    if (player.Bounds.IntersectsWith(x.Bounds) && left == true && fall == true && player.Bottom - gravity > x.Top)
                    {
                        left = false;
                    }
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        fall = false;
                    }
                    if (showMessage == false)
                    {
                        CheckAnswer();

                    }
                }
            }

            

            if (player.Right > this.Width && right == true)
            {
                right = false;

            }
            else if (player.Left < 0 && left == true)
            {
                left = false;
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
            

        }

        private void CheckAnswer()
        {
            if (player.Bounds.IntersectsWith(answerA.Bounds))
            {
                if (questionBank[currentQuestion, 5] == "A")
                {
                    player.Location = new Point(715, 253);
                    right = false;
                    left = false;
                    correct = true;
                    DisplayAnswer();


                }
                else
                {
                    player.Location = new Point(715, 253);
                    right = false;
                    left = false;
                    correct = false;
                    DisplayAnswer();


                }
            }
            if (player.Bounds.IntersectsWith(answerB.Bounds))
            {
                if (questionBank[currentQuestion, 5] == "B")
                {
                    player.Location = new Point(715, 253);
                    right = false;
                    left = false;
                    correct = true;
                    DisplayAnswer();


                }
                else
                {
                    player.Location = new Point(715, 253);
                    right = false;
                    left = false;
                    correct = false;
                    DisplayAnswer();


                }
            }
            if (player.Bounds.IntersectsWith(answerC.Bounds))
            {
                if (questionBank[currentQuestion, 5] == "C")
                {
                    player.Location = new Point(715, 253);
                    right = false;
                    left = false;
                    correct = true;
                    DisplayAnswer();

                }
                else
                {
                    player.Location = new Point(715, 253);
                    right = false;
                    left = false;
                    correct = false;
                    DisplayAnswer();


                }
            }
            if (player.Bounds.IntersectsWith(answerD.Bounds))
            {
                if (questionBank[currentQuestion, 5] == "D")
                {
                    player.Location = new Point(715, 253);
                    right = false;
                    left = false;
                    correct = true;
                    DisplayAnswer();


                }
                else
                {
                    player.Location = new Point(715, 253);
                    right = false;
                    left = false;
                    correct = false;
                    DisplayAnswer();


                }
            }
        }
        private void DisplayAnswer()
        {
            if (correct == true)
            {
                MessageBox.Show($"CORRECT. THE ANSWER IS: {questionBank[currentQuestion, 6]}");
                
                
                showMessage = false;
                correctAnswers.Add(questionBank[currentQuestion,0]);
                ShowQuestions();

            }
            else
            {
                MessageBox.Show($"INCORRECT. THE ANSWER IS: {questionBank[currentQuestion, 6]}");
                
                lives--;
                textBoxLives.Text = lives.ToString();
                showMessage = false;
                incorrectAnswers.Add(questionBank[currentQuestion, 0]);
                ShowQuestions();
            }
        }

        private void ShowQuestions()
        {
            
            if (lives > 0)
            {
                if (usedQuestions.Count <=4)
                {
                    
                    currentQuestion = sequence.Next(1, 10);
                    while (usedQuestions.Contains(currentQuestion))
                    {
                        currentQuestion = sequence.Next(1, 10);
                    }
                    usedQuestions.Add(currentQuestion);
                    listBox1.Items.Clear();
                    listBox1.Items.Add($"Question: {questionBank[currentQuestion, 0]}");
                    listBox1.Items.Add($"Option A is {questionBank[currentQuestion, 1]}");
                    listBox1.Items.Add($"Option B is {questionBank[currentQuestion, 2]}");
                    listBox1.Items.Add($"Option C is {questionBank[currentQuestion, 3]}");
                    listBox1.Items.Add($"Option D is {questionBank[currentQuestion, 4]}");
                }
                else
                {
                    MessageBox.Show("THANK YOU FOR PLAYING, QUIZ SCORES RECORDED IN NOTEPAD IN FOLDER!");
                    using (StreamWriter summary = new StreamWriter("Answer Summary.txt"))
                    {
                        summary.WriteLine("You answered correctly:");
                        foreach (string answer in correctAnswers)
                        {
                            summary.WriteLine(answer);
                        }
                        summary.WriteLine("You answered incorrectly:");
                        foreach (string wrong in incorrectAnswers)
                        {
                            summary.WriteLine(wrong);
                        }
                    
                    }
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Sorry, out of lives. GAME OVER!");
                using (StreamWriter summary = new StreamWriter("Answer Summary.txt"))
                {
                    summary.WriteLine("You answered correctly:");
                    foreach (string answer in correctAnswers)
                    {
                        summary.WriteLine(answer);
                    }
                    summary.WriteLine("You answered incorrectly:");
                    foreach (string wrong in incorrectAnswers)
                    {
                        summary.WriteLine(wrong);
                    }
                    
                }
                Application.Exit();

            }

            
        }

        
    }
}
