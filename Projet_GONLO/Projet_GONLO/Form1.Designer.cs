namespace Projet_GONLO
{
    partial class MenuAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAccueil));
            this.LblWelcome = new System.Windows.Forms.Label();
            this.LblGonlo = new System.Windows.Forms.Label();
            this.timerSlide1 = new System.Windows.Forms.Timer(this.components);
            this.RPnlPazaak = new Projet_GONLO.RoundPanel();
            this.BtnEllPlayPazaak = new Projet_GONLO.ButtonEllipse();
            this.GbxPazaak = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RPnlP2 = new Projet_GONLO.RoundPanel();
            this.RPnlImgPazaak = new Projet_GONLO.RoundPanel();
            this.BtnEllSettings = new Projet_GONLO.ButtonEllipse();
            this.BtnEllSB = new Projet_GONLO.ButtonEllipse();
            this.BtnEllDejarik = new Projet_GONLO.ButtonEllipse();
            this.BtnEllPazaak = new Projet_GONLO.ButtonEllipse();
            this.RPnlPazaak.SuspendLayout();
            this.GbxPazaak.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblWelcome
            // 
            this.LblWelcome.AutoSize = true;
            this.LblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.LblWelcome.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWelcome.ForeColor = System.Drawing.Color.Fuchsia;
            this.LblWelcome.Location = new System.Drawing.Point(12, 9);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(560, 17);
            this.LblWelcome.TabIndex = 4;
            this.LblWelcome.Text = "Welcome to the jewel of the cantinas of Nar Shaddaa";
            // 
            // LblGonlo
            // 
            this.LblGonlo.AutoSize = true;
            this.LblGonlo.BackColor = System.Drawing.Color.Transparent;
            this.LblGonlo.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGonlo.ForeColor = System.Drawing.Color.Fuchsia;
            this.LblGonlo.Location = new System.Drawing.Point(10, 42);
            this.LblGonlo.Name = "LblGonlo";
            this.LblGonlo.Size = new System.Drawing.Size(328, 30);
            this.LblGonlo.TabIndex = 5;
            this.LblGonlo.Text = "G.O.N.L.O.\'S CANTINA";
            // 
            // timerSlide1
            // 
            this.timerSlide1.Enabled = true;
            this.timerSlide1.Interval = 10;
            this.timerSlide1.Tick += new System.EventHandler(this.TimerSlide1_Tick);
            // 
            // RPnlPazaak
            // 
            this.RPnlPazaak.BackgroundImage = global::Projet_GONLO.Properties.Resources.backButtonSteel;
            this.RPnlPazaak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RPnlPazaak.BorderColor = System.Drawing.Color.White;
            this.RPnlPazaak.Controls.Add(this.BtnEllPlayPazaak);
            this.RPnlPazaak.Controls.Add(this.GbxPazaak);
            this.RPnlPazaak.Controls.Add(this.RPnlP2);
            this.RPnlPazaak.Controls.Add(this.RPnlImgPazaak);
            this.RPnlPazaak.Edge = 20;
            this.RPnlPazaak.Location = new System.Drawing.Point(592, 89);
            this.RPnlPazaak.Name = "RPnlPazaak";
            this.RPnlPazaak.Size = new System.Drawing.Size(580, 459);
            this.RPnlPazaak.TabIndex = 11;
            // 
            // BtnEllPlayPazaak
            // 
            this.BtnEllPlayPazaak.BackgroundImage = global::Projet_GONLO.Properties.Resources.backButtongold;
            this.BtnEllPlayPazaak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEllPlayPazaak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEllPlayPazaak.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEllPlayPazaak.Location = new System.Drawing.Point(366, 171);
            this.BtnEllPlayPazaak.Name = "BtnEllPlayPazaak";
            this.BtnEllPlayPazaak.Size = new System.Drawing.Size(197, 94);
            this.BtnEllPlayPazaak.TabIndex = 3;
            this.BtnEllPlayPazaak.Text = "Play";
            this.BtnEllPlayPazaak.UseVisualStyleBackColor = true;
            // 
            // GbxPazaak
            // 
            this.GbxPazaak.BackColor = System.Drawing.Color.Transparent;
            this.GbxPazaak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GbxPazaak.Controls.Add(this.label8);
            this.GbxPazaak.Controls.Add(this.label7);
            this.GbxPazaak.Controls.Add(this.label6);
            this.GbxPazaak.Controls.Add(this.label5);
            this.GbxPazaak.Controls.Add(this.label4);
            this.GbxPazaak.Controls.Add(this.label3);
            this.GbxPazaak.Controls.Add(this.label2);
            this.GbxPazaak.Controls.Add(this.label1);
            this.GbxPazaak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbxPazaak.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxPazaak.Location = new System.Drawing.Point(15, 288);
            this.GbxPazaak.Name = "GbxPazaak";
            this.GbxPazaak.Size = new System.Drawing.Size(548, 156);
            this.GbxPazaak.TabIndex = 2;
            this.GbxPazaak.TabStop = false;
            this.GbxPazaak.Text = "Pazaak Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(298, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "the round was not counted at all.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(496, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "If in one round the scores of the two players were equal,";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(500, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "won the round, and the player who won three rounds won";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 14);
            this.label5.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(521, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "opponent. The player with the nearest sum to the number 20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(498, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "without going over or at least come closer to it than the";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(509, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "was a popular card game in which the goal was to reach 20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pazaak, an ancient game dating back to the Old Republic times,";
            // 
            // RPnlP2
            // 
            this.RPnlP2.BackgroundImage = global::Projet_GONLO.Properties.Resources.pazaakBackground1;
            this.RPnlP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RPnlP2.BorderColor = System.Drawing.Color.White;
            this.RPnlP2.Edge = 20;
            this.RPnlP2.Location = new System.Drawing.Point(366, 15);
            this.RPnlP2.Name = "RPnlP2";
            this.RPnlP2.Size = new System.Drawing.Size(197, 137);
            this.RPnlP2.TabIndex = 1;
            // 
            // RPnlImgPazaak
            // 
            this.RPnlImgPazaak.BackgroundImage = global::Projet_GONLO.Properties.Resources.pazaakBoard;
            this.RPnlImgPazaak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RPnlImgPazaak.BorderColor = System.Drawing.Color.White;
            this.RPnlImgPazaak.Edge = 20;
            this.RPnlImgPazaak.Location = new System.Drawing.Point(15, 15);
            this.RPnlImgPazaak.Name = "RPnlImgPazaak";
            this.RPnlImgPazaak.Size = new System.Drawing.Size(325, 250);
            this.RPnlImgPazaak.TabIndex = 0;
            // 
            // BtnEllSettings
            // 
            this.BtnEllSettings.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEllSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEllSettings.BackgroundImage")));
            this.BtnEllSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEllSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEllSettings.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEllSettings.ForeColor = System.Drawing.Color.LimeGreen;
            this.BtnEllSettings.Location = new System.Drawing.Point(35, 452);
            this.BtnEllSettings.Name = "BtnEllSettings";
            this.BtnEllSettings.Size = new System.Drawing.Size(250, 61);
            this.BtnEllSettings.TabIndex = 10;
            this.BtnEllSettings.Text = "SETTINGS";
            this.BtnEllSettings.UseVisualStyleBackColor = false;
            this.BtnEllSettings.Click += new System.EventHandler(this.BtnEllSettings_Click);
            // 
            // BtnEllSB
            // 
            this.BtnEllSB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEllSB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEllSB.BackgroundImage")));
            this.BtnEllSB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEllSB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEllSB.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEllSB.ForeColor = System.Drawing.Color.LimeGreen;
            this.BtnEllSB.Location = new System.Drawing.Point(35, 345);
            this.BtnEllSB.Name = "BtnEllSB";
            this.BtnEllSB.Size = new System.Drawing.Size(250, 61);
            this.BtnEllSB.TabIndex = 9;
            this.BtnEllSB.Text = "SWOOP BIKE RACNG";
            this.BtnEllSB.UseVisualStyleBackColor = false;
            this.BtnEllSB.Click += new System.EventHandler(this.BtnEllSB_Click);
            // 
            // BtnEllDejarik
            // 
            this.BtnEllDejarik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEllDejarik.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEllDejarik.BackgroundImage")));
            this.BtnEllDejarik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEllDejarik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEllDejarik.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEllDejarik.ForeColor = System.Drawing.Color.LimeGreen;
            this.BtnEllDejarik.Location = new System.Drawing.Point(35, 246);
            this.BtnEllDejarik.Name = "BtnEllDejarik";
            this.BtnEllDejarik.Size = new System.Drawing.Size(250, 61);
            this.BtnEllDejarik.TabIndex = 8;
            this.BtnEllDejarik.Text = "Dejarik";
            this.BtnEllDejarik.UseVisualStyleBackColor = false;
            this.BtnEllDejarik.Click += new System.EventHandler(this.BtnEllDejarik_Click);
            // 
            // BtnEllPazaak
            // 
            this.BtnEllPazaak.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEllPazaak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEllPazaak.BackgroundImage")));
            this.BtnEllPazaak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEllPazaak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEllPazaak.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEllPazaak.ForeColor = System.Drawing.Color.LimeGreen;
            this.BtnEllPazaak.Location = new System.Drawing.Point(35, 150);
            this.BtnEllPazaak.Name = "BtnEllPazaak";
            this.BtnEllPazaak.Size = new System.Drawing.Size(250, 61);
            this.BtnEllPazaak.TabIndex = 7;
            this.BtnEllPazaak.Text = "PAZAAK";
            this.BtnEllPazaak.UseVisualStyleBackColor = false;
            this.BtnEllPazaak.Click += new System.EventHandler(this.BtnEllPazaak_Click);
            // 
            // MenuAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projet_GONLO.Properties.Resources.Slippery_Slopes_Cantina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 560);
            this.Controls.Add(this.RPnlPazaak);
            this.Controls.Add(this.BtnEllSettings);
            this.Controls.Add(this.BtnEllSB);
            this.Controls.Add(this.BtnEllDejarik);
            this.Controls.Add(this.BtnEllPazaak);
            this.Controls.Add(this.LblGonlo);
            this.Controls.Add(this.LblWelcome);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "G.O.N.L.O\'S CANTINA";
            this.Load += new System.EventHandler(this.MenuAccueil_Load);
            this.RPnlPazaak.ResumeLayout(false);
            this.GbxPazaak.ResumeLayout(false);
            this.GbxPazaak.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblWelcome;
        private System.Windows.Forms.Label LblGonlo;
        private ButtonEllipse BtnEllPazaak;
        private ButtonEllipse BtnEllDejarik;
        private ButtonEllipse BtnEllSB;
        private ButtonEllipse BtnEllSettings;
        private RoundPanel RPnlPazaak;
        private RoundPanel RPnlImgPazaak;
        private System.Windows.Forms.GroupBox GbxPazaak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RoundPanel RPnlP2;
        private System.Windows.Forms.Label label5;
        private ButtonEllipse BtnEllPlayPazaak;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timerSlide1;
    }
}

