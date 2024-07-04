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
            //Takes in the questionbank file and stores it in the questionBank multidimensional array as questions and options
            using (StreamReader things = File.OpenText("../../../../AS91897QuizGameGUI_ShuklaMahit/QuizQuestions final.csv"))
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
            //if not already jumping and is not falling and spacebar pressed then and only allow to jump
            if (jump != true && fall != true)
            {
                if (e.KeyCode == Keys.Space)
                {
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

            //makes player fall from air and stops if reached bottom
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

        /// <summary>
        /// Checks if the answer from player is true or false
        /// Resets player position and displays the correct answer and next question
        /// </summary>
        private void CheckAnswer()
        {
            if (player.Bounds.IntersectsWith(answerA.Bounds)) //checks if touching answer block A
            {
                if (questionBank[currentQuestion, 5] == "A") //if correct answer is also A then they are correct
                {
                    player.Location = new Point(MARIOX, MARIOY);
                    right = false;
                    left = false;
                    correct = true;
                    DisplayAnswer();


                }
                else
                {
                    player.Location = new Point(MARIOX, MARIOY); //if correct answer is not A then they are incorrect
                    right = false;
                    left = false;
                    correct = false;
                    DisplayAnswer();


                }
            }
            if (player.Bounds.IntersectsWith(answerB.Bounds)) //checks if touching answer block B
            {
                if (questionBank[currentQuestion, 5] == "B") //if correct answer is also B then they are correct
                {
                    player.Location = new Point(MARIOX, MARIOY);
                    right = false;
                    left = false;
                    correct = true;
                    DisplayAnswer();


                }
                else
                {
                    player.Location = new Point(MARIOX, MARIOY); //if correct answer is not B then they are incorrect
                    right = false;
                    left = false;
                    correct = false;
                    DisplayAnswer();


                }
            }
            if (player.Bounds.IntersectsWith(answerC.Bounds)) //checks if touching answer block C
            {
                if (questionBank[currentQuestion, 5] == "C") //if correct answer is also C then they are correct
                {
                    player.Location = new Point(MARIOX, MARIOY); 
                    right = false;
                    left = false;
                    correct = true;
                    DisplayAnswer();

                }
                else
                {
                    player.Location = new Point(MARIOX, MARIOY); //if correct answer is not C then they are incorrect
                    right = false;
                    left = false;
                    correct = false;
                    DisplayAnswer();


                }
            }
            if (player.Bounds.IntersectsWith(answerD.Bounds)) //checks if touching answer block D
            {
                if (questionBank[currentQuestion, 5] == "D")
                {
                    player.Location = new Point(MARIOX, MARIOY); //if correct answer is also D then they are correct
                    right = false;
                    left = false;
                    correct = true;
                    DisplayAnswer();


                }
                else
                {
                    player.Location = new Point(MARIOX, MARIOY); //if correct answer is not D then they are incorrect
                    right = false;
                    left = false;
                    correct = false;
                    DisplayAnswer();


                }
            }
        }

        /// <summary>
        /// Displays if the answer is correct or not and what the actual correct answer is
        /// Goes to ShowQuestions to display the next question
        /// Prevents from displaying the messagebox again and again as timer ticks
        /// Deducts a life if answer is wrong
        /// </summary>
        private void DisplayAnswer()
        {
            if (correct == true) //if answered correctly then says it is correct adds the record to list of correct answers
            {
                MessageBox.Show($"CORRECT. THE ANSWER IS: {questionBank[currentQuestion, 6]}");
                
                
                showMessage = false;
                correctAnswers.Add(questionBank[currentQuestion,0]);
                ShowQuestions();

            }
            else //answered incorrectly then says incorrect and what the actual answer is adds the record to list of incorrect answer
            {
                MessageBox.Show($"INCORRECT. THE ANSWER IS: {questionBank[currentQuestion, 6]}");
                
                lives--; //takes away a life if answer is wrong
                textBoxLives.Text = lives.ToString();
                showMessage = false;
                incorrectAnswers.Add(questionBank[currentQuestion, 0]);
                ShowQuestions();
            }
        }

        private void ShowQuestions()
        {
            
            if (lives > 0) //if still has lives then displays next random question
            {
                if (usedQuestions.Count <=4) //if not already displayed 5 questions and game not over then displays the next random question
                {
                    //picks random number not already chosen before and picks that number of question to display
                    currentQuestion = sequence.Next(1, QUESTION_NUMS - 1);
                    while (usedQuestions.Contains(currentQuestion))
                    {
                        currentQuestion = sequence.Next(1, QUESTION_NUMS - 1);
                    }
                    //adds the current question to list of used questions to prevent it from being picked again
                    usedQuestions.Add(currentQuestion);
                    listBox1.Items.Clear(); // clear last question
                    //display question
                    listBox1.Items.Add($"Question: {questionBank[currentQuestion, 0]}");
                    //display the 4 options for multichoice
                    listBox1.Items.Add($"Option A is {questionBank[currentQuestion, 1]}");
                    listBox1.Items.Add($"Option B is {questionBank[currentQuestion, 2]}");
                    listBox1.Items.Add($"Option C is {questionBank[currentQuestion, 3]}");
                    listBox1.Items.Add($"Option D is {questionBank[currentQuestion, 4]}");
                }
                else //otherwise if game is over then display message box showing it is over and the scores are recorded
                {
                    
                    using (StreamWriter summary = new StreamWriter("Answer Summary.txt")) //output summary to a text file
                    {
                        summary.WriteLine("You answered correctly:");
                        foreach (string answer in correctAnswers) //in the file display all the correct answers
                        {
                            summary.WriteLine(answer);
                        }
                        summary.WriteLine("You answered incorrectly:");
                        foreach (string wrong in incorrectAnswers) //in the file display all the incorrect answers
                        {
                            summary.WriteLine(wrong);
                        }
                    
                    }
                    MessageBox.Show("THANK YOU FOR PLAYING, QUIZ SCORES RECORDED IN NOTEPAD IN DEBUG FOLDER!");
                    Application.Exit(); //close program
                }
            }
            else //otherwise if all lives lost then display message box showing it is over and the scores are recorded
            {
                
                using (StreamWriter summary = new StreamWriter("Answer Summary.txt")) //output summary to a text file
                {
                    summary.WriteLine("You answered correctly:");
                    foreach (string answer in correctAnswers) //in the file display all the correct answers
                    {
                        summary.WriteLine(answer);
                    }
                    summary.WriteLine("You answered incorrectly:");
                    foreach (string wrong in incorrectAnswers) //in the file display all the incorrect answers
                    {
                        summary.WriteLine(wrong);
                    }
                    
                }
                MessageBox.Show("Sorry, out of lives. GAME OVER! Quiz Scores recorded in notepad in debug folder.");
                Application.Exit(); //close program

            }

            
        }

        
    }
}
