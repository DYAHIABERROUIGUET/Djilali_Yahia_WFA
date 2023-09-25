﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Djilali_YahiaB_WFA
{
    public partial class Form1 : Form
    {
        bool startBegin = false, jump = false, gokuDroite = false, gokuGauche = false;

        int temps = 0, saut = 10, kintoUNRestart = 0, nombreDragonBall = 0;
        bool gravité = false, startGame = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (startBegin == true) //conditions pour lancer le jeux (prise d'info avant )
            {
                startGame = true;
                debutJeux(sender, e);
            }
            else
            {
                consignes(sender, e);
            }
        }

        private void horloge_Tick(object sender, EventArgs e)
        {
            score.Text = "Score : " + nombreDragonBall;
            temps++;
            if (goku.Bounds.IntersectsWith(dragonBall1.Bounds))
            {
                dragonBall1.Visible = false;
                nombreDragonBall += 1;
                dragonBall1.Left = 5000;
            }
            if (goku.Bounds.IntersectsWith(dragonBall2.Bounds))
            {
                dragonBall2.Visible = false;
                nombreDragonBall += 1;
                dragonBall2.Left = 5000;
            }
            if (goku.Bounds.IntersectsWith(dragonBall3.Bounds))
            {
                dragonBall3.Visible = false;
                nombreDragonBall += 1;
                dragonBall3.Left = 5000;
            }
            if (goku.Bounds.IntersectsWith(kintoUn.Bounds) && goku.Bottom - 1 == kintoUn.Top)
            {
                gravité = false;
                goku.Top -= 5;
                kintoUn.Top -= 5;
                kintoUNRestart += 5;
            }else if (kintoUNRestart > 0 )
            {
                kintoUn.Top += 5;
                kintoUNRestart -= 5 ;
            }
            if (gokuDroite == true)
            {
                goku.Left = goku.Left + 10;
            }else if (gokuGauche == true)
            {
                goku.Left = goku.Left - 10;
            }
            if (jump == true && saut == 0)
            {
                jump = false;
                saut = 10;
            } else if (jump == true && saut > 0)
            {
                saut -= 1;
                goku.Top -= 10;
            }
            if (gravité == true && startGame == true)
            {
                goku.Top += 1;
            }
            if (goku.Bounds.IntersectsWith(sol.Bounds) && goku.Bottom - 1 == sol.Top)
            {
                gravité = false;

            }
            else if (goku.Bounds.IntersectsWith(pictureBox1.Bounds) && goku.Bottom - 1 == pictureBox1.Top) {
                gravité = false;
            }
            else if (goku.Bounds.IntersectsWith(pictureBox2.Bounds) && goku.Bottom - 1 == pictureBox2.Top)
            {
                gravité = false;
            }
            else if (goku.Bounds.IntersectsWith(pictureBox3.Bounds) && goku.Bottom - 1 == pictureBox3.Top)
            {
                gravité = false;
            }
            else if (goku.Bounds.IntersectsWith(pictureBox4.Bounds) && goku.Bottom - 1 == pictureBox4.Top)
            {
                gravité = false;
            }
            else if (goku.Bounds.IntersectsWith(pictureBox5.Bounds) && goku.Bottom - 1 == pictureBox5.Top)
            {
                gravité = false;
            } else { 
            gravité = true;
            }

        }
        private void consignes(object sender, EventArgs e) //prise d'informations du jeux 
        {
            startBegin = true;
            pictureBoxConsignes.Visible = true;
            options.Visible = false;
            this.DoubleBuffered = true;
        }
        private void debutJeux(object sender, EventArgs e) //lancement du jeux 
        {
            start.Visible = false;
            pictureBoxConsignes.Visible = false;
            goku.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;    
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            sol.Visible = true;
            kintoUn.Visible = true;
            dragonBall1.Visible = true;
            score.Visible = true;
            dragonBall2.Visible = true;
            dragonBall3.Visible = true;
        }

        private void options_Click(object sender, EventArgs e) //quand on rentre dans le menu option
        {

        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                goku.Load("C:\\Users\\djila\\OneDrive\\Bureau\\ProjectPurple\\Djilali_YahiaB_WFA\\gokuBase.png");
                gokuDroite = false;
            }
            else if (e.KeyCode == Keys.Q)
            {
                gokuGauche = false;
                goku.Load("C:\\Users\\djila\\OneDrive\\Bureau\\ProjectPurple\\Djilali_YahiaB_WFA\\gokuBaseGauche.png");
            }
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            this.DoubleBuffered = true; //pour la superposition d'image dans le form  && gravité == false
            if (e.KeyCode == Keys.D )
            {
                goku.Load("C:\\Users\\djila\\OneDrive\\Bureau\\ProjectPurple\\Djilali_YahiaB_WFA\\gokuDroite.png");
                gokuDroite = true;

            }else if (e.KeyCode == Keys.Q)
            {
                gokuGauche = true;
                goku.Load("C:\\Users\\djila\\OneDrive\\Bureau\\ProjectPurple\\Djilali_YahiaB_WFA\\gokuGauche.png");

            }else if (e.KeyCode == Keys.Space && gravité == false)
            {
                    jump = true;
  
            }
        }
    }
}
