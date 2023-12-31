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
    public partial class attaque1 : Form
    {
        bool startBegin = false, jump = false, gokuDroite = false, gokuGauche = false, gokuBas = false;

        int temps = 0, saut = 10, kintoUNRestart = 0, nombreDragonBall = 0, meha = 10, attDroite = 1, recul = 5,niveau = 0;
        bool gravité = false, startGame = false, kameha = false, ennemieActif = false, returnEnnemi = false, tryGameover = false;


        private void secondTimer_Tick(object sender, EventArgs e)
        {
            if (kameha == true && attDroite != 0)
            {
                if (attDroite == 1)
                {

                    attaque.Visible = true;
                    attaque.Left = goku.Left - 30;
                    attaque.Top = goku.Top;
                    attDroite = 3;
                    goku.Load("C:\\Users\\djila\\OneDrive\\Bureau\\ProjectPurple\\Djilali_YahiaB_WFA\\Resources\\goku (1).png");
                    attaque.Load("C:\\Users\\djila\\OneDrive\\Bureau\\ProjectPurple\\Djilali_YahiaB_WFA\\Resources\\Kamehameha.png");


                }
                else if (attDroite == 2)
                {
                    attaque.Load("C:\\Users\\djila\\OneDrive\\Bureau\\ProjectPurple\\Djilali_YahiaB_WFA\\Resources\\Kamehameha (1) (1).png");
                    goku.Load("C:\\Users\\djila\\OneDrive\\Bureau\\ProjectPurple\\Djilali_YahiaB_WFA\\Resources\\image (2).png");
                    attaque.Visible = true;
                    attaque.Left = goku.Left - 150;
                    attaque.Top = goku.Top;
                    attDroite = 4;
                }

            }

            if (attDroite == 3)
            {
                if (recul > 0)
                {
                    recul -= 1;
                    goku.Left -= 20;
                }
                attaque.Left += 5;
                if (attaque.Left > 1600 || attaque.Left < -600)
                {
                    attDroite = 1;
                    kameha = false;
                    attaque.Visible = false;
                    recul = 5;
                }
            }
            if (attDroite == 4)
            {
                if (recul > 0)
                {
                    recul -= 1;
                    goku.Left += 20;
                }
                attaque.Left -= 5;
                if (attaque.Left > 1600 || attaque.Left < -600)
                {
                    attDroite = 2;
                    kameha = false;
                    attaque.Visible = false;
                    recul = 5;
                }
            }
            if (ennemieActif == true && returnEnnemi == false)
            {
                if (ennemiBG.Right < pictureBox3.Right)
                {
                    ennemiBG.Left += 8;

                }else if (ennemiBG.Right >= pictureBox3.Right) {
                    returnEnnemi = true;
                }

            }else if (ennemieActif == true && returnEnnemi == true)
            {
                ennemiBG.Left -= 8;
                if (ennemiBG.Left < 0)
                {
                    returnEnnemi = false;
                }
            }
            if (ennemiBG.Bounds.IntersectsWith(attaque.Bounds) && ennemieActif == true)
            {
                dragonBall4.Left = ennemiBG.Left ;
                dragonBall4.Top = ennemiBG.Top ;
                dragonBall4.Visible = true;
                ennemieActif = false;
                ennemiBG.Left = -100;
                ennemiBG.Visible = false;
                
            }
            if (ennemiBG.Bounds.IntersectsWith(goku.Bounds) && ennemieActif == true)
            {
                gameover(sender, e);
            }
        }

        private void gameover(object sender, EventArgs e)
        {
            gameoverPic.Top = 100;
            goku.Visible = false;
            pictureBox3.Visible = false;
            pictureBox5.Visible = false;
            ennemiBG.Visible=false;
            gameoverPic.Visible=true;
            tryGameover = true;
        }

        public attaque1()
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
            if (goku.Left > 1470 && nombreDragonBall == 3)
            {
                niveau2(sender, e);
            }
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
            if (goku.Bounds.IntersectsWith(dragonBall4.Bounds))
            {
                dragonBall4.Visible = false;
                nombreDragonBall += 1;
                dragonBall4.Left = 5000;
            }
            if (goku.Bounds.IntersectsWith(dragonBall5.Bounds))
            {
                dragonBall5.Visible = false;
                nombreDragonBall += 1;
                dragonBall5.Left = 5000;
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
            if (gokuBas == true)
            {
                goku.Top += 4;
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
            }else if (goku.Bounds.IntersectsWith(attaque.Bounds) && goku.Bottom - 1 == attaque.Top)
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
            if (goku.Top >= 690)
            {
                tryGameover = true;
                goku.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                sol.Visible = false;
                kintoUn.Visible = false;
                dragonBall1.Visible = false;
                score.Visible = false;
                dragonBall2.Visible = false;
                dragonBall3.Visible = false;
                gameover(sender, e);
            }
            if (goku.Left > 1470 && nombreDragonBall == 5)
            {
                niveauBoss(sender, e);
                goku.Top = 65;
                goku.Left = 10;

                pictureBox5.Visible = false;
                niveau = 3;
                pictureBox2.Visible = false;
                ennemiBG.Visible = false;
                pictureBox3.Visible = false;
                kintoUn.Visible = false;
                ennemieActif = false;
                pictureBox4.Visible = false;
                pictureBox1.Visible = false;
            }

        }
        private void niveau2(object sender, EventArgs e) //niveau2 initialisation
        {
            score.Visible = true;
            nombreDragonBall = 3;
            dragonBall5.Visible = true;
            dragonBall5.Left = 1306;
            dragonBall5.Top = 339;
            goku.Top = 65;
            goku.Visible = true ;
            pictureBox5.Visible = true ;
            niveau = 2;
            goku.Left = 10;
            pictureBox2.Left = 1600;
            pictureBox2.Visible = true;
            pictureBox3.Left = 1600;
            pictureBox4.Left = 1600;
            pictureBox5.Left = 0;
            sol.Left = 1600;
            sol.Top = 1000;
            pictureBox3.Top = 519;
            pictureBox3.Left = -32;
            ennemiBG.Left = 0;
            ennemiBG.Top = 420;
            ennemiBG.Visible = true;
            pictureBox3.Visible = true;
            kintoUn.Visible = true;
            kintoUn.Left = 800;
            kintoUn.Top = 520; 
            ennemieActif = true;
            pictureBox4.Left = 1200;
            pictureBox4.Top = 172;
            pictureBox4.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.Left = 1153;
            pictureBox1.Top = 417;

        }
        private void niveauBoss(object sender, EventArgs e) //niveau2 initialisation
        {
            

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
            dragonBall4.Left = -300;
            goku.Top = 397;
            goku.Left = 100;
            start.Visible = false;
            pictureBoxConsignes.Visible = false;
            goku.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true; 
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            sol.Visible = true;
            kintoUn.Visible = true;
            dragonBall1.Visible = true;
            score.Visible = true;
            dragonBall2.Visible = true;
            dragonBall3.Visible = true;
            attaque.Left = -1000;

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
            else if (e.KeyCode == Keys.S)
            {

                gokuBas = false;

            }
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            this.DoubleBuffered = true; //pour la superposition d'image dans le form  && gravité == false
            if (e.KeyCode == Keys.D )
            {
                goku.Load("C:\\Users\\djila\\OneDrive\\Bureau\\ProjectPurple\\Djilali_YahiaB_WFA\\gokuDroite.png");
                gokuDroite = true;
                if (attDroite ==2 && kameha == false)
                {
                    attDroite = 1;
                }

            }else if (e.KeyCode == Keys.Q)
            {
                gokuGauche = true;
                goku.Load("C:\\Users\\djila\\OneDrive\\Bureau\\ProjectPurple\\Djilali_YahiaB_WFA\\gokuGauche.png");
                if (attDroite == 1 && kameha == false)
                {
                    attDroite = 2;
                }

            }
            else if (e.KeyCode == Keys.S)
            {

                gokuBas = true;

            }
            else if (e.KeyCode == Keys.Space && gravité == false)
            {
                    jump = true;
  
            }
            else if (e.KeyCode == Keys.E && kameha == false)
            {
                kameha = true;

            }
            if (e.KeyCode == Keys.R && tryGameover == true)
            {
                tryGameover = false;
                if (niveau == 2)
                {
                    gameoverPic.Visible = false;
                    niveau2(sender, e);
                }else if (niveau == 0) {
                    gameoverPic.Visible = false;
                    goku.Visible = true;
                    debutJeux(sender, e);
                }

            }
        }
    }
}
