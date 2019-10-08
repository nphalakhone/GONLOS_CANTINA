namespace Projet_GONLO
{
    partial class Dejarik
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GbLog = new System.Windows.Forms.GroupBox();
            this.ListBoxLog = new System.Windows.Forms.ListBox();
            this.LblPlayerTurn = new System.Windows.Forms.Label();
            this.GbDice = new System.Windows.Forms.GroupBox();
            this.PnlDe = new System.Windows.Forms.Panel();
            this.BtnDice = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bouttonCercle1 = new Projet_GONLO.BouttonCercle();
            this.bouttonCercle2 = new Projet_GONLO.BouttonCercle();
            this.bouttonCercle3 = new Projet_GONLO.BouttonCercle();
            this.bouttonCercle4 = new Projet_GONLO.BouttonCercle();
            this.bouttonCercle5 = new Projet_GONLO.BouttonCercle();
            this.bouttonCercle6 = new Projet_GONLO.BouttonCercle();
            this.bouttonCercle7 = new Projet_GONLO.BouttonCercle();
            this.bouttonCercle8 = new Projet_GONLO.BouttonCercle();
            this.bouttonCercle9 = new Projet_GONLO.BouttonCercle();
            this.bouttonCercle10 = new Projet_GONLO.BouttonCercle();
            this.bouttonCercle11 = new Projet_GONLO.BouttonCercle();
            this.bouttonCercle12 = new Projet_GONLO.BouttonCercle();
            this.bouttonCercle13 = new Projet_GONLO.BouttonCercle();
            this.bouttonCercle14 = new Projet_GONLO.BouttonCercle();
            this.bouttonCercle15 = new Projet_GONLO.BouttonCercle();
            this.bouttonCercle16 = new Projet_GONLO.BouttonCercle();
            this.bouttonCercle17 = new Projet_GONLO.BouttonCercle();
            this.bouttonCercle18 = new Projet_GONLO.BouttonCercle();
            this.bouttonCercle19 = new Projet_GONLO.BouttonCercle();
            this.bouttonCercle20 = new Projet_GONLO.BouttonCercle();
            this.bouttonCercle21 = new Projet_GONLO.BouttonCercle();
            this.bouttonCercle22 = new Projet_GONLO.BouttonCercle();
            this.bouttonCercle23 = new Projet_GONLO.BouttonCercle();
            this.bouttonCercle24 = new Projet_GONLO.BouttonCercle();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GbLog.SuspendLayout();
            this.GbDice.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Projet_GONLO.Properties.Resources._interface;
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(834, 836);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GbLog
            // 
            this.GbLog.Controls.Add(this.ListBoxLog);
            this.GbLog.Controls.Add(this.LblPlayerTurn);
            this.GbLog.Location = new System.Drawing.Point(864, 28);
            this.GbLog.Name = "GbLog";
            this.GbLog.Size = new System.Drawing.Size(564, 420);
            this.GbLog.TabIndex = 1;
            this.GbLog.TabStop = false;
            this.GbLog.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // ListBoxLog
            // 
            this.ListBoxLog.FormattingEnabled = true;
            this.ListBoxLog.Location = new System.Drawing.Point(6, 60);
            this.ListBoxLog.Name = "ListBoxLog";
            this.ListBoxLog.Size = new System.Drawing.Size(552, 355);
            this.ListBoxLog.TabIndex = 1;
            // 
            // LblPlayerTurn
            // 
            this.LblPlayerTurn.AutoSize = true;
            this.LblPlayerTurn.Font = new System.Drawing.Font("SF Distant Galaxy", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayerTurn.Location = new System.Drawing.Point(6, 16);
            this.LblPlayerTurn.Name = "LblPlayerTurn";
            this.LblPlayerTurn.Size = new System.Drawing.Size(339, 38);
            this.LblPlayerTurn.TabIndex = 0;
            this.LblPlayerTurn.Text = "Player 1 Turn";
            // 
            // GbDice
            // 
            this.GbDice.Controls.Add(this.PnlDe);
            this.GbDice.Controls.Add(this.BtnDice);
            this.GbDice.Location = new System.Drawing.Point(864, 454);
            this.GbDice.Name = "GbDice";
            this.GbDice.Size = new System.Drawing.Size(564, 410);
            this.GbDice.TabIndex = 2;
            this.GbDice.TabStop = false;
            this.GbDice.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // PnlDe
            // 
            this.PnlDe.BackgroundImage = global::Projet_GONLO.Properties.Resources.dice_six_faces_one;
            this.PnlDe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlDe.Location = new System.Drawing.Point(139, 32);
            this.PnlDe.Name = "PnlDe";
            this.PnlDe.Size = new System.Drawing.Size(300, 300);
            this.PnlDe.TabIndex = 1;
            this.PnlDe.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // BtnDice
            // 
            this.BtnDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDice.Location = new System.Drawing.Point(219, 372);
            this.BtnDice.Name = "BtnDice";
            this.BtnDice.Size = new System.Drawing.Size(149, 32);
            this.BtnDice.TabIndex = 0;
            this.BtnDice.Text = "Roll the dice";
            this.BtnDice.UseVisualStyleBackColor = true;
            this.BtnDice.Click += new System.EventHandler(this.BtnDice_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1440, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // bouttonCercle1
            // 
            this.bouttonCercle1.AutoEllipsis = true;
            this.bouttonCercle1.Location = new System.Drawing.Point(318, 108);
            this.bouttonCercle1.Name = "bouttonCercle1";
            this.bouttonCercle1.Size = new System.Drawing.Size(81, 90);
            this.bouttonCercle1.TabIndex = 6;
            this.bouttonCercle1.UseVisualStyleBackColor = true;
            // 
            // bouttonCercle2
            // 
            this.bouttonCercle2.AutoEllipsis = true;
            this.bouttonCercle2.Location = new System.Drawing.Point(472, 108);
            this.bouttonCercle2.Name = "bouttonCercle2";
            this.bouttonCercle2.Size = new System.Drawing.Size(81, 90);
            this.bouttonCercle2.TabIndex = 7;
            this.bouttonCercle2.UseVisualStyleBackColor = true;
            // 
            // bouttonCercle3
            // 
            this.bouttonCercle3.AutoEllipsis = true;
            this.bouttonCercle3.Location = new System.Drawing.Point(612, 177);
            this.bouttonCercle3.Name = "bouttonCercle3";
            this.bouttonCercle3.Size = new System.Drawing.Size(81, 90);
            this.bouttonCercle3.TabIndex = 8;
            this.bouttonCercle3.UseVisualStyleBackColor = true;
            // 
            // bouttonCercle4
            // 
            this.bouttonCercle4.AutoEllipsis = true;
            this.bouttonCercle4.Location = new System.Drawing.Point(698, 325);
            this.bouttonCercle4.Name = "bouttonCercle4";
            this.bouttonCercle4.Size = new System.Drawing.Size(81, 90);
            this.bouttonCercle4.TabIndex = 9;
            this.bouttonCercle4.UseVisualStyleBackColor = true;
            // 
            // bouttonCercle5
            // 
            this.bouttonCercle5.AutoEllipsis = true;
            this.bouttonCercle5.Location = new System.Drawing.Point(698, 486);
            this.bouttonCercle5.Name = "bouttonCercle5";
            this.bouttonCercle5.Size = new System.Drawing.Size(81, 90);
            this.bouttonCercle5.TabIndex = 10;
            this.bouttonCercle5.UseVisualStyleBackColor = true;
            // 
            // bouttonCercle6
            // 
            this.bouttonCercle6.AutoEllipsis = true;
            this.bouttonCercle6.Location = new System.Drawing.Point(612, 628);
            this.bouttonCercle6.Name = "bouttonCercle6";
            this.bouttonCercle6.Size = new System.Drawing.Size(81, 90);
            this.bouttonCercle6.TabIndex = 11;
            this.bouttonCercle6.UseVisualStyleBackColor = true;
            // 
            // bouttonCercle7
            // 
            this.bouttonCercle7.AutoEllipsis = true;
            this.bouttonCercle7.Location = new System.Drawing.Point(472, 713);
            this.bouttonCercle7.Name = "bouttonCercle7";
            this.bouttonCercle7.Size = new System.Drawing.Size(81, 90);
            this.bouttonCercle7.TabIndex = 12;
            this.bouttonCercle7.UseVisualStyleBackColor = true;
            // 
            // bouttonCercle8
            // 
            this.bouttonCercle8.AutoEllipsis = true;
            this.bouttonCercle8.Location = new System.Drawing.Point(318, 713);
            this.bouttonCercle8.Name = "bouttonCercle8";
            this.bouttonCercle8.Size = new System.Drawing.Size(81, 90);
            this.bouttonCercle8.TabIndex = 13;
            this.bouttonCercle8.UseVisualStyleBackColor = true;
            // 
            // bouttonCercle9
            // 
            this.bouttonCercle9.AutoEllipsis = true;
            this.bouttonCercle9.Location = new System.Drawing.Point(170, 628);
            this.bouttonCercle9.Name = "bouttonCercle9";
            this.bouttonCercle9.Size = new System.Drawing.Size(81, 90);
            this.bouttonCercle9.TabIndex = 14;
            this.bouttonCercle9.UseVisualStyleBackColor = true;
            // 
            // bouttonCercle10
            // 
            this.bouttonCercle10.AutoEllipsis = true;
            this.bouttonCercle10.Location = new System.Drawing.Point(92, 486);
            this.bouttonCercle10.Name = "bouttonCercle10";
            this.bouttonCercle10.Size = new System.Drawing.Size(81, 90);
            this.bouttonCercle10.TabIndex = 15;
            this.bouttonCercle10.UseVisualStyleBackColor = true;
            // 
            // bouttonCercle11
            // 
            this.bouttonCercle11.AutoEllipsis = true;
            this.bouttonCercle11.Location = new System.Drawing.Point(92, 325);
            this.bouttonCercle11.Name = "bouttonCercle11";
            this.bouttonCercle11.Size = new System.Drawing.Size(81, 90);
            this.bouttonCercle11.TabIndex = 16;
            this.bouttonCercle11.UseVisualStyleBackColor = true;
            // 
            // bouttonCercle12
            // 
            this.bouttonCercle12.AutoEllipsis = true;
            this.bouttonCercle12.Location = new System.Drawing.Point(170, 177);
            this.bouttonCercle12.Name = "bouttonCercle12";
            this.bouttonCercle12.Size = new System.Drawing.Size(81, 90);
            this.bouttonCercle12.TabIndex = 17;
            this.bouttonCercle12.UseVisualStyleBackColor = true;
            // 
            // bouttonCercle13
            // 
            this.bouttonCercle13.AutoEllipsis = true;
            this.bouttonCercle13.Location = new System.Drawing.Point(351, 233);
            this.bouttonCercle13.Name = "bouttonCercle13";
            this.bouttonCercle13.Size = new System.Drawing.Size(81, 90);
            this.bouttonCercle13.TabIndex = 18;
            this.bouttonCercle13.UseVisualStyleBackColor = true;
            // 
            // bouttonCercle14
            // 
            this.bouttonCercle14.AutoEllipsis = true;
            this.bouttonCercle14.Location = new System.Drawing.Point(438, 233);
            this.bouttonCercle14.Name = "bouttonCercle14";
            this.bouttonCercle14.Size = new System.Drawing.Size(81, 90);
            this.bouttonCercle14.TabIndex = 19;
            this.bouttonCercle14.UseVisualStyleBackColor = true;
            // 
            // bouttonCercle15
            // 
            this.bouttonCercle15.AutoEllipsis = true;
            this.bouttonCercle15.Location = new System.Drawing.Point(525, 274);
            this.bouttonCercle15.Name = "bouttonCercle15";
            this.bouttonCercle15.Size = new System.Drawing.Size(81, 90);
            this.bouttonCercle15.TabIndex = 20;
            this.bouttonCercle15.UseVisualStyleBackColor = true;
            // 
            // bouttonCercle16
            // 
            this.bouttonCercle16.AutoEllipsis = true;
            this.bouttonCercle16.Location = new System.Drawing.Point(573, 358);
            this.bouttonCercle16.Name = "bouttonCercle16";
            this.bouttonCercle16.Size = new System.Drawing.Size(81, 90);
            this.bouttonCercle16.TabIndex = 21;
            this.bouttonCercle16.UseVisualStyleBackColor = true;
            // 
            // bouttonCercle17
            // 
            this.bouttonCercle17.AutoEllipsis = true;
            this.bouttonCercle17.Location = new System.Drawing.Point(573, 454);
            this.bouttonCercle17.Name = "bouttonCercle17";
            this.bouttonCercle17.Size = new System.Drawing.Size(81, 90);
            this.bouttonCercle17.TabIndex = 22;
            this.bouttonCercle17.UseVisualStyleBackColor = true;
            // 
            // bouttonCercle18
            // 
            this.bouttonCercle18.AutoEllipsis = true;
            this.bouttonCercle18.Location = new System.Drawing.Point(525, 533);
            this.bouttonCercle18.Name = "bouttonCercle18";
            this.bouttonCercle18.Size = new System.Drawing.Size(81, 90);
            this.bouttonCercle18.TabIndex = 23;
            this.bouttonCercle18.UseVisualStyleBackColor = true;
            // 
            // bouttonCercle19
            // 
            this.bouttonCercle19.AutoEllipsis = true;
            this.bouttonCercle19.Location = new System.Drawing.Point(438, 577);
            this.bouttonCercle19.Name = "bouttonCercle19";
            this.bouttonCercle19.Size = new System.Drawing.Size(81, 90);
            this.bouttonCercle19.TabIndex = 24;
            this.bouttonCercle19.UseVisualStyleBackColor = true;
            // 
            // bouttonCercle20
            // 
            this.bouttonCercle20.AutoEllipsis = true;
            this.bouttonCercle20.Location = new System.Drawing.Point(351, 577);
            this.bouttonCercle20.Name = "bouttonCercle20";
            this.bouttonCercle20.Size = new System.Drawing.Size(81, 90);
            this.bouttonCercle20.TabIndex = 25;
            this.bouttonCercle20.UseVisualStyleBackColor = true;
            // 
            // bouttonCercle21
            // 
            this.bouttonCercle21.AutoEllipsis = true;
            this.bouttonCercle21.Location = new System.Drawing.Point(264, 533);
            this.bouttonCercle21.Name = "bouttonCercle21";
            this.bouttonCercle21.Size = new System.Drawing.Size(81, 90);
            this.bouttonCercle21.TabIndex = 26;
            this.bouttonCercle21.UseVisualStyleBackColor = true;
            // 
            // bouttonCercle22
            // 
            this.bouttonCercle22.AutoEllipsis = true;
            this.bouttonCercle22.Location = new System.Drawing.Point(218, 454);
            this.bouttonCercle22.Name = "bouttonCercle22";
            this.bouttonCercle22.Size = new System.Drawing.Size(81, 90);
            this.bouttonCercle22.TabIndex = 27;
            this.bouttonCercle22.UseVisualStyleBackColor = true;
            // 
            // bouttonCercle23
            // 
            this.bouttonCercle23.AutoEllipsis = true;
            this.bouttonCercle23.Location = new System.Drawing.Point(218, 358);
            this.bouttonCercle23.Name = "bouttonCercle23";
            this.bouttonCercle23.Size = new System.Drawing.Size(81, 90);
            this.bouttonCercle23.TabIndex = 28;
            this.bouttonCercle23.UseVisualStyleBackColor = true;
            // 
            // bouttonCercle24
            // 
            this.bouttonCercle24.AutoEllipsis = true;
            this.bouttonCercle24.Location = new System.Drawing.Point(264, 274);
            this.bouttonCercle24.Name = "bouttonCercle24";
            this.bouttonCercle24.Size = new System.Drawing.Size(81, 90);
            this.bouttonCercle24.TabIndex = 29;
            this.bouttonCercle24.UseVisualStyleBackColor = true;
            // 
            // Dejarik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projet_GONLO.Properties.Resources.StarsBackground;
            this.ClientSize = new System.Drawing.Size(1440, 876);
            this.Controls.Add(this.bouttonCercle24);
            this.Controls.Add(this.bouttonCercle23);
            this.Controls.Add(this.bouttonCercle22);
            this.Controls.Add(this.bouttonCercle21);
            this.Controls.Add(this.bouttonCercle20);
            this.Controls.Add(this.bouttonCercle19);
            this.Controls.Add(this.bouttonCercle18);
            this.Controls.Add(this.bouttonCercle17);
            this.Controls.Add(this.bouttonCercle16);
            this.Controls.Add(this.bouttonCercle15);
            this.Controls.Add(this.bouttonCercle14);
            this.Controls.Add(this.bouttonCercle13);
            this.Controls.Add(this.bouttonCercle12);
            this.Controls.Add(this.bouttonCercle11);
            this.Controls.Add(this.bouttonCercle10);
            this.Controls.Add(this.bouttonCercle9);
            this.Controls.Add(this.bouttonCercle8);
            this.Controls.Add(this.bouttonCercle7);
            this.Controls.Add(this.bouttonCercle6);
            this.Controls.Add(this.bouttonCercle5);
            this.Controls.Add(this.bouttonCercle4);
            this.Controls.Add(this.bouttonCercle3);
            this.Controls.Add(this.bouttonCercle2);
            this.Controls.Add(this.bouttonCercle1);
            this.Controls.Add(this.GbDice);
            this.Controls.Add(this.GbLog);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dejarik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dejarik";
            this.Load += new System.EventHandler(this.Dejarik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GbLog.ResumeLayout(false);
            this.GbLog.PerformLayout();
            this.GbDice.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GbLog;
        private System.Windows.Forms.GroupBox GbDice;
        private System.Windows.Forms.Label LblPlayerTurn;
        private System.Windows.Forms.Button BtnDice;
        private System.Windows.Forms.ListBox ListBoxLog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private RoundPanel PnlDice;
        private System.Windows.Forms.Panel PnlDe;
        private BouttonCercle bouttonCercle1;
        private BouttonCercle bouttonCercle2;
        private BouttonCercle bouttonCercle3;
        private BouttonCercle bouttonCercle4;
        private BouttonCercle bouttonCercle5;
        private BouttonCercle bouttonCercle6;
        private BouttonCercle bouttonCercle7;
        private BouttonCercle bouttonCercle8;
        private BouttonCercle bouttonCercle9;
        private BouttonCercle bouttonCercle10;
        private BouttonCercle bouttonCercle11;
        private BouttonCercle bouttonCercle12;
        private BouttonCercle bouttonCercle13;
        private BouttonCercle bouttonCercle14;
        private BouttonCercle bouttonCercle15;
        private BouttonCercle bouttonCercle16;
        private BouttonCercle bouttonCercle17;
        private BouttonCercle bouttonCercle18;
        private BouttonCercle bouttonCercle19;
        private BouttonCercle bouttonCercle20;
        private BouttonCercle bouttonCercle21;
        private BouttonCercle bouttonCercle22;
        private BouttonCercle bouttonCercle23;
        private BouttonCercle bouttonCercle24;
    }
}