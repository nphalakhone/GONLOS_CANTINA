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
            this.BtnDice = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.GbLog.Location = new System.Drawing.Point(864, 27);
            this.GbLog.Name = "GbLog";
            this.GbLog.Size = new System.Drawing.Size(564, 421);
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
            this.GbDice.Controls.Add(this.BtnDice);
            this.GbDice.Location = new System.Drawing.Point(864, 454);
            this.GbDice.Name = "GbDice";
            this.GbDice.Size = new System.Drawing.Size(564, 410);
            this.GbDice.TabIndex = 2;
            this.GbDice.TabStop = false;
            this.GbDice.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // BtnDice
            // 
            this.BtnDice.Font = new System.Drawing.Font("SF Distant Galaxy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDice.Location = new System.Drawing.Point(219, 372);
            this.BtnDice.Name = "BtnDice";
            this.BtnDice.Size = new System.Drawing.Size(149, 32);
            this.BtnDice.TabIndex = 0;
            this.BtnDice.Text = "Roll the dice";
            this.BtnDice.UseVisualStyleBackColor = true;
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
            // Dejarik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projet_GONLO.Properties.Resources.StarsBackground;
            this.ClientSize = new System.Drawing.Size(1440, 876);
            this.Controls.Add(this.GbDice);
            this.Controls.Add(this.GbLog);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dejarik";
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
    }
}