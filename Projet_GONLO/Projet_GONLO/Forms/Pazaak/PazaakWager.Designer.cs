namespace Projet_GONLO
{
    partial class PazaakWager
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
            this.label1 = new System.Windows.Forms.Label();
            this.MTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.BtnEllBack = new Projet_GONLO.ButtonEllipse();
            this.BtnEllNext = new Projet_GONLO.ButtonEllipse();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "How much do you want to wager";
            // 
            // MTxtBox
            // 
            this.MTxtBox.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxtBox.Location = new System.Drawing.Point(248, 106);
            this.MTxtBox.Mask = "99999";
            this.MTxtBox.Name = "MTxtBox";
            this.MTxtBox.Size = new System.Drawing.Size(100, 26);
            this.MTxtBox.TabIndex = 1;
            this.MTxtBox.ValidatingType = typeof(int);
            this.MTxtBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MTxtBox_MaskInputRejected);
            this.MTxtBox.TextChanged += new System.EventHandler(this.MTxtBox_TextChanged);
            // 
            // BtnEllBack
            // 
            this.BtnEllBack.BackColor = System.Drawing.Color.Transparent;
            this.BtnEllBack.BackgroundImage = global::Projet_GONLO.Properties.Resources.BlueSteelFaded2;
            this.BtnEllBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEllBack.FlatAppearance.BorderSize = 0;
            this.BtnEllBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEllBack.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEllBack.ForeColor = System.Drawing.Color.LimeGreen;
            this.BtnEllBack.Location = new System.Drawing.Point(54, 145);
            this.BtnEllBack.Name = "BtnEllBack";
            this.BtnEllBack.Size = new System.Drawing.Size(150, 65);
            this.BtnEllBack.TabIndex = 2;
            this.BtnEllBack.Text = "Back";
            this.BtnEllBack.UseVisualStyleBackColor = false;
            this.BtnEllBack.Click += new System.EventHandler(this.BtnEllBack_Click);
            // 
            // BtnEllNext
            // 
            this.BtnEllNext.BackColor = System.Drawing.Color.Transparent;
            this.BtnEllNext.BackgroundImage = global::Projet_GONLO.Properties.Resources.BlueSteelFaded2;
            this.BtnEllNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEllNext.FlatAppearance.BorderSize = 0;
            this.BtnEllNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEllNext.Font = new System.Drawing.Font("SF Distant Galaxy Alternate", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEllNext.ForeColor = System.Drawing.Color.LimeGreen;
            this.BtnEllNext.Location = new System.Drawing.Point(387, 145);
            this.BtnEllNext.Name = "BtnEllNext";
            this.BtnEllNext.Size = new System.Drawing.Size(150, 65);
            this.BtnEllNext.TabIndex = 3;
            this.BtnEllNext.Text = "Next";
            this.BtnEllNext.UseVisualStyleBackColor = false;
            this.BtnEllNext.Click += new System.EventHandler(this.BtnEllNext_Click);
            // 
            // PazaakWager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projet_GONLO.Properties.Resources.StarsBackground1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 250);
            this.Controls.Add(this.BtnEllNext);
            this.Controls.Add(this.BtnEllBack);
            this.Controls.Add(this.MTxtBox);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PazaakWager";
            this.Text = "PazaakWager";
            this.Load += new System.EventHandler(this.PazaakWager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MTxtBox;
        private ButtonEllipse BtnEllBack;
        private ButtonEllipse BtnEllNext;
    }
}