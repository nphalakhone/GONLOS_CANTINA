namespace Projet_GONLO
{
    partial class MenuDejarik
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
            this.PnlChooseOptionDejarik = new System.Windows.Forms.Panel();
            this.BtnMulti = new System.Windows.Forms.Button();
            this.BtnSolo = new System.Windows.Forms.Button();
            this.PnlChooseMonster = new System.Windows.Forms.Panel();
            this.LblMenuPlayerTurn = new System.Windows.Forms.Label();
            this.BtnChooseAtk = new System.Windows.Forms.Button();
            this.BtnChooseDef = new System.Windows.Forms.Button();
            this.BtnChooseMov = new System.Windows.Forms.Button();
            this.BtnChoosePow = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.PnlChooseOptionDejarik.SuspendLayout();
            this.PnlChooseMonster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlChooseOptionDejarik
            // 
            this.PnlChooseOptionDejarik.BackColor = System.Drawing.Color.Transparent;
            this.PnlChooseOptionDejarik.Controls.Add(this.PnlChooseMonster);
            this.PnlChooseOptionDejarik.Controls.Add(this.BtnMulti);
            this.PnlChooseOptionDejarik.Controls.Add(this.BtnSolo);
            this.PnlChooseOptionDejarik.Location = new System.Drawing.Point(12, 12);
            this.PnlChooseOptionDejarik.Name = "PnlChooseOptionDejarik";
            this.PnlChooseOptionDejarik.Size = new System.Drawing.Size(1329, 506);
            this.PnlChooseOptionDejarik.TabIndex = 0;
            // 
            // BtnMulti
            // 
            this.BtnMulti.BackgroundImage = global::Projet_GONLO.Properties.Resources.backButtongold;
            this.BtnMulti.Font = new System.Drawing.Font("SF Distant Galaxy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMulti.Location = new System.Drawing.Point(412, 362);
            this.BtnMulti.Name = "BtnMulti";
            this.BtnMulti.Size = new System.Drawing.Size(300, 50);
            this.BtnMulti.TabIndex = 1;
            this.BtnMulti.Text = "Play Vs a Friend";
            this.BtnMulti.UseVisualStyleBackColor = true;
            // 
            // BtnSolo
            // 
            this.BtnSolo.BackColor = System.Drawing.Color.Transparent;
            this.BtnSolo.BackgroundImage = global::Projet_GONLO.Properties.Resources.backButtongold;
            this.BtnSolo.Font = new System.Drawing.Font("SF Distant Galaxy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSolo.Location = new System.Drawing.Point(412, 168);
            this.BtnSolo.Name = "BtnSolo";
            this.BtnSolo.Size = new System.Drawing.Size(300, 50);
            this.BtnSolo.TabIndex = 0;
            this.BtnSolo.Text = "Play VS a Computer";
            this.BtnSolo.UseVisualStyleBackColor = false;
            this.BtnSolo.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PnlChooseMonster
            // 
            this.PnlChooseMonster.BackColor = System.Drawing.Color.Transparent;
            this.PnlChooseMonster.Controls.Add(this.pictureBox7);
            this.PnlChooseMonster.Controls.Add(this.pictureBox8);
            this.PnlChooseMonster.Controls.Add(this.pictureBox5);
            this.PnlChooseMonster.Controls.Add(this.pictureBox6);
            this.PnlChooseMonster.Controls.Add(this.pictureBox3);
            this.PnlChooseMonster.Controls.Add(this.pictureBox4);
            this.PnlChooseMonster.Controls.Add(this.pictureBox2);
            this.PnlChooseMonster.Controls.Add(this.pictureBox1);
            this.PnlChooseMonster.Controls.Add(this.BtnChoosePow);
            this.PnlChooseMonster.Controls.Add(this.BtnChooseMov);
            this.PnlChooseMonster.Controls.Add(this.BtnChooseDef);
            this.PnlChooseMonster.Controls.Add(this.BtnChooseAtk);
            this.PnlChooseMonster.Controls.Add(this.LblMenuPlayerTurn);
            this.PnlChooseMonster.Location = new System.Drawing.Point(3, 0);
            this.PnlChooseMonster.Name = "PnlChooseMonster";
            this.PnlChooseMonster.Size = new System.Drawing.Size(1329, 506);
            this.PnlChooseMonster.TabIndex = 2;
            this.PnlChooseMonster.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // LblMenuPlayerTurn
            // 
            this.LblMenuPlayerTurn.AutoSize = true;
            this.LblMenuPlayerTurn.Font = new System.Drawing.Font("SF Distant Galaxy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMenuPlayerTurn.ForeColor = System.Drawing.Color.White;
            this.LblMenuPlayerTurn.Location = new System.Drawing.Point(490, 35);
            this.LblMenuPlayerTurn.Name = "LblMenuPlayerTurn";
            this.LblMenuPlayerTurn.Size = new System.Drawing.Size(395, 28);
            this.LblMenuPlayerTurn.TabIndex = 0;
            this.LblMenuPlayerTurn.Text = "Player 1\'s Turn to Pick";
            // 
            // BtnChooseAtk
            // 
            this.BtnChooseAtk.Font = new System.Drawing.Font("SF Distant Galaxy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChooseAtk.Location = new System.Drawing.Point(128, 188);
            this.BtnChooseAtk.Name = "BtnChooseAtk";
            this.BtnChooseAtk.Size = new System.Drawing.Size(150, 30);
            this.BtnChooseAtk.TabIndex = 1;
            this.BtnChooseAtk.Text = "Attack";
            this.BtnChooseAtk.UseVisualStyleBackColor = true;
            this.BtnChooseAtk.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // BtnChooseDef
            // 
            this.BtnChooseDef.Font = new System.Drawing.Font("SF Distant Galaxy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChooseDef.Location = new System.Drawing.Point(412, 188);
            this.BtnChooseDef.Name = "BtnChooseDef";
            this.BtnChooseDef.Size = new System.Drawing.Size(150, 30);
            this.BtnChooseDef.TabIndex = 2;
            this.BtnChooseDef.Text = "Defense";
            this.BtnChooseDef.UseVisualStyleBackColor = true;
            this.BtnChooseDef.Click += new System.EventHandler(this.Button2_Click);
            // 
            // BtnChooseMov
            // 
            this.BtnChooseMov.Font = new System.Drawing.Font("SF Distant Galaxy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChooseMov.Location = new System.Drawing.Point(735, 188);
            this.BtnChooseMov.Name = "BtnChooseMov";
            this.BtnChooseMov.Size = new System.Drawing.Size(150, 30);
            this.BtnChooseMov.TabIndex = 3;
            this.BtnChooseMov.Text = "Movement";
            this.BtnChooseMov.UseVisualStyleBackColor = true;
            // 
            // BtnChoosePow
            // 
            this.BtnChoosePow.Font = new System.Drawing.Font("SF Distant Galaxy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChoosePow.Location = new System.Drawing.Point(1064, 188);
            this.BtnChoosePow.Name = "BtnChoosePow";
            this.BtnChoosePow.Size = new System.Drawing.Size(150, 30);
            this.BtnChoosePow.TabIndex = 4;
            this.BtnChoosePow.Text = "Power";
            this.BtnChoosePow.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(71, 277);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 145);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(198, 277);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 145);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(495, 277);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(121, 145);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(368, 277);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(121, 145);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(805, 277);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(121, 145);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(678, 277);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(121, 145);
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(1139, 277);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(121, 145);
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(1012, 277);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(121, 145);
            this.pictureBox8.TabIndex = 11;
            this.pictureBox8.TabStop = false;
            // 
            // MenuDejarik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projet_GONLO.Properties.Resources.holochess_arkit;
            this.ClientSize = new System.Drawing.Size(1353, 530);
            this.Controls.Add(this.PnlChooseOptionDejarik);
            this.Name = "MenuDejarik";
            this.Text = "MenuDejarik";
            this.PnlChooseOptionDejarik.ResumeLayout(false);
            this.PnlChooseMonster.ResumeLayout(false);
            this.PnlChooseMonster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlChooseOptionDejarik;
        private System.Windows.Forms.Button BtnMulti;
        private System.Windows.Forms.Button BtnSolo;
        private System.Windows.Forms.Panel PnlChooseMonster;
        private System.Windows.Forms.Button BtnChooseAtk;
        private System.Windows.Forms.Label LblMenuPlayerTurn;
        private System.Windows.Forms.Button BtnChoosePow;
        private System.Windows.Forms.Button BtnChooseMov;
        private System.Windows.Forms.Button BtnChooseDef;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}