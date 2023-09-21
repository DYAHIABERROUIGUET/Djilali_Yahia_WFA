namespace Djilali_YahiaB_WFA
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.horloge = new System.Windows.Forms.Timer(this.components);
            this.goku = new System.Windows.Forms.PictureBox();
            this.options = new System.Windows.Forms.PictureBox();
            this.pictureBoxConsignes = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.goku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.options)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsignes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
            this.SuspendLayout();
            // 
            // horloge
            // 
            this.horloge.Tick += new System.EventHandler(this.horloge_Tick);
            // 
            // goku
            // 
            this.goku.BackColor = System.Drawing.Color.Transparent;
            this.goku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.goku.ErrorImage = null;
            this.goku.Image = global::Djilali_YahiaB_WFA.Properties.Resources.gokuBaseGauche;
            this.goku.Location = new System.Drawing.Point(147, 452);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1477, 688);
            this.Controls.Add(this.goku);
            this.Controls.Add(this.options);
            this.Controls.Add(this.pictureBoxConsignes);
            this.Controls.Add(this.start);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Platformer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.goku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.options)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsignes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer horloge;
        private System.Windows.Forms.PictureBox start;
        private System.Windows.Forms.PictureBox pictureBoxConsignes;
        private System.Windows.Forms.PictureBox options;
        private System.Windows.Forms.PictureBox goku;
    }
}

