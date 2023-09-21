using System;
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
        bool startBegin = false;

        int temps = 0;
        bool gravité = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (startBegin == true) //conditions pour lancer le jeux (prise d'info avant )
            {
                debutJeux(sender, e);
            }
            else
            {
                consignes(sender, e);
            }
        }

        private void horloge_Tick(object sender, EventArgs e)
        {
            temps++;
            if (gravité == true)
            {
                goku.Top -= 5;
            }

        }
        private void consignes(object sender, EventArgs e) //prise d'informations du jeux 
        {
            startBegin = true;
            pictureBoxConsignes.Visible = true;
            options.Visible = false;
        }
        private void debutJeux(object sender, EventArgs e) //lancement du jeux 
        {
            start.Visible = false;
            pictureBoxConsignes.Visible = false;
            goku.Visible = true;
        }

        private void options_Click(object sender, EventArgs e) //quand on rentre dans le menu option
        {

        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                goku.Load("C:\\Users\\djila\\OneDrive\\Bureau\\ProjectPurple\\Djilali_YahiaB_WFA\\gokuBase.png");
            }
            else if (e.KeyCode == Keys.Q)
            {
                goku.Load("C:\\Users\\djila\\OneDrive\\Bureau\\ProjectPurple\\Djilali_YahiaB_WFA\\gokuBaseGauche.png");
            }
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            this.DoubleBuffered = true; //pour la superposition d'image dans le form  && gravité == false
            if (e.KeyCode == Keys.D )
            {
                goku.Load("C:\\Users\\djila\\OneDrive\\Bureau\\ProjectPurple\\Djilali_YahiaB_WFA\\gokuDroite.png");
                goku.Left = goku.Left + 10;
            }else if (e.KeyCode == Keys.Q)
            {
                goku.Left = goku.Left - 10;
                goku.Load("C:\\Users\\djila\\OneDrive\\Bureau\\ProjectPurple\\Djilali_YahiaB_WFA\\gokuGauche.png");

            }
        }
    }
}
