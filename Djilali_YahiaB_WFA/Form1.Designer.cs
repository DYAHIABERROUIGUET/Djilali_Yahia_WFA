namespace Djilali_YahiaB_WFA
{
    partial class attaque1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.horloge = new System.Windows.Forms.Timer(this.components);
            this.goku = new System.Windows.Forms.PictureBox();
            this.options = new System.Windows.Forms.PictureBox();
            this.pictureBoxConsignes = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.PictureBox();
            this.sol = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.kintoUn = new System.Windows.Forms.PictureBox();
            this.dragonBall1 = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            this.dragonBall2 = new System.Windows.Forms.PictureBox();
            this.dragonBall3 = new System.Windows.Forms.PictureBox();
            this.attaque = new System.Windows.Forms.PictureBox();
            this.secondTimer = new System.Windows.Forms.Timer(this.components);
            this.ennemiBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.goku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.options)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsignes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kintoUn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragonBall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragonBall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragonBall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attaque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ennemiBG)).BeginInit();
            this.SuspendLayout();
            // 
            // horloge
            // 
            this.horloge.Enabled = true;
            this.horloge.Interval = 20;
            this.horloge.Tick += new System.EventHandler(this.horloge_Tick);
            // 
            // goku
            // 
            this.goku.BackColor = System.Drawing.Color.Transparent;
            this.goku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.goku.ErrorImage = null;
            this.goku.Image = global::Djilali_YahiaB_WFA.Properties.Resources.image__2_;
            this.goku.Location = new System.Drawing.Point(132, 397);
            this.goku.Name = "goku";
            this.goku.Size = new System.Drawing.Size(63, 97);
            this.goku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goku.TabIndex = 4;
            this.goku.TabStop = false;
            this.goku.Visible = false;
            // 
            // options
            // 
            this.options.Location = new System.Drawing.Point(639, 531);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(189, 61);
            this.options.TabIndex = 3;
            this.options.TabStop = false;
            this.options.Click += new System.EventHandler(this.options_Click);
            // 
            // pictureBoxConsignes
            // 
            this.pictureBoxConsignes.Location = new System.Drawing.Point(484, 82);
            this.pictureBoxConsignes.Name = "pictureBoxConsignes";
            this.pictureBoxConsignes.Size = new System.Drawing.Size(496, 297);
            this.pictureBoxConsignes.TabIndex = 2;
            this.pictureBoxConsignes.TabStop = false;
            this.pictureBoxConsignes.Visible = false;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.Image = global::Djilali_YahiaB_WFA.Properties.Resources.Start;
            this.start.Location = new System.Drawing.Point(622, 413);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(220, 100);
            this.start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.start.TabIndex = 1;
            this.start.TabStop = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // sol
            // 
            this.sol.Image = global::Djilali_YahiaB_WFA.Properties.Resources.sol1;
            this.sol.Location = new System.Drawing.Point(65, 495);
            this.sol.Name = "sol";
            this.sol.Size = new System.Drawing.Size(331, 61);
            this.sol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sol.TabIndex = 5;
            this.sol.TabStop = false;
            this.sol.Tag = "sol";
            this.sol.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Djilali_YahiaB_WFA.Properties.Resources.sol1;
            this.pictureBox1.Location = new System.Drawing.Point(427, 433);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "sol";
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Djilali_YahiaB_WFA.Properties.Resources.sol1;
            this.pictureBox2.Location = new System.Drawing.Point(715, 504);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(331, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "sol";
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Djilali_YahiaB_WFA.Properties.Resources.sol1;
            this.pictureBox3.Location = new System.Drawing.Point(800, 581);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(698, 95);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "sol";
            this.pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Djilali_YahiaB_WFA.Properties.Resources.sol1;
            this.pictureBox4.Location = new System.Drawing.Point(335, 91);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(331, 61);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "sol";
            this.pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Djilali_YahiaB_WFA.Properties.Resources.sol1;
            this.pictureBox5.Location = new System.Drawing.Point(1071, 205);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(418, 61);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "sol";
            this.pictureBox5.Visible = false;
            // 
            // kintoUn
            // 
            this.kintoUn.AccessibleName = "kitoUn";
            this.kintoUn.BackColor = System.Drawing.Color.Transparent;
            this.kintoUn.Image = global::Djilali_YahiaB_WFA.Properties.Resources.nuageMagique;
            this.kintoUn.Location = new System.Drawing.Point(726, 413);
            this.kintoUn.Name = "kintoUn";
            this.kintoUn.Size = new System.Drawing.Size(102, 65);
            this.kintoUn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kintoUn.TabIndex = 11;
            this.kintoUn.TabStop = false;
            this.kintoUn.Visible = false;
            // 
            // dragonBall1
            // 
            this.dragonBall1.BackColor = System.Drawing.Color.Transparent;
            this.dragonBall1.Image = global::Djilali_YahiaB_WFA.Properties.Resources.dragonBall;
            this.dragonBall1.Location = new System.Drawing.Point(396, 35);
            this.dragonBall1.Name = "dragonBall1";
            this.dragonBall1.Size = new System.Drawing.Size(40, 38);
            this.dragonBall1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dragonBall1.TabIndex = 12;
            this.dragonBall1.TabStop = false;
            this.dragonBall1.Visible = false;
            // 
            // score
            // 
            this.score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.score.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(34, 26);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(161, 33);
            this.score.TabIndex = 13;
            this.score.Text = "score : 0";
            this.score.Visible = false;
            // 
            // dragonBall2
            // 
            this.dragonBall2.BackColor = System.Drawing.Color.Transparent;
            this.dragonBall2.Image = global::Djilali_YahiaB_WFA.Properties.Resources.dragonBall__2_;
            this.dragonBall2.Location = new System.Drawing.Point(984, 433);
            this.dragonBall2.Name = "dragonBall2";
            this.dragonBall2.Size = new System.Drawing.Size(40, 38);
            this.dragonBall2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dragonBall2.TabIndex = 14;
            this.dragonBall2.TabStop = false;
            this.dragonBall2.Visible = false;
            // 
            // dragonBall3
            // 
            this.dragonBall3.BackColor = System.Drawing.Color.Transparent;
            this.dragonBall3.Image = global::Djilali_YahiaB_WFA.Properties.Resources.dragonBall__1_;
            this.dragonBall3.Location = new System.Drawing.Point(1135, 149);
            this.dragonBall3.Name = "dragonBall3";
            this.dragonBall3.Size = new System.Drawing.Size(40, 38);
            this.dragonBall3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dragonBall3.TabIndex = 15;
            this.dragonBall3.TabStop = false;
            this.dragonBall3.Visible = false;
            // 
            // attaque
            // 
            this.attaque.BackColor = System.Drawing.Color.Transparent;
            this.attaque.Image = global::Djilali_YahiaB_WFA.Properties.Resources.Kamehameha__1___1_;
            this.attaque.Location = new System.Drawing.Point(217, 363);
            this.attaque.Name = "attaque";
            this.attaque.Size = new System.Drawing.Size(261, 141);
            this.attaque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.attaque.TabIndex = 16;
            this.attaque.TabStop = false;
            this.attaque.Visible = false;
            // 
            // secondTimer
            // 
            this.secondTimer.Enabled = true;
            this.secondTimer.Interval = 20;
            this.secondTimer.Tick += new System.EventHandler(this.secondTimer_Tick);
            // 
            // ennemiBG
            // 
            this.ennemiBG.BackColor = System.Drawing.Color.Transparent;
            this.ennemiBG.Image = global::Djilali_YahiaB_WFA.Properties.Resources.blackGoku;
            this.ennemiBG.Location = new System.Drawing.Point(12, 82);
            this.ennemiBG.Name = "ennemiBG";
            this.ennemiBG.Size = new System.Drawing.Size(55, 84);
            this.ennemiBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ennemiBG.TabIndex = 17;
            this.ennemiBG.TabStop = false;
            this.ennemiBG.Visible = false;
            // 
            // attaque1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Djilali_YahiaB_WFA.Properties.Resources.debutBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1477, 688);
            this.Controls.Add(this.ennemiBG);
            this.Controls.Add(this.attaque);
            this.Controls.Add(this.dragonBall3);
            this.Controls.Add(this.dragonBall2);
            this.Controls.Add(this.score);
            this.Controls.Add(this.dragonBall1);
            this.Controls.Add(this.kintoUn);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sol);
            this.Controls.Add(this.goku);
            this.Controls.Add(this.options);
            this.Controls.Add(this.pictureBoxConsignes);
            this.Controls.Add(this.start);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "attaque1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Platformer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.goku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.options)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsignes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kintoUn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragonBall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragonBall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragonBall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attaque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ennemiBG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer horloge;
        private System.Windows.Forms.PictureBox start;
        private System.Windows.Forms.PictureBox pictureBoxConsignes;
        private System.Windows.Forms.PictureBox options;
        private System.Windows.Forms.PictureBox goku;
        private System.Windows.Forms.PictureBox sol;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox kintoUn;
        private System.Windows.Forms.PictureBox dragonBall1;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.PictureBox dragonBall2;
        private System.Windows.Forms.PictureBox dragonBall3;
        private System.Windows.Forms.PictureBox attaque;
        private System.Windows.Forms.Timer secondTimer;
        private System.Windows.Forms.PictureBox ennemiBG;
    }
}

