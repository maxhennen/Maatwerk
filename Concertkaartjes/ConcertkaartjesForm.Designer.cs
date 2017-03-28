namespace Concertkaartjes
{
    partial class ConcertkaartjesForm
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
            this.btnPrijs = new System.Windows.Forms.Button();
            this.btnArtiest = new System.Windows.Forms.Button();
            this.btnDatum = new System.Windows.Forms.Button();
            this.lbConcerten = new System.Windows.Forms.ListBox();
            this.gbBestellen = new System.Windows.Forms.GroupBox();
            this.nudAantalKaarten = new System.Windows.Forms.NumericUpDown();
            this.btnBestellen = new System.Windows.Forms.Button();
            this.lblTotaalPrijs = new System.Windows.Forms.Label();
            this.lblBesteldeKaarten = new System.Windows.Forms.Label();
            this.lblAantalKaarten = new System.Windows.Forms.Label();
            this.lblPrijs = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblArtiest = new System.Windows.Forms.Label();
            this.gbBestellen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAantalKaarten)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrijs
            // 
            this.btnPrijs.Location = new System.Drawing.Point(306, 12);
            this.btnPrijs.Name = "btnPrijs";
            this.btnPrijs.Size = new System.Drawing.Size(125, 49);
            this.btnPrijs.TabIndex = 2;
            this.btnPrijs.Text = "Sorteer op Prijs";
            this.btnPrijs.UseVisualStyleBackColor = true;
            this.btnPrijs.Click += new System.EventHandler(this.btnPrijs_Click);
            // 
            // btnArtiest
            // 
            this.btnArtiest.Location = new System.Drawing.Point(44, 12);
            this.btnArtiest.Name = "btnArtiest";
            this.btnArtiest.Size = new System.Drawing.Size(125, 49);
            this.btnArtiest.TabIndex = 3;
            this.btnArtiest.Text = "Sorteer op Artiest";
            this.btnArtiest.UseVisualStyleBackColor = true;
            this.btnArtiest.Click += new System.EventHandler(this.btnArtiest_Click);
            // 
            // btnDatum
            // 
            this.btnDatum.Location = new System.Drawing.Point(175, 12);
            this.btnDatum.Name = "btnDatum";
            this.btnDatum.Size = new System.Drawing.Size(125, 49);
            this.btnDatum.TabIndex = 4;
            this.btnDatum.Text = "Sorteer op Datum";
            this.btnDatum.UseVisualStyleBackColor = true;
            this.btnDatum.Click += new System.EventHandler(this.btnDatum_Click);
            // 
            // lbConcerten
            // 
            this.lbConcerten.FormattingEnabled = true;
            this.lbConcerten.ItemHeight = 16;
            this.lbConcerten.Location = new System.Drawing.Point(44, 67);
            this.lbConcerten.Name = "lbConcerten";
            this.lbConcerten.Size = new System.Drawing.Size(387, 436);
            this.lbConcerten.TabIndex = 5;
            this.lbConcerten.SelectedIndexChanged += new System.EventHandler(this.lbConcerten_SelectedIndexChanged);
            // 
            // gbBestellen
            // 
            this.gbBestellen.Controls.Add(this.nudAantalKaarten);
            this.gbBestellen.Controls.Add(this.btnBestellen);
            this.gbBestellen.Controls.Add(this.lblTotaalPrijs);
            this.gbBestellen.Controls.Add(this.lblBesteldeKaarten);
            this.gbBestellen.Controls.Add(this.lblAantalKaarten);
            this.gbBestellen.Controls.Add(this.lblPrijs);
            this.gbBestellen.Controls.Add(this.lblDatum);
            this.gbBestellen.Controls.Add(this.lblArtiest);
            this.gbBestellen.Location = new System.Drawing.Point(437, 12);
            this.gbBestellen.Name = "gbBestellen";
            this.gbBestellen.Size = new System.Drawing.Size(490, 491);
            this.gbBestellen.TabIndex = 6;
            this.gbBestellen.TabStop = false;
            this.gbBestellen.Text = "Bestellen";
            this.gbBestellen.Visible = false;
            // 
            // nudAantalKaarten
            // 
            this.nudAantalKaarten.Location = new System.Drawing.Point(122, 107);
            this.nudAantalKaarten.Name = "nudAantalKaarten";
            this.nudAantalKaarten.Size = new System.Drawing.Size(120, 22);
            this.nudAantalKaarten.TabIndex = 8;
            // 
            // btnBestellen
            // 
            this.btnBestellen.Location = new System.Drawing.Point(122, 132);
            this.btnBestellen.Name = "btnBestellen";
            this.btnBestellen.Size = new System.Drawing.Size(100, 37);
            this.btnBestellen.TabIndex = 7;
            this.btnBestellen.Text = "Bestel";
            this.btnBestellen.UseVisualStyleBackColor = true;
            // 
            // lblTotaalPrijs
            // 
            this.lblTotaalPrijs.AutoSize = true;
            this.lblTotaalPrijs.Location = new System.Drawing.Point(70, 234);
            this.lblTotaalPrijs.Name = "lblTotaalPrijs";
            this.lblTotaalPrijs.Size = new System.Drawing.Size(78, 17);
            this.lblTotaalPrijs.TabIndex = 5;
            this.lblTotaalPrijs.Text = "Totaalprijs:";
            this.lblTotaalPrijs.Visible = false;
            // 
            // lblBesteldeKaarten
            // 
            this.lblBesteldeKaarten.AutoSize = true;
            this.lblBesteldeKaarten.Location = new System.Drawing.Point(70, 217);
            this.lblBesteldeKaarten.Name = "lblBesteldeKaarten";
            this.lblBesteldeKaarten.Size = new System.Drawing.Size(209, 17);
            this.lblBesteldeKaarten.TabIndex = 4;
            this.lblBesteldeKaarten.Text = "U heeft x aantal kaarten besteld";
            this.lblBesteldeKaarten.Visible = false;
            // 
            // lblAantalKaarten
            // 
            this.lblAantalKaarten.AutoSize = true;
            this.lblAantalKaarten.Location = new System.Drawing.Point(6, 107);
            this.lblAantalKaarten.Name = "lblAantalKaarten";
            this.lblAantalKaarten.Size = new System.Drawing.Size(110, 17);
            this.lblAantalKaarten.TabIndex = 3;
            this.lblAantalKaarten.Text = "Aantal Kaarten: ";
            // 
            // lblPrijs
            // 
            this.lblPrijs.AutoSize = true;
            this.lblPrijs.Location = new System.Drawing.Point(6, 72);
            this.lblPrijs.Name = "lblPrijs";
            this.lblPrijs.Size = new System.Drawing.Size(43, 17);
            this.lblPrijs.TabIndex = 2;
            this.lblPrijs.Text = "Prijs: ";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(6, 55);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(53, 17);
            this.lblDatum.TabIndex = 1;
            this.lblDatum.Text = "Datum:";
            // 
            // lblArtiest
            // 
            this.lblArtiest.AutoSize = true;
            this.lblArtiest.Location = new System.Drawing.Point(6, 38);
            this.lblArtiest.Name = "lblArtiest";
            this.lblArtiest.Size = new System.Drawing.Size(56, 17);
            this.lblArtiest.TabIndex = 0;
            this.lblArtiest.Text = "Artiest: ";
            // 
            // ConcertkaartjesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 508);
            this.Controls.Add(this.gbBestellen);
            this.Controls.Add(this.lbConcerten);
            this.Controls.Add(this.btnDatum);
            this.Controls.Add(this.btnArtiest);
            this.Controls.Add(this.btnPrijs);
            this.Name = "ConcertkaartjesForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ConcertkaartjesForm_Load);
            this.gbBestellen.ResumeLayout(false);
            this.gbBestellen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAantalKaarten)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrijs;
        private System.Windows.Forms.Button btnArtiest;
        private System.Windows.Forms.Button btnDatum;
        private System.Windows.Forms.ListBox lbConcerten;
        private System.Windows.Forms.GroupBox gbBestellen;
        private System.Windows.Forms.Label lblTotaalPrijs;
        private System.Windows.Forms.Label lblBesteldeKaarten;
        private System.Windows.Forms.Label lblAantalKaarten;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblArtiest;
        private System.Windows.Forms.Label lblPrijs;
        private System.Windows.Forms.Button btnBestellen;
        private System.Windows.Forms.NumericUpDown nudAantalKaarten;
    }
}

