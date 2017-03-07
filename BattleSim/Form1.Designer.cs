namespace BattleSim
{
    partial class Form1
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
            this.btnKnight = new System.Windows.Forms.Button();
            this.btnWizard = new System.Windows.Forms.Button();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.gbPlayer1 = new System.Windows.Forms.GroupBox();
            this.gbPlayer2 = new System.Windows.Forms.GroupBox();
            this.lblHitpoints1 = new System.Windows.Forms.Label();
            this.lblHitpoints2 = new System.Windows.Forms.Label();
            this.btnAttack1 = new System.Windows.Forms.Button();
            this.btnAttack2 = new System.Windows.Forms.Button();
            this.gbPlayer1.SuspendLayout();
            this.gbPlayer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKnight
            // 
            this.btnKnight.Location = new System.Drawing.Point(12, 47);
            this.btnKnight.Name = "btnKnight";
            this.btnKnight.Size = new System.Drawing.Size(249, 26);
            this.btnKnight.TabIndex = 0;
            this.btnKnight.Text = "Knight";
            this.btnKnight.UseVisualStyleBackColor = true;
            this.btnKnight.Click += new System.EventHandler(this.btnKnight_Click);
            // 
            // btnWizard
            // 
            this.btnWizard.Location = new System.Drawing.Point(267, 47);
            this.btnWizard.Name = "btnWizard";
            this.btnWizard.Size = new System.Drawing.Size(255, 26);
            this.btnWizard.TabIndex = 1;
            this.btnWizard.Text = "Wizard";
            this.btnWizard.UseVisualStyleBackColor = true;
            this.btnWizard.Click += new System.EventHandler(this.btnWizard_Click);
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(13, 13);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(60, 17);
            this.lblPlayer.TabIndex = 2;
            this.lblPlayer.Text = "Player 1";
            // 
            // gbPlayer1
            // 
            this.gbPlayer1.Controls.Add(this.btnAttack1);
            this.gbPlayer1.Controls.Add(this.lblHitpoints1);
            this.gbPlayer1.Location = new System.Drawing.Point(16, 79);
            this.gbPlayer1.Name = "gbPlayer1";
            this.gbPlayer1.Size = new System.Drawing.Size(245, 314);
            this.gbPlayer1.TabIndex = 3;
            this.gbPlayer1.TabStop = false;
            this.gbPlayer1.Text = "Player 1";
            this.gbPlayer1.Visible = false;
            // 
            // gbPlayer2
            // 
            this.gbPlayer2.Controls.Add(this.btnAttack2);
            this.gbPlayer2.Controls.Add(this.lblHitpoints2);
            this.gbPlayer2.Location = new System.Drawing.Point(267, 79);
            this.gbPlayer2.Name = "gbPlayer2";
            this.gbPlayer2.Size = new System.Drawing.Size(255, 314);
            this.gbPlayer2.TabIndex = 0;
            this.gbPlayer2.TabStop = false;
            this.gbPlayer2.Text = "Player 2";
            this.gbPlayer2.Visible = false;
            // 
            // lblHitpoints1
            // 
            this.lblHitpoints1.AutoSize = true;
            this.lblHitpoints1.Location = new System.Drawing.Point(7, 22);
            this.lblHitpoints1.Name = "lblHitpoints1";
            this.lblHitpoints1.Size = new System.Drawing.Size(71, 17);
            this.lblHitpoints1.TabIndex = 0;
            this.lblHitpoints1.Text = "Hitpoints: ";
            // 
            // lblHitpoints2
            // 
            this.lblHitpoints2.AutoSize = true;
            this.lblHitpoints2.Location = new System.Drawing.Point(6, 22);
            this.lblHitpoints2.Name = "lblHitpoints2";
            this.lblHitpoints2.Size = new System.Drawing.Size(71, 17);
            this.lblHitpoints2.TabIndex = 1;
            this.lblHitpoints2.Text = "Hitpoints: ";
            // 
            // btnAttack1
            // 
            this.btnAttack1.Location = new System.Drawing.Point(10, 43);
            this.btnAttack1.Name = "btnAttack1";
            this.btnAttack1.Size = new System.Drawing.Size(86, 37);
            this.btnAttack1.TabIndex = 1;
            this.btnAttack1.Text = "Aanvallen";
            this.btnAttack1.UseVisualStyleBackColor = true;
            this.btnAttack1.Click += new System.EventHandler(this.btnAttack1_Click);
            // 
            // btnAttack2
            // 
            this.btnAttack2.Location = new System.Drawing.Point(9, 43);
            this.btnAttack2.Name = "btnAttack2";
            this.btnAttack2.Size = new System.Drawing.Size(89, 37);
            this.btnAttack2.TabIndex = 2;
            this.btnAttack2.Text = "Aanvallen";
            this.btnAttack2.UseVisualStyleBackColor = true;
            this.btnAttack2.Click += new System.EventHandler(this.btnAttack2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 405);
            this.Controls.Add(this.gbPlayer2);
            this.Controls.Add(this.gbPlayer1);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.btnWizard);
            this.Controls.Add(this.btnKnight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbPlayer1.ResumeLayout(false);
            this.gbPlayer1.PerformLayout();
            this.gbPlayer2.ResumeLayout(false);
            this.gbPlayer2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKnight;
        private System.Windows.Forms.Button btnWizard;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.GroupBox gbPlayer1;
        private System.Windows.Forms.GroupBox gbPlayer2;
        private System.Windows.Forms.Label lblHitpoints1;
        private System.Windows.Forms.Label lblHitpoints2;
        private System.Windows.Forms.Button btnAttack1;
        private System.Windows.Forms.Button btnAttack2;
    }
}