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
            this.block3 = new System.Windows.Forms.PictureBox();
            this.block1 = new System.Windows.Forms.PictureBox();
            this.block2 = new System.Windows.Forms.PictureBox();
            this.answerC = new System.Windows.Forms.PictureBox();
            this.answerD = new System.Windows.Forms.PictureBox();
            this.answerA = new System.Windows.Forms.PictureBox();
            this.answerB = new System.Windows.Forms.PictureBox();
            this.block4 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timerTick = new System.Windows.Forms.Timer(this.components);
            this.labelLives = new System.Windows.Forms.Label();
            this.textBoxLives = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.block3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(297, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(331, 134);
            this.listBox1.TabIndex = 22;
            // 
            // block3
            // 
            this.block3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.block3.Location = new System.Drawing.Point(252, 356);
            this.block3.Name = "block3";
            this.block3.Size = new System.Drawing.Size(100, 50);
            this.block3.TabIndex = 20;
            this.block3.TabStop = false;
            this.block3.Tag = "object";
            // 
            // block1
            // 
            this.block1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.block1.Location = new System.Drawing.Point(184, 221);
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(100, 50);
            this.block1.TabIndex = 19;
            this.block1.TabStop = false;
            this.block1.Tag = "object";
            // 
            // block2
            // 
            this.block2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.block2.Location = new System.Drawing.Point(657, 221);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(100, 50);
            this.block2.TabIndex = 18;
            this.block2.TabStop = false;
            this.block2.Tag = "object";
            // 
            // answerC
            // 
            this.answerC.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.answerC.Location = new System.Drawing.Point(8, 463);
            this.answerC.Name = "answerC";
            this.answerC.Size = new System.Drawing.Size(100, 50);
            this.answerC.TabIndex = 17;
            this.answerC.TabStop = false;
            this.answerC.Tag = "object";
            // 
            // answerD
            // 
            this.answerD.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.answerD.Location = new System.Drawing.Point(815, 463);
            this.answerD.Name = "answerD";
            this.answerD.Size = new System.Drawing.Size(100, 50);
            this.answerD.TabIndex = 16;
            this.answerD.TabStop = false;
            this.answerD.Tag = "object";
            // 
            // answerA
            // 
            this.answerA.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.answerA.Location = new System.Drawing.Point(8, 148);
            this.answerA.Name = "answerA";
            this.answerA.Size = new System.Drawing.Size(100, 50);
            this.answerA.TabIndex = 15;
            this.answerA.TabStop = false;
            this.answerA.Tag = "object";
            // 
            // answerB
            // 
            this.answerB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.answerB.Location = new System.Drawing.Point(815, 148);
            this.answerB.Name = "answerB";
            this.answerB.Size = new System.Drawing.Size(100, 50);
            this.answerB.TabIndex = 14;
            this.answerB.TabStop = false;
            this.answerB.Tag = "object";
            // 
            // block4
            // 
            this.block4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.block4.Location = new System.Drawing.Point(567, 356);
            this.block4.Name = "block4";
            this.block4.Size = new System.Drawing.Size(100, 50);
            this.block4.TabIndex = 13;
            this.block4.TabStop = false;
            this.block4.Tag = "object";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.player.Location = new System.Drawing.Point(408, 231);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 50);
            this.player.TabIndex = 12;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.player_Click);
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
            this.labelLives.Location = new System.Drawing.Point(8, 13);
            this.labelLives.Name = "labelLives";
            this.labelLives.Size = new System.Drawing.Size(56, 13);
            this.labelLives.TabIndex = 23;
            this.labelLives.Text = "Lives Left:";
            // 
            // textBoxLives
            // 
            this.textBoxLives.Location = new System.Drawing.Point(70, 10);
            this.textBoxLives.Name = "textBoxLives";
            this.textBoxLives.ReadOnly = true;
            this.textBoxLives.Size = new System.Drawing.Size(24, 20);
            this.textBoxLives.TabIndex = 24;
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 561);
            this.Controls.Add(this.textBoxLives);
            this.Controls.Add(this.labelLives);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.block3);
            this.Controls.Add(this.block1);
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
            ((System.ComponentModel.ISupportInitialize)(this.block3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox block3;
        private System.Windows.Forms.PictureBox block1;
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
    }
}