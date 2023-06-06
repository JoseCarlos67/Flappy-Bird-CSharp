﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappy_bird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 6;
        int gravity = 15;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pipeTop_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score " + score;

            if (pipeBottom.Left < -50)
            {
                pipeBottom.Left = 800;
                score++;
            }
            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) || flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) || flappyBird.Bounds.IntersectsWith(ground.Bounds)
                || flappyBird.Top < -25)
            {
                endGame();
            }

            if (score > 5)
            {
                pipeSpeed = 15  ;

            }
            
            if (flappyBird.Top < -25)
            {
                endGame();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        private void scoreText_Click(object sender, EventArgs e)
        {

        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Fim de Jogo";
        }

        

    }
}
