﻿namespace AS91897QuizGameGUI_ShuklaMahit
{
    partial class Form1
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
            this.player = new System.Windows.Forms.PictureBox();
            this.block4 = new System.Windows.Forms.PictureBox();
            this.answerB = new System.Windows.Forms.PictureBox();
            this.answerA = new System.Windows.Forms.PictureBox();
            this.answerD = new System.Windows.Forms.PictureBox();
            this.answerC = new System.Windows.Forms.PictureBox();
            this.block2 = new System.Windows.Forms.PictureBox();
            this.block1 = new System.Windows.Forms.PictureBox();
            this.block3 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block3)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.player.Location = new System.Drawing.Point(1073, 58);
            this.player.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(133, 62);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // block4
            // 
            this.block4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.block4.Location = new System.Drawing.Point(761, 482);
            this.block4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.block4.Name = "block4";
            this.block4.Size = new System.Drawing.Size(133, 62);
            this.block4.TabIndex = 1;
            this.block4.TabStop = false;
            this.block4.Tag = "object";
            // 
            // answerB
            // 
            this.answerB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.answerB.Location = new System.Drawing.Point(1092, 226);
            this.answerB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.answerB.Name = "answerB";
            this.answerB.Size = new System.Drawing.Size(133, 62);
            this.answerB.TabIndex = 2;
            this.answerB.TabStop = false;
            this.answerB.Tag = "object";
            // 
            // answerA
            // 
            this.answerA.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.answerA.Location = new System.Drawing.Point(16, 226);
            this.answerA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.answerA.Name = "answerA";
            this.answerA.Size = new System.Drawing.Size(133, 62);
            this.answerA.TabIndex = 3;
            this.answerA.TabStop = false;
            this.answerA.Tag = "object";
            // 
            // answerD
            // 
            this.answerD.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.answerD.Location = new System.Drawing.Point(1092, 614);
            this.answerD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.answerD.Name = "answerD";
            this.answerD.Size = new System.Drawing.Size(133, 62);
            this.answerD.TabIndex = 4;
            this.answerD.TabStop = false;
            this.answerD.Tag = "object";
            // 
            // answerC
            // 
            this.answerC.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.answerC.Location = new System.Drawing.Point(16, 614);
            this.answerC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.answerC.Name = "answerC";
            this.answerC.Size = new System.Drawing.Size(133, 62);
            this.answerC.TabIndex = 5;
            this.answerC.TabStop = false;
            this.answerC.Tag = "object";
            // 
            // block2
            // 
            this.block2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.block2.Location = new System.Drawing.Point(881, 316);
            this.block2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(133, 62);
            this.block2.TabIndex = 6;
            this.block2.TabStop = false;
            this.block2.Tag = "object";
            // 
            // block1
            // 
            this.block1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.block1.Location = new System.Drawing.Point(251, 316);
            this.block1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(133, 62);
            this.block1.TabIndex = 7;
            this.block1.TabStop = false;
            this.block1.Tag = "object";
            // 
            // block3
            // 
            this.block3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.block3.Location = new System.Drawing.Point(341, 482);
            this.block3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.block3.Name = "block3";
            this.block3.Size = new System.Drawing.Size(133, 62);
            this.block3.TabIndex = 8;
            this.block3.TabStop = false;
            this.block3.Tag = "object";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 690);
            this.Controls.Add(this.block3);
            this.Controls.Add(this.block1);
            this.Controls.Add(this.block2);
            this.Controls.Add(this.answerC);
            this.Controls.Add(this.answerD);
            this.Controls.Add(this.answerA);
            this.Controls.Add(this.answerB);
            this.Controls.Add(this.block4);
            this.Controls.Add(this.player);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox block4;
        private System.Windows.Forms.PictureBox answerB;
        private System.Windows.Forms.PictureBox answerA;
        private System.Windows.Forms.PictureBox answerD;
        private System.Windows.Forms.PictureBox answerC;
        private System.Windows.Forms.PictureBox block2;
        private System.Windows.Forms.PictureBox block1;
        private System.Windows.Forms.PictureBox block3;
        private System.Windows.Forms.Timer timer;
    }
}

