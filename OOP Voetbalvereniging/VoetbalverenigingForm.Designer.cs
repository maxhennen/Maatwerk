namespace OOP_Voetbalvereniging
{
    partial class VoetbalverenigingForm
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
            this.gbTeams = new System.Windows.Forms.GroupBox();
            this.lbTeams = new System.Windows.Forms.ListBox();
            this.tbNieuwTeam = new System.Windows.Forms.TextBox();
            this.lblNieuwTeam = new System.Windows.Forms.Label();
            this.lblPersistentie = new System.Windows.Forms.Label();
            this.lblGeselecteerdTeam = new System.Windows.Forms.Label();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.btnToonWedstrijden = new System.Windows.Forms.Button();
            this.btnTeamAanmaken = new System.Windows.Forms.Button();
            this.btnTeamVerwijderen = new System.Windows.Forms.Button();
            this.btnLaden = new System.Windows.Forms.Button();
            this.gbWedstrijdenTeam = new System.Windows.Forms.GroupBox();
            this.lbWedstrijdenTeam = new System.Windows.Forms.ListBox();
            this.gbNieuweWedstrijd = new System.Windows.Forms.GroupBox();
            this.btnWedstrijdAanmaken = new System.Windows.Forms.Button();
            this.chbOefenwedstrijd = new System.Windows.Forms.CheckBox();
            this.tbScheidsrechter = new System.Windows.Forms.TextBox();
            this.lblScheidsrechter = new System.Windows.Forms.Label();
            this.lblStreepjeTussenDoelpunten = new System.Windows.Forms.Label();
            this.nuDoelpuntenThuis = new System.Windows.Forms.NumericUpDown();
            this.lblUit = new System.Windows.Forms.Label();
            this.lblThuis = new System.Windows.Forms.Label();
            this.nuDoelpuntenUit = new System.Windows.Forms.NumericUpDown();
            this.cbUit = new System.Windows.Forms.ComboBox();
            this.cbThuis = new System.Windows.Forms.ComboBox();
            this.gbTeams.SuspendLayout();
            this.gbWedstrijdenTeam.SuspendLayout();
            this.gbNieuweWedstrijd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuDoelpuntenThuis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDoelpuntenUit)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTeams
            // 
            this.gbTeams.Controls.Add(this.lbTeams);
            this.gbTeams.Controls.Add(this.tbNieuwTeam);
            this.gbTeams.Controls.Add(this.lblNieuwTeam);
            this.gbTeams.Controls.Add(this.lblPersistentie);
            this.gbTeams.Controls.Add(this.lblGeselecteerdTeam);
            this.gbTeams.Controls.Add(this.btnOpslaan);
            this.gbTeams.Controls.Add(this.btnToonWedstrijden);
            this.gbTeams.Controls.Add(this.btnTeamAanmaken);
            this.gbTeams.Controls.Add(this.btnTeamVerwijderen);
            this.gbTeams.Controls.Add(this.btnLaden);
            this.gbTeams.Location = new System.Drawing.Point(12, 12);
            this.gbTeams.Name = "gbTeams";
            this.gbTeams.Size = new System.Drawing.Size(328, 496);
            this.gbTeams.TabIndex = 0;
            this.gbTeams.TabStop = false;
            this.gbTeams.Text = "Teams";
            // 
            // lbTeams
            // 
            this.lbTeams.FormattingEnabled = true;
            this.lbTeams.ItemHeight = 16;
            this.lbTeams.Location = new System.Drawing.Point(11, 21);
            this.lbTeams.Name = "lbTeams";
            this.lbTeams.Size = new System.Drawing.Size(311, 340);
            this.lbTeams.TabIndex = 9;
            // 
            // tbNieuwTeam
            // 
            this.tbNieuwTeam.Location = new System.Drawing.Point(6, 393);
            this.tbNieuwTeam.Name = "tbNieuwTeam";
            this.tbNieuwTeam.Size = new System.Drawing.Size(100, 22);
            this.tbNieuwTeam.TabIndex = 8;
            // 
            // lblNieuwTeam
            // 
            this.lblNieuwTeam.AutoSize = true;
            this.lblNieuwTeam.Location = new System.Drawing.Point(6, 373);
            this.lblNieuwTeam.Name = "lblNieuwTeam";
            this.lblNieuwTeam.Size = new System.Drawing.Size(90, 17);
            this.lblNieuwTeam.TabIndex = 7;
            this.lblNieuwTeam.Text = "Nieuw Team:";
            // 
            // lblPersistentie
            // 
            this.lblPersistentie.AutoSize = true;
            this.lblPersistentie.Location = new System.Drawing.Point(8, 447);
            this.lblPersistentie.Name = "lblPersistentie";
            this.lblPersistentie.Size = new System.Drawing.Size(82, 17);
            this.lblPersistentie.TabIndex = 6;
            this.lblPersistentie.Text = "Persistentie";
            // 
            // lblGeselecteerdTeam
            // 
            this.lblGeselecteerdTeam.AutoSize = true;
            this.lblGeselecteerdTeam.Location = new System.Drawing.Point(109, 373);
            this.lblGeselecteerdTeam.Name = "lblGeselecteerdTeam";
            this.lblGeselecteerdTeam.Size = new System.Drawing.Size(137, 17);
            this.lblGeselecteerdTeam.TabIndex = 5;
            this.lblGeselecteerdTeam.Text = "Geselecteerd Team:";
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(6, 467);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(75, 23);
            this.btnOpslaan.TabIndex = 4;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // btnToonWedstrijden
            // 
            this.btnToonWedstrijden.Location = new System.Drawing.Point(112, 393);
            this.btnToonWedstrijden.Name = "btnToonWedstrijden";
            this.btnToonWedstrijden.Size = new System.Drawing.Size(134, 23);
            this.btnToonWedstrijden.TabIndex = 3;
            this.btnToonWedstrijden.Text = "Toon wedstrijden";
            this.btnToonWedstrijden.UseVisualStyleBackColor = true;
            this.btnToonWedstrijden.Click += new System.EventHandler(this.btnToonWedstrijden_Click);
            // 
            // btnTeamAanmaken
            // 
            this.btnTeamAanmaken.Location = new System.Drawing.Point(6, 421);
            this.btnTeamAanmaken.Name = "btnTeamAanmaken";
            this.btnTeamAanmaken.Size = new System.Drawing.Size(90, 23);
            this.btnTeamAanmaken.TabIndex = 2;
            this.btnTeamAanmaken.Text = "Aanmaken";
            this.btnTeamAanmaken.UseVisualStyleBackColor = true;
            this.btnTeamAanmaken.Click += new System.EventHandler(this.btnTeamAanmaken_Click);
            // 
            // btnTeamVerwijderen
            // 
            this.btnTeamVerwijderen.Location = new System.Drawing.Point(112, 422);
            this.btnTeamVerwijderen.Name = "btnTeamVerwijderen";
            this.btnTeamVerwijderen.Size = new System.Drawing.Size(134, 23);
            this.btnTeamVerwijderen.TabIndex = 1;
            this.btnTeamVerwijderen.Text = "Team Verwijderen";
            this.btnTeamVerwijderen.UseVisualStyleBackColor = true;
            this.btnTeamVerwijderen.Click += new System.EventHandler(this.btnTeamVerwijderen_Click);
            // 
            // btnLaden
            // 
            this.btnLaden.Location = new System.Drawing.Point(112, 467);
            this.btnLaden.Name = "btnLaden";
            this.btnLaden.Size = new System.Drawing.Size(75, 23);
            this.btnLaden.TabIndex = 0;
            this.btnLaden.Text = "Laden";
            this.btnLaden.UseVisualStyleBackColor = true;
            this.btnLaden.Click += new System.EventHandler(this.btnLaden_Click);
            // 
            // gbWedstrijdenTeam
            // 
            this.gbWedstrijdenTeam.Controls.Add(this.lbWedstrijdenTeam);
            this.gbWedstrijdenTeam.Location = new System.Drawing.Point(346, 12);
            this.gbWedstrijdenTeam.Name = "gbWedstrijdenTeam";
            this.gbWedstrijdenTeam.Size = new System.Drawing.Size(348, 287);
            this.gbWedstrijdenTeam.TabIndex = 10;
            this.gbWedstrijdenTeam.TabStop = false;
            this.gbWedstrijdenTeam.Text = "Wedstrijden van Team";
            // 
            // lbWedstrijdenTeam
            // 
            this.lbWedstrijdenTeam.FormattingEnabled = true;
            this.lbWedstrijdenTeam.ItemHeight = 16;
            this.lbWedstrijdenTeam.Location = new System.Drawing.Point(6, 21);
            this.lbWedstrijdenTeam.Name = "lbWedstrijdenTeam";
            this.lbWedstrijdenTeam.Size = new System.Drawing.Size(336, 260);
            this.lbWedstrijdenTeam.TabIndex = 0;
            // 
            // gbNieuweWedstrijd
            // 
            this.gbNieuweWedstrijd.Controls.Add(this.btnWedstrijdAanmaken);
            this.gbNieuweWedstrijd.Controls.Add(this.chbOefenwedstrijd);
            this.gbNieuweWedstrijd.Controls.Add(this.tbScheidsrechter);
            this.gbNieuweWedstrijd.Controls.Add(this.lblScheidsrechter);
            this.gbNieuweWedstrijd.Controls.Add(this.lblStreepjeTussenDoelpunten);
            this.gbNieuweWedstrijd.Controls.Add(this.nuDoelpuntenThuis);
            this.gbNieuweWedstrijd.Controls.Add(this.lblUit);
            this.gbNieuweWedstrijd.Controls.Add(this.lblThuis);
            this.gbNieuweWedstrijd.Controls.Add(this.nuDoelpuntenUit);
            this.gbNieuweWedstrijd.Controls.Add(this.cbUit);
            this.gbNieuweWedstrijd.Controls.Add(this.cbThuis);
            this.gbNieuweWedstrijd.Location = new System.Drawing.Point(346, 305);
            this.gbNieuweWedstrijd.Name = "gbNieuweWedstrijd";
            this.gbNieuweWedstrijd.Size = new System.Drawing.Size(348, 203);
            this.gbNieuweWedstrijd.TabIndex = 1;
            this.gbNieuweWedstrijd.TabStop = false;
            this.gbNieuweWedstrijd.Text = "Nieuwe Wedstrijd";
            // 
            // btnWedstrijdAanmaken
            // 
            this.btnWedstrijdAanmaken.Location = new System.Drawing.Point(6, 154);
            this.btnWedstrijdAanmaken.Name = "btnWedstrijdAanmaken";
            this.btnWedstrijdAanmaken.Size = new System.Drawing.Size(336, 43);
            this.btnWedstrijdAanmaken.TabIndex = 10;
            this.btnWedstrijdAanmaken.Text = "Aanmaken";
            this.btnWedstrijdAanmaken.UseVisualStyleBackColor = true;
            this.btnWedstrijdAanmaken.Click += new System.EventHandler(this.btnWedstrijdAanmaken_Click);
            // 
            // chbOefenwedstrijd
            // 
            this.chbOefenwedstrijd.AutoSize = true;
            this.chbOefenwedstrijd.Location = new System.Drawing.Point(133, 126);
            this.chbOefenwedstrijd.Name = "chbOefenwedstrijd";
            this.chbOefenwedstrijd.Size = new System.Drawing.Size(124, 21);
            this.chbOefenwedstrijd.TabIndex = 9;
            this.chbOefenwedstrijd.Text = "Oefenwedstrijd";
            this.chbOefenwedstrijd.UseVisualStyleBackColor = true;
            // 
            // tbScheidsrechter
            // 
            this.tbScheidsrechter.Location = new System.Drawing.Point(9, 126);
            this.tbScheidsrechter.Name = "tbScheidsrechter";
            this.tbScheidsrechter.Size = new System.Drawing.Size(100, 22);
            this.tbScheidsrechter.TabIndex = 8;
            // 
            // lblScheidsrechter
            // 
            this.lblScheidsrechter.AutoSize = true;
            this.lblScheidsrechter.Location = new System.Drawing.Point(6, 106);
            this.lblScheidsrechter.Name = "lblScheidsrechter";
            this.lblScheidsrechter.Size = new System.Drawing.Size(103, 17);
            this.lblScheidsrechter.TabIndex = 7;
            this.lblScheidsrechter.Text = "Scheidsrechter";
            // 
            // lblStreepjeTussenDoelpunten
            // 
            this.lblStreepjeTussenDoelpunten.AutoSize = true;
            this.lblStreepjeTussenDoelpunten.Location = new System.Drawing.Point(114, 85);
            this.lblStreepjeTussenDoelpunten.Name = "lblStreepjeTussenDoelpunten";
            this.lblStreepjeTussenDoelpunten.Size = new System.Drawing.Size(13, 17);
            this.lblStreepjeTussenDoelpunten.TabIndex = 6;
            this.lblStreepjeTussenDoelpunten.Text = "-";
            // 
            // nuDoelpuntenThuis
            // 
            this.nuDoelpuntenThuis.Location = new System.Drawing.Point(44, 80);
            this.nuDoelpuntenThuis.Name = "nuDoelpuntenThuis";
            this.nuDoelpuntenThuis.Size = new System.Drawing.Size(37, 22);
            this.nuDoelpuntenThuis.TabIndex = 5;
            // 
            // lblUit
            // 
            this.lblUit.AutoSize = true;
            this.lblUit.Location = new System.Drawing.Point(133, 24);
            this.lblUit.Name = "lblUit";
            this.lblUit.Size = new System.Drawing.Size(33, 17);
            this.lblUit.TabIndex = 3;
            this.lblUit.Text = "Uit: ";
            // 
            // lblThuis
            // 
            this.lblThuis.AutoSize = true;
            this.lblThuis.Location = new System.Drawing.Point(6, 24);
            this.lblThuis.Name = "lblThuis";
            this.lblThuis.Size = new System.Drawing.Size(47, 17);
            this.lblThuis.TabIndex = 2;
            this.lblThuis.Text = "Thuis:";
            // 
            // nuDoelpuntenUit
            // 
            this.nuDoelpuntenUit.Location = new System.Drawing.Point(169, 80);
            this.nuDoelpuntenUit.Name = "nuDoelpuntenUit";
            this.nuDoelpuntenUit.Size = new System.Drawing.Size(45, 22);
            this.nuDoelpuntenUit.TabIndex = 4;
            // 
            // cbUit
            // 
            this.cbUit.FormattingEnabled = true;
            this.cbUit.Location = new System.Drawing.Point(133, 44);
            this.cbUit.Name = "cbUit";
            this.cbUit.Size = new System.Drawing.Size(121, 24);
            this.cbUit.TabIndex = 1;
            // 
            // cbThuis
            // 
            this.cbThuis.FormattingEnabled = true;
            this.cbThuis.Location = new System.Drawing.Point(6, 44);
            this.cbThuis.Name = "cbThuis";
            this.cbThuis.Size = new System.Drawing.Size(121, 24);
            this.cbThuis.TabIndex = 0;
            // 
            // VoetbalverenigingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 520);
            this.Controls.Add(this.gbNieuweWedstrijd);
            this.Controls.Add(this.gbWedstrijdenTeam);
            this.Controls.Add(this.gbTeams);
            this.Name = "VoetbalverenigingForm";
            this.Text = "Form1";
            this.gbTeams.ResumeLayout(false);
            this.gbTeams.PerformLayout();
            this.gbWedstrijdenTeam.ResumeLayout(false);
            this.gbNieuweWedstrijd.ResumeLayout(false);
            this.gbNieuweWedstrijd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuDoelpuntenThuis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDoelpuntenUit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTeams;
        private System.Windows.Forms.ListBox lbTeams;
        private System.Windows.Forms.TextBox tbNieuwTeam;
        private System.Windows.Forms.Label lblNieuwTeam;
        private System.Windows.Forms.Label lblPersistentie;
        private System.Windows.Forms.Label lblGeselecteerdTeam;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Button btnToonWedstrijden;
        private System.Windows.Forms.Button btnTeamAanmaken;
        private System.Windows.Forms.Button btnTeamVerwijderen;
        private System.Windows.Forms.Button btnLaden;
        private System.Windows.Forms.GroupBox gbWedstrijdenTeam;
        private System.Windows.Forms.ListBox lbWedstrijdenTeam;
        private System.Windows.Forms.GroupBox gbNieuweWedstrijd;
        private System.Windows.Forms.Button btnWedstrijdAanmaken;
        private System.Windows.Forms.CheckBox chbOefenwedstrijd;
        private System.Windows.Forms.TextBox tbScheidsrechter;
        private System.Windows.Forms.Label lblScheidsrechter;
        private System.Windows.Forms.Label lblStreepjeTussenDoelpunten;
        private System.Windows.Forms.NumericUpDown nuDoelpuntenThuis;
        private System.Windows.Forms.Label lblUit;
        private System.Windows.Forms.Label lblThuis;
        private System.Windows.Forms.NumericUpDown nuDoelpuntenUit;
        private System.Windows.Forms.ComboBox cbUit;
        private System.Windows.Forms.ComboBox cbThuis;
    }
}

