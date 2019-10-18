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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dejarik));
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
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Button1 = new Projet_GONLO.BouttonCercle();
            this.Button13 = new Projet_GONLO.BouttonCercle();
            this.Button12 = new Projet_GONLO.BouttonCercle();
            this.Button11 = new Projet_GONLO.BouttonCercle();
            this.Button10 = new Projet_GONLO.BouttonCercle();
            this.Button9 = new Projet_GONLO.BouttonCercle();
            this.Button8 = new Projet_GONLO.BouttonCercle();
            this.Button7 = new Projet_GONLO.BouttonCercle();
            this.Button6 = new Projet_GONLO.BouttonCercle();
            this.Button5 = new Projet_GONLO.BouttonCercle();
            this.Button4 = new Projet_GONLO.BouttonCercle();
            this.Button3 = new Projet_GONLO.BouttonCercle();
            this.Button2 = new Projet_GONLO.BouttonCercle();
            this.Button14 = new Projet_GONLO.BouttonCercle();
            this.Button25 = new Projet_GONLO.BouttonCercle();
            this.Button24 = new Projet_GONLO.BouttonCercle();
            this.Button23 = new Projet_GONLO.BouttonCercle();
            this.Button22 = new Projet_GONLO.BouttonCercle();
            this.Button21 = new Projet_GONLO.BouttonCercle();
            this.Button20 = new Projet_GONLO.BouttonCercle();
            this.Button19 = new Projet_GONLO.BouttonCercle();
            this.Button18 = new Projet_GONLO.BouttonCercle();
            this.Button17 = new Projet_GONLO.BouttonCercle();
            this.Button16 = new Projet_GONLO.BouttonCercle();
            this.Button15 = new Projet_GONLO.BouttonCercle();
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
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1440, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "MnDejarik";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.filesToolStripMenuItem.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filesToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.saveToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.BackgroundImage")));
            this.saveToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.restartToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("restartToolStripMenuItem.BackgroundImage")));
            this.restartToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.restartToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.RestartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.exitToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.BackgroundImage")));
            this.exitToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // Button1
            // 
            this.Button1.AutoEllipsis = true;
            this.Button1.BackColor = System.Drawing.Color.Transparent;
            this.Button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button1.BackgroundImage")));
            this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Location = new System.Drawing.Point(395, 400);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(81, 90);
            this.Button1.TabIndex = 30;
            this.Button1.UseVisualStyleBackColor = false;
            // 
            // Button13
            // 
            this.Button13.AutoEllipsis = true;
            this.Button13.BackColor = System.Drawing.Color.Transparent;
            this.Button13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button13.BackgroundImage")));
            this.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button13.FlatAppearance.BorderSize = 0;
            this.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button13.Location = new System.Drawing.Point(264, 274);
            this.Button13.Name = "Button13";
            this.Button13.Size = new System.Drawing.Size(81, 90);
            this.Button13.TabIndex = 29;
            this.Button13.UseVisualStyleBackColor = false;
            // 
            // Button12
            // 
            this.Button12.AutoEllipsis = true;
            this.Button12.BackColor = System.Drawing.Color.Transparent;
            this.Button12.FlatAppearance.BorderSize = 0;
            this.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button12.Location = new System.Drawing.Point(218, 358);
            this.Button12.Name = "Button12";
            this.Button12.Size = new System.Drawing.Size(81, 90);
            this.Button12.TabIndex = 28;
            this.Button12.UseVisualStyleBackColor = false;
            // 
            // Button11
            // 
            this.Button11.AutoEllipsis = true;
            this.Button11.BackColor = System.Drawing.Color.Transparent;
            this.Button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button11.BackgroundImage")));
            this.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button11.FlatAppearance.BorderSize = 0;
            this.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button11.Location = new System.Drawing.Point(218, 454);
            this.Button11.Name = "Button11";
            this.Button11.Size = new System.Drawing.Size(81, 90);
            this.Button11.TabIndex = 27;
            this.Button11.UseVisualStyleBackColor = false;
            // 
            // Button10
            // 
            this.Button10.AutoEllipsis = true;
            this.Button10.BackColor = System.Drawing.Color.Transparent;
            this.Button10.FlatAppearance.BorderSize = 0;
            this.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button10.Location = new System.Drawing.Point(264, 533);
            this.Button10.Name = "Button10";
            this.Button10.Size = new System.Drawing.Size(81, 90);
            this.Button10.TabIndex = 26;
            this.Button10.UseVisualStyleBackColor = false;
            // 
            // Button9
            // 
            this.Button9.AutoEllipsis = true;
            this.Button9.BackColor = System.Drawing.Color.Transparent;
            this.Button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button9.BackgroundImage")));
            this.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button9.FlatAppearance.BorderSize = 0;
            this.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button9.Location = new System.Drawing.Point(351, 577);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(81, 90);
            this.Button9.TabIndex = 25;
            this.Button9.UseVisualStyleBackColor = false;
            // 
            // Button8
            // 
            this.Button8.AutoEllipsis = true;
            this.Button8.BackColor = System.Drawing.Color.Transparent;
            this.Button8.FlatAppearance.BorderSize = 0;
            this.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button8.Location = new System.Drawing.Point(438, 577);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(81, 90);
            this.Button8.TabIndex = 24;
            this.Button8.UseVisualStyleBackColor = false;
            // 
            // Button7
            // 
            this.Button7.AutoEllipsis = true;
            this.Button7.BackColor = System.Drawing.Color.Transparent;
            this.Button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button7.BackgroundImage")));
            this.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button7.FlatAppearance.BorderSize = 0;
            this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button7.Location = new System.Drawing.Point(525, 533);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(81, 90);
            this.Button7.TabIndex = 23;
            this.Button7.UseVisualStyleBackColor = false;
            // 
            // Button6
            // 
            this.Button6.AutoEllipsis = true;
            this.Button6.BackColor = System.Drawing.Color.Transparent;
            this.Button6.FlatAppearance.BorderSize = 0;
            this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button6.Location = new System.Drawing.Point(573, 454);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(81, 90);
            this.Button6.TabIndex = 22;
            this.Button6.UseVisualStyleBackColor = false;
            // 
            // Button5
            // 
            this.Button5.AutoEllipsis = true;
            this.Button5.BackColor = System.Drawing.Color.Transparent;
            this.Button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button5.BackgroundImage")));
            this.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button5.FlatAppearance.BorderSize = 0;
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.Location = new System.Drawing.Point(573, 358);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(81, 90);
            this.Button5.TabIndex = 21;
            this.Button5.UseVisualStyleBackColor = false;
            // 
            // Button4
            // 
            this.Button4.AutoEllipsis = true;
            this.Button4.BackColor = System.Drawing.Color.Transparent;
            this.Button4.FlatAppearance.BorderSize = 0;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button4.Location = new System.Drawing.Point(525, 274);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(81, 90);
            this.Button4.TabIndex = 20;
            this.Button4.UseVisualStyleBackColor = false;
            // 
            // Button3
            // 
            this.Button3.AutoEllipsis = true;
            this.Button3.BackColor = System.Drawing.Color.Transparent;
            this.Button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button3.BackgroundImage")));
            this.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button3.FlatAppearance.BorderSize = 0;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Location = new System.Drawing.Point(438, 233);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(81, 90);
            this.Button3.TabIndex = 19;
            this.Button3.UseVisualStyleBackColor = false;
            // 
            // Button2
            // 
            this.Button2.AutoEllipsis = true;
            this.Button2.BackColor = System.Drawing.Color.Transparent;
            this.Button2.FlatAppearance.BorderSize = 0;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Location = new System.Drawing.Point(351, 233);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(81, 90);
            this.Button2.TabIndex = 18;
            this.Button2.UseVisualStyleBackColor = false;
            // 
            // Button14
            // 
            this.Button14.AutoEllipsis = true;
            this.Button14.BackColor = System.Drawing.Color.Transparent;
            this.Button14.FlatAppearance.BorderSize = 0;
            this.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button14.Location = new System.Drawing.Point(170, 177);
            this.Button14.Name = "Button14";
            this.Button14.Size = new System.Drawing.Size(81, 90);
            this.Button14.TabIndex = 17;
            this.Button14.UseVisualStyleBackColor = false;
            // 
            // Button25
            // 
            this.Button25.AutoEllipsis = true;
            this.Button25.BackColor = System.Drawing.Color.Transparent;
            this.Button25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button25.BackgroundImage")));
            this.Button25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button25.FlatAppearance.BorderSize = 0;
            this.Button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button25.Location = new System.Drawing.Point(92, 325);
            this.Button25.Name = "Button25";
            this.Button25.Size = new System.Drawing.Size(81, 90);
            this.Button25.TabIndex = 16;
            this.Button25.UseVisualStyleBackColor = false;
            // 
            // Button24
            // 
            this.Button24.AutoEllipsis = true;
            this.Button24.BackColor = System.Drawing.Color.Transparent;
            this.Button24.FlatAppearance.BorderSize = 0;
            this.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button24.Location = new System.Drawing.Point(92, 486);
            this.Button24.Name = "Button24";
            this.Button24.Size = new System.Drawing.Size(81, 90);
            this.Button24.TabIndex = 15;
            this.Button24.UseVisualStyleBackColor = false;
            // 
            // Button23
            // 
            this.Button23.AutoEllipsis = true;
            this.Button23.BackColor = System.Drawing.Color.Transparent;
            this.Button23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button23.BackgroundImage")));
            this.Button23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button23.FlatAppearance.BorderSize = 0;
            this.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button23.Location = new System.Drawing.Point(170, 628);
            this.Button23.Name = "Button23";
            this.Button23.Size = new System.Drawing.Size(81, 90);
            this.Button23.TabIndex = 14;
            this.Button23.UseVisualStyleBackColor = false;
            // 
            // Button22
            // 
            this.Button22.AutoEllipsis = true;
            this.Button22.BackColor = System.Drawing.Color.Transparent;
            this.Button22.FlatAppearance.BorderSize = 0;
            this.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button22.Location = new System.Drawing.Point(318, 713);
            this.Button22.Name = "Button22";
            this.Button22.Size = new System.Drawing.Size(81, 90);
            this.Button22.TabIndex = 13;
            this.Button22.UseVisualStyleBackColor = false;
            // 
            // Button21
            // 
            this.Button21.AutoEllipsis = true;
            this.Button21.BackColor = System.Drawing.Color.Transparent;
            this.Button21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button21.BackgroundImage")));
            this.Button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button21.FlatAppearance.BorderSize = 0;
            this.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button21.Location = new System.Drawing.Point(472, 713);
            this.Button21.Name = "Button21";
            this.Button21.Size = new System.Drawing.Size(81, 90);
            this.Button21.TabIndex = 12;
            this.Button21.UseVisualStyleBackColor = false;
            // 
            // Button20
            // 
            this.Button20.AutoEllipsis = true;
            this.Button20.BackColor = System.Drawing.Color.Transparent;
            this.Button20.FlatAppearance.BorderSize = 0;
            this.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button20.Location = new System.Drawing.Point(612, 628);
            this.Button20.Name = "Button20";
            this.Button20.Size = new System.Drawing.Size(81, 90);
            this.Button20.TabIndex = 11;
            this.Button20.UseVisualStyleBackColor = false;
            // 
            // Button19
            // 
            this.Button19.AutoEllipsis = true;
            this.Button19.BackColor = System.Drawing.Color.Transparent;
            this.Button19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button19.BackgroundImage")));
            this.Button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button19.FlatAppearance.BorderSize = 0;
            this.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button19.Location = new System.Drawing.Point(698, 486);
            this.Button19.Name = "Button19";
            this.Button19.Size = new System.Drawing.Size(81, 90);
            this.Button19.TabIndex = 10;
            this.Button19.UseVisualStyleBackColor = false;
            // 
            // Button18
            // 
            this.Button18.AutoEllipsis = true;
            this.Button18.BackColor = System.Drawing.Color.Transparent;
            this.Button18.FlatAppearance.BorderSize = 0;
            this.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button18.Location = new System.Drawing.Point(698, 325);
            this.Button18.Name = "Button18";
            this.Button18.Size = new System.Drawing.Size(81, 90);
            this.Button18.TabIndex = 9;
            this.Button18.UseVisualStyleBackColor = false;
            // 
            // Button17
            // 
            this.Button17.AutoEllipsis = true;
            this.Button17.BackColor = System.Drawing.Color.Transparent;
            this.Button17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button17.BackgroundImage")));
            this.Button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button17.FlatAppearance.BorderSize = 0;
            this.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button17.Location = new System.Drawing.Point(612, 177);
            this.Button17.Name = "Button17";
            this.Button17.Size = new System.Drawing.Size(81, 90);
            this.Button17.TabIndex = 8;
            this.Button17.UseVisualStyleBackColor = false;
            // 
            // Button16
            // 
            this.Button16.AutoEllipsis = true;
            this.Button16.BackColor = System.Drawing.Color.Transparent;
            this.Button16.FlatAppearance.BorderSize = 0;
            this.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button16.Location = new System.Drawing.Point(472, 108);
            this.Button16.Name = "Button16";
            this.Button16.Size = new System.Drawing.Size(81, 90);
            this.Button16.TabIndex = 7;
            this.Button16.UseVisualStyleBackColor = false;
            // 
            // Button15
            // 
            this.Button15.AutoEllipsis = true;
            this.Button15.BackColor = System.Drawing.Color.Transparent;
            this.Button15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button15.BackgroundImage")));
            this.Button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button15.FlatAppearance.BorderSize = 0;
            this.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button15.Location = new System.Drawing.Point(318, 108);
            this.Button15.Name = "Button15";
            this.Button15.Size = new System.Drawing.Size(81, 90);
            this.Button15.TabIndex = 6;
            this.Button15.UseVisualStyleBackColor = false;
            // 
            // Dejarik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projet_GONLO.Properties.Resources.StarsBackground;
            this.ClientSize = new System.Drawing.Size(1440, 876);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button10);
            this.Controls.Add(this.Button11);
            this.Controls.Add(this.Button12);
            this.Controls.Add(this.Button13);
            this.Controls.Add(this.Button14);
            this.Controls.Add(this.Button15);
            this.Controls.Add(this.Button16);
            this.Controls.Add(this.Button17);
            this.Controls.Add(this.Button18);
            this.Controls.Add(this.Button19);
            this.Controls.Add(this.Button20);
            this.Controls.Add(this.Button21);
            this.Controls.Add(this.Button22);
            this.Controls.Add(this.Button23);
            this.Controls.Add(this.Button24);
            this.Controls.Add(this.Button25);
            this.Controls.Add(this.GbDice);
            this.Controls.Add(this.GbLog);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private RoundPanel PnlDice;
        private System.Windows.Forms.Panel PnlDe;
        private BouttonCercle Button15;
        private BouttonCercle Button16;
        private BouttonCercle Button17;
        private BouttonCercle Button18;
        private BouttonCercle Button19;
        private BouttonCercle Button20;
        private BouttonCercle Button21;
        private BouttonCercle Button22;
        private BouttonCercle Button23;
        private BouttonCercle Button24;
        private BouttonCercle Button25;
        private BouttonCercle Button14;
        private BouttonCercle Button2;
        private BouttonCercle Button3;
        private BouttonCercle Button4;
        private BouttonCercle Button5;
        private BouttonCercle Button6;
        private BouttonCercle Button7;
        private BouttonCercle Button8;
        private BouttonCercle Button9;
        private BouttonCercle Button10;
        private BouttonCercle Button11;
        private BouttonCercle Button12;
        private BouttonCercle Button13;
        private BouttonCercle Button1;
    }
}