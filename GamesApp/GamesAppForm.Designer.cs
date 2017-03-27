namespace GamesApp
{
    partial class GamesAppForm
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
            this.gbGameToevoegen = new System.Windows.Forms.GroupBox();
            this.btnGameToevoegen = new System.Windows.Forms.Button();
            this.nUDPrijs = new System.Windows.Forms.NumericUpDown();
            this.tbTitel = new System.Windows.Forms.TextBox();
            this.lblPrijs = new System.Windows.Forms.Label();
            this.lblPlatform = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbGames = new System.Windows.Forms.ListBox();
            this.cbGenres = new System.Windows.Forms.ComboBox();
            this.cbPlatforms = new System.Windows.Forms.ComboBox();
            this.gbFilterGames = new System.Windows.Forms.GroupBox();
            this.clbFilterGames = new System.Windows.Forms.CheckedListBox();
            this.cbFilterPlatform = new System.Windows.Forms.ComboBox();
            this.cbFilterGenre = new System.Windows.Forms.ComboBox();
            this.BtnZoeken = new System.Windows.Forms.Button();
            this.gbGameToevoegen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPrijs)).BeginInit();
            this.gbFilterGames.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGameToevoegen
            // 
            this.gbGameToevoegen.Controls.Add(this.cbPlatforms);
            this.gbGameToevoegen.Controls.Add(this.cbGenres);
            this.gbGameToevoegen.Controls.Add(this.btnGameToevoegen);
            this.gbGameToevoegen.Controls.Add(this.nUDPrijs);
            this.gbGameToevoegen.Controls.Add(this.tbTitel);
            this.gbGameToevoegen.Controls.Add(this.lblPrijs);
            this.gbGameToevoegen.Controls.Add(this.lblPlatform);
            this.gbGameToevoegen.Controls.Add(this.lblGenre);
            this.gbGameToevoegen.Controls.Add(this.lblTitel);
            this.gbGameToevoegen.Location = new System.Drawing.Point(12, 12);
            this.gbGameToevoegen.Name = "gbGameToevoegen";
            this.gbGameToevoegen.Size = new System.Drawing.Size(345, 229);
            this.gbGameToevoegen.TabIndex = 0;
            this.gbGameToevoegen.TabStop = false;
            this.gbGameToevoegen.Text = "Game Toevoegen";
            // 
            // btnGameToevoegen
            // 
            this.btnGameToevoegen.Location = new System.Drawing.Point(98, 150);
            this.btnGameToevoegen.Name = "btnGameToevoegen";
            this.btnGameToevoegen.Size = new System.Drawing.Size(120, 47);
            this.btnGameToevoegen.TabIndex = 8;
            this.btnGameToevoegen.Text = "Game Toevoegen";
            this.btnGameToevoegen.UseVisualStyleBackColor = true;
            this.btnGameToevoegen.Click += new System.EventHandler(this.btnGameToevoegen_Click);
            // 
            // nUDPrijs
            // 
            this.nUDPrijs.DecimalPlaces = 2;
            this.nUDPrijs.Location = new System.Drawing.Point(98, 122);
            this.nUDPrijs.Name = "nUDPrijs";
            this.nUDPrijs.Size = new System.Drawing.Size(120, 22);
            this.nUDPrijs.TabIndex = 7;
            // 
            // tbTitel
            // 
            this.tbTitel.Location = new System.Drawing.Point(98, 38);
            this.tbTitel.Name = "tbTitel";
            this.tbTitel.Size = new System.Drawing.Size(120, 22);
            this.tbTitel.TabIndex = 6;
            // 
            // lblPrijs
            // 
            this.lblPrijs.AutoSize = true;
            this.lblPrijs.Location = new System.Drawing.Point(6, 124);
            this.lblPrijs.Name = "lblPrijs";
            this.lblPrijs.Size = new System.Drawing.Size(35, 17);
            this.lblPrijs.TabIndex = 3;
            this.lblPrijs.Text = "Prijs";
            // 
            // lblPlatform
            // 
            this.lblPlatform.AutoSize = true;
            this.lblPlatform.Location = new System.Drawing.Point(6, 97);
            this.lblPlatform.Name = "lblPlatform";
            this.lblPlatform.Size = new System.Drawing.Size(60, 17);
            this.lblPlatform.TabIndex = 2;
            this.lblPlatform.Text = "Platform";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(6, 69);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(48, 17);
            this.lblGenre.TabIndex = 1;
            this.lblGenre.Text = "Genre";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Location = new System.Drawing.Point(6, 41);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(35, 17);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "Titel";
            // 
            // lbGames
            // 
            this.lbGames.FormattingEnabled = true;
            this.lbGames.ItemHeight = 16;
            this.lbGames.Location = new System.Drawing.Point(363, 16);
            this.lbGames.Name = "lbGames";
            this.lbGames.Size = new System.Drawing.Size(402, 388);
            this.lbGames.TabIndex = 1;
            // 
            // cbGenres
            // 
            this.cbGenres.FormattingEnabled = true;
            this.cbGenres.Location = new System.Drawing.Point(97, 66);
            this.cbGenres.Name = "cbGenres";
            this.cbGenres.Size = new System.Drawing.Size(121, 24);
            this.cbGenres.TabIndex = 9;
            // 
            // cbPlatforms
            // 
            this.cbPlatforms.FormattingEnabled = true;
            this.cbPlatforms.Location = new System.Drawing.Point(98, 94);
            this.cbPlatforms.Name = "cbPlatforms";
            this.cbPlatforms.Size = new System.Drawing.Size(121, 24);
            this.cbPlatforms.TabIndex = 10;
            // 
            // gbFilterGames
            // 
            this.gbFilterGames.Controls.Add(this.BtnZoeken);
            this.gbFilterGames.Controls.Add(this.cbFilterGenre);
            this.gbFilterGames.Controls.Add(this.cbFilterPlatform);
            this.gbFilterGames.Controls.Add(this.clbFilterGames);
            this.gbFilterGames.Location = new System.Drawing.Point(12, 247);
            this.gbFilterGames.Name = "gbFilterGames";
            this.gbFilterGames.Size = new System.Drawing.Size(345, 157);
            this.gbFilterGames.TabIndex = 2;
            this.gbFilterGames.TabStop = false;
            this.gbFilterGames.Text = "Filter Games";
            // 
            // clbFilterGames
            // 
            this.clbFilterGames.FormattingEnabled = true;
            this.clbFilterGames.Items.AddRange(new object[] {
            "Duurste Game",
            "Genre",
            "Platform"});
            this.clbFilterGames.Location = new System.Drawing.Point(6, 21);
            this.clbFilterGames.Name = "clbFilterGames";
            this.clbFilterGames.Size = new System.Drawing.Size(120, 89);
            this.clbFilterGames.TabIndex = 0;
            this.clbFilterGames.SelectedIndexChanged += new System.EventHandler(this.clbFilterGames_SelectedIndexChanged);
            // 
            // cbFilterPlatform
            // 
            this.cbFilterPlatform.FormattingEnabled = true;
            this.cbFilterPlatform.Location = new System.Drawing.Point(132, 51);
            this.cbFilterPlatform.Name = "cbFilterPlatform";
            this.cbFilterPlatform.Size = new System.Drawing.Size(121, 24);
            this.cbFilterPlatform.TabIndex = 1;
            this.cbFilterPlatform.Visible = false;
            // 
            // cbFilterGenre
            // 
            this.cbFilterGenre.FormattingEnabled = true;
            this.cbFilterGenre.Location = new System.Drawing.Point(132, 21);
            this.cbFilterGenre.Name = "cbFilterGenre";
            this.cbFilterGenre.Size = new System.Drawing.Size(121, 24);
            this.cbFilterGenre.TabIndex = 2;
            this.cbFilterGenre.Visible = false;
            // 
            // BtnZoeken
            // 
            this.BtnZoeken.Location = new System.Drawing.Point(132, 81);
            this.BtnZoeken.Name = "BtnZoeken";
            this.BtnZoeken.Size = new System.Drawing.Size(121, 29);
            this.BtnZoeken.TabIndex = 3;
            this.BtnZoeken.Text = "Zoeken";
            this.BtnZoeken.UseVisualStyleBackColor = true;
            this.BtnZoeken.Click += new System.EventHandler(this.BtnZoeken_Click);
            // 
            // GamesAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 410);
            this.Controls.Add(this.gbFilterGames);
            this.Controls.Add(this.lbGames);
            this.Controls.Add(this.gbGameToevoegen);
            this.Name = "GamesAppForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GamesAppForm_Load);
            this.gbGameToevoegen.ResumeLayout(false);
            this.gbGameToevoegen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPrijs)).EndInit();
            this.gbFilterGames.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGameToevoegen;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown nUDPrijs;
        private System.Windows.Forms.TextBox tbTitel;
        private System.Windows.Forms.Label lblPrijs;
        private System.Windows.Forms.Label lblPlatform;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Button btnGameToevoegen;
        private System.Windows.Forms.ListBox lbGames;
        private System.Windows.Forms.ComboBox cbGenres;
        private System.Windows.Forms.ComboBox cbPlatforms;
        private System.Windows.Forms.GroupBox gbFilterGames;
        private System.Windows.Forms.Button BtnZoeken;
        private System.Windows.Forms.ComboBox cbFilterGenre;
        private System.Windows.Forms.ComboBox cbFilterPlatform;
        private System.Windows.Forms.CheckedListBox clbFilterGames;
    }
}

