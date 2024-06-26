namespace AS91897QuizGameGUI_ShuklaMahit
{
    partial class Play
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timerTick = new System.Windows.Forms.Timer(this.components);
            this.labelLives = new System.Windows.Forms.Label();
            this.textBoxLives = new System.Windows.Forms.TextBox();
            this.block2 = new System.Windows.Forms.PictureBox();
            this.answerC = new System.Windows.Forms.PictureBox();
            this.answerD = new System.Windows.Forms.PictureBox();
            this.answerA = new System.Windows.Forms.PictureBox();
            this.answerB = new System.Windows.Forms.PictureBox();
            this.block4 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(362, 10);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(346, 147);
            this.listBox1.TabIndex = 22;
            // 
            // timerTick
            // 
            this.timerTick.Enabled = true;
            this.timerTick.Interval = 1;
            this.timerTick.Tick += new System.EventHandler(this.timerTick_Tick);
            // 
            // labelLives
            // 
            this.labelLives.AutoSize = true;
            this.labelLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLives.Location = new System.Drawing.Point(12, 20);
            this.labelLives.Name = "labelLives";
            this.labelLives.Size = new System.Drawing.Size(81, 20);
            this.labelLives.TabIndex = 23;
            this.labelLives.Text = "Lives Left:";
            // 
            // textBoxLives
            // 
            this.textBoxLives.Location = new System.Drawing.Point(99, 20);
            this.textBoxLives.Name = "textBoxLives";
            this.textBoxLives.ReadOnly = true;
            this.textBoxLives.Size = new System.Drawing.Size(24, 20);
            this.textBoxLives.TabIndex = 24;
            // 
            // block2
            // 
            this.block2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.block2.Location = new System.Drawing.Point(793, 263);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(27, 50);
            this.block2.TabIndex = 18;
            this.block2.TabStop = false;
            this.block2.Tag = "object";
            // 
            // answerC
            // 
            this.answerC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.answerC.Image = global::AS91897QuizGameGUI_ShuklaMahit.Properties.Resources.large_Letter_c;
            this.answerC.Location = new System.Drawing.Point(11, 593);
            this.answerC.Name = "answerC";
            this.answerC.Size = new System.Drawing.Size(100, 74);
            this.answerC.TabIndex = 17;
            this.answerC.TabStop = false;
            this.answerC.Tag = "object";
            // 
            // answerD
            // 
            this.answerD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.answerD.Image = global::AS91897QuizGameGUI_ShuklaMahit.Properties.Resources.Letter_D;
            this.answerD.Location = new System.Drawing.Point(933, 593);
            this.answerD.Name = "answerD";
            this.answerD.Size = new System.Drawing.Size(100, 74);
            this.answerD.TabIndex = 16;
            this.answerD.TabStop = false;
            this.answerD.Tag = "object";
            // 
            // answerA
            // 
            this.answerA.BackColor = System.Drawing.Color.WhiteSmoke;
            this.answerA.BackgroundImage = global::AS91897QuizGameGUI_ShuklaMahit.Properties.Resources.Letter_A1;
            this.answerA.ErrorImage = null;
            this.answerA.ImageLocation = "centre";
            this.answerA.Location = new System.Drawing.Point(12, 124);
            this.answerA.Name = "answerA";
            this.answerA.Size = new System.Drawing.Size(100, 74);
            this.answerA.TabIndex = 15;
            this.answerA.TabStop = false;
            this.answerA.Tag = "object";
            // 
            // answerB
            // 
            this.answerB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.answerB.Image = global::AS91897QuizGameGUI_ShuklaMahit.Properties.Resources.letter_B_trial;
            this.answerB.Location = new System.Drawing.Point(940, 124);
            this.answerB.Name = "answerB";
            this.answerB.Size = new System.Drawing.Size(93, 74);
            this.answerB.TabIndex = 14;
            this.answerB.TabStop = false;
            this.answerB.Tag = "object";
            // 
            // block4
            // 
            this.block4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.block4.Location = new System.Drawing.Point(685, 360);
            this.block4.Name = "block4";
            this.block4.Size = new System.Drawing.Size(75, 55);
            this.block4.TabIndex = 13;
            this.block4.TabStop = false;
            this.block4.Tag = "object";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.player.Location = new System.Drawing.Point(483, 222);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 50);
            this.player.TabIndex = 12;
            this.player.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(408, 526);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 22);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "object";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox2.Location = new System.Drawing.Point(749, 593);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 38);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "object";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox3.Location = new System.Drawing.Point(229, 593);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 38);
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "object";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox4.Location = new System.Drawing.Point(874, 231);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 50);
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "object";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox5.Location = new System.Drawing.Point(133, 231);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 50);
            this.pictureBox5.TabIndex = 31;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "object";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox6.Location = new System.Drawing.Point(218, 263);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(27, 50);
            this.pictureBox6.TabIndex = 30;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "object";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox7.Location = new System.Drawing.Point(286, 360);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(75, 55);
            this.pictureBox7.TabIndex = 29;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "object";
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 693);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxLives);
            this.Controls.Add(this.labelLives);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.block2);
            this.Controls.Add(this.answerC);
            this.Controls.Add(this.answerD);
            this.Controls.Add(this.answerA);
            this.Controls.Add(this.answerB);
            this.Controls.Add(this.block4);
            this.Controls.Add(this.player);
            this.KeyPreview = true;
            this.Name = "Play";
            this.Text = "Play";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Play_KeyDown_1);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Play_KeyUp_1);
            ((System.ComponentModel.ISupportInitialize)(this.block2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox block2;
        private System.Windows.Forms.PictureBox answerC;
        private System.Windows.Forms.PictureBox answerD;
        private System.Windows.Forms.PictureBox answerA;
        private System.Windows.Forms.PictureBox answerB;
        private System.Windows.Forms.PictureBox block4;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timerTick;
        private System.Windows.Forms.Label labelLives;
        private System.Windows.Forms.TextBox textBoxLives;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}