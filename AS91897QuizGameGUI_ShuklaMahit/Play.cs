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
    /// <summary>
    /// Author: Mahit Shukla
    /// Last Edited: 03/07/2024
    /// </summary>

    public partial class Play : Form
    {
        //declare costants
        const int MOVE = 5;
        const int MARIOX = 536;
        const int MARIOY = 206;
        const int QUESTION_NUMS = 11;
        const int MULTICHOICE_NUMS = 7;
        const int SCREEN_ILLUSION = 40;
        // declare multidimensional array for quesiton bank
        string[,] questionBank = new string[QUESTION_NUMS, MULTICHOICE_NUMS];
        //declare lists
        List<string> correctAnswers = new List<string>();
        List<string> incorrectAnswers = new List<string>();
        List<int> usedQuestions = new List<int>();
        //declare array
        string[] line = new string[7];
        //declare variables
        string currentLine;
        int gravity = 4;
        int jumpUp = 20;
        int lineNum = 0;
        int lives = 3;
        int currentQuestion; 
        bool left;
        bool right;
        bool fall;
        bool jump;
        bool showMessage;
        bool correct;
        bool constantJump = true;
        //random number generator
        Random sequence = new Random();


        public Play()
        {
            InitializeComponent();
            //start player fall as soon as program starts
            fall = true;
            //"K:/2024_SR_12IT1/Programming/AS91897QuizGameGUI_ShuklaMahit/QuizQuestions final.csv"
            //"C:/Users/ANJANA/Documents/Visual Studio 2022/12IT AS91897QuizGameGUI/QuizQuestions final.csv"
            //Takes in the questionbank file and stores it in the questionBank multidimensional array as questions and options
            using (StreamReader things = File.OpenText("QuizQuestions final.csv"))
            {
                while ((currentLine = things.ReadLine()) != null)
                {
                    //split different parts of the row by comma and save it as parts of an array, reset the array in each row of file
                    line = currentLine.Split(',');
                    //save the different parts of the file in appropriate rows and columns of questionBank multidimensional array, to be accesed later
                    for (int j = 0; j < line.Length; j++)
                    {
                        questionBank[lineNum, j] = line[j]; 
                    }
                    //Set the number of row used for each new row started
                    lineNum++;
                }
            }
            //show the question as soon as data saved.
            ShowQuestions();
            //display intial Life count
            textBoxLives.Text = lives.ToString();
        }


        private void Play_KeyDown_1(object sender, KeyEventArgs e)
        {
            //test if left arrow key pressed then stop initial constant jump for attraction, and move player left
            if (e.KeyCode == Keys.Left)
            {
                constantJump = false;
                left = true;
            }
            //test if right arrow key pressed then stop initial constant jump for attraction, and move player left
            else if (e.KeyCode == Keys.Right)
            {
                constantJump = false;
                right = true;
            }
            //if not already jumping and is not falling and spacebar pressed then and only allow to jump and stop initial constant jump
            if (jump != true && fall != true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    constantJump = false;
                    jump = true;
                }
            }
            //if escape key pressed then close program
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
                //this.Close();
            }
        }

        private void Play_KeyUp_1(object sender, KeyEventArgs e)
        {
            //if no more pressing left arrow key then stop moving left
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            //if no more pressing left arrow key then stop moving left
            else if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
        }


        private void timerTick_Tick(object sender, EventArgs e)
        {
            //if intial constant jump is on then keep jumping as soon as landed on a platform
            if (constantJump == true && fall == false)
            {
                jump = true;
            }
            
            if (jump == true)
            {
                if (jumpUp > 0)
                {
                    //if jump boolean is true and jumping value is greater than 0 then take player picturebox up by jump up value
                    player.Top -= jumpUp;
                    //decrease jumping value by 1 every second to smoothen out jump as max jump distance reached
                    jumpUp--;
                }
                else
                {
                    //if max jump height reached and jumping value is 0 or less then reset jump value and stop jump
                    jump = false;
                    jumpUp = 20;
                }
            }

            //if player anywhere in air then fall boolean turned on
            if (player.Bottom < this.Height)
            {
                fall = true;

            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "object")
                {
                    //if player touches from the left side of any jumping blocks then sticks to the block and can't go further right into the block
                    if (player.Bounds.IntersectsWith(x.Bounds) && right == true && fall == true && player.Bottom - gravity > x.Top)
                    {
                        right = false;
                    }
                    //if player touches from the right side of any jumping blocks then sticks to the block and can't go further left into the block
                    if (player.Bounds.IntersectsWith(x.Bounds) && left == true && fall == true && player.Bottom - gravity > x.Top)
                    {
                        left = false;
                    }
                    //if player lands on top or touches from any side of the jumping block then stops falling
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        fall = false;
                    }
                }
            }
            //if not already displaying message, check answer and show right or wrong message
            if (showMessage == false)
            {
                CheckAnswer();

            }

            //player collision with left and right walls of the screen
            if (player.Right > this.Width && right == true)
            {
                right = false;

            }
            else if (player.Left < 0 && left == true)
            {
                left = false;
            }

            //make player move left and right
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
                if (player.Bottom > this.Height - SCREEN_ILLUSION)
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
                    player.Location = new Point(MARIOX, MARIOY);
                    right = false;
                    left = false;
                    correct = true;
                    DisplayAnswer();


                }
                else
                {
                    player.Location = new Point(MARIOX, MARIOY);
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
                    player.Location = new Point(MARIOX, MARIOY);
                    right = false;
                    left = false;
                    correct = true;
                    DisplayAnswer();


                }
                else
                {
                    player.Location = new Point(MARIOX, MARIOY);
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
                    player.Location = new Point(MARIOX, MARIOY);
                    right = false;
                    left = false;
                    correct = true;
                    DisplayAnswer();

                }
                else
                {
                    player.Location = new Point(MARIOX, MARIOY);
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
                    player.Location = new Point(MARIOX, MARIOY);
                    right = false;
                    left = false;
                    correct = true;
                    DisplayAnswer();


                }
                else
                {
                    player.Location = new Point(MARIOX, MARIOY);
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
                    
                    currentQuestion = sequence.Next(1, QUESTION_NUMS - 1);
                    while (usedQuestions.Contains(currentQuestion))
                    {
                        currentQuestion = sequence.Next(1, QUESTION_NUMS - 1);
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
