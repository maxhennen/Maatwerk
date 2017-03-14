namespace BakkerijGoedGeSpelt
{
    partial class bakkerijForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bakkerijForm));
            this.gbBroodjes = new System.Windows.Forms.GroupBox();
            this.btMaakPrijsLijst = new System.Windows.Forms.Button();
            this.btHaalBroodjesOp = new System.Windows.Forms.Button();
            this.btSlaBroodjesOp = new System.Windows.Forms.Button();
            this.lblBeleg = new System.Windows.Forms.Label();
            this.lblGeselecteerdBroodje = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbToevoegen = new System.Windows.Forms.GroupBox();
            this.btBroodjeKlaar = new System.Windows.Forms.Button();
            this.btBelegToevoegen = new System.Windows.Forms.Button();
            this.cbBeleg = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btBroodjeAanmaken = new System.Windows.Forms.Button();
            this.cbBroodSoorten = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNaamBroodje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbBroodjes = new System.Windows.Forms.ListBox();
            this.gbBroodjes.SuspendLayout();
            this.gbToevoegen.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBroodjes
            // 
            this.gbBroodjes.BackColor = System.Drawing.Color.Ivory;
            this.gbBroodjes.Controls.Add(this.btMaakPrijsLijst);
            this.gbBroodjes.Controls.Add(this.btHaalBroodjesOp);
            this.gbBroodjes.Controls.Add(this.btSlaBroodjesOp);
            this.gbBroodjes.Controls.Add(this.lblBeleg);
            this.gbBroodjes.Controls.Add(this.lblGeselecteerdBroodje);
            this.gbBroodjes.Controls.Add(this.label4);
            this.gbBroodjes.Controls.Add(this.gbToevoegen);
            this.gbBroodjes.Controls.Add(this.lbBroodjes);
            this.gbBroodjes.Location = new System.Drawing.Point(29, 38);
            this.gbBroodjes.Margin = new System.Windows.Forms.Padding(4);
            this.gbBroodjes.Name = "gbBroodjes";
            this.gbBroodjes.Padding = new System.Windows.Forms.Padding(4);
            this.gbBroodjes.Size = new System.Drawing.Size(961, 475);
            this.gbBroodjes.TabIndex = 0;
            this.gbBroodjes.TabStop = false;
            this.gbBroodjes.Text = "Broodjes";
            // 
            // btMaakPrijsLijst
            // 
            this.btMaakPrijsLijst.Location = new System.Drawing.Point(561, 350);
            this.btMaakPrijsLijst.Margin = new System.Windows.Forms.Padding(4);
            this.btMaakPrijsLijst.Name = "btMaakPrijsLijst";
            this.btMaakPrijsLijst.Size = new System.Drawing.Size(372, 47);
            this.btMaakPrijsLijst.TabIndex = 7;
            this.btMaakPrijsLijst.Text = "Maak prijslijst";
            this.btMaakPrijsLijst.UseVisualStyleBackColor = true;
            this.btMaakPrijsLijst.Click += new System.EventHandler(this.btMaakPrijsLijst_Click);
            // 
            // btHaalBroodjesOp
            // 
            this.btHaalBroodjesOp.Location = new System.Drawing.Point(760, 404);
            this.btHaalBroodjesOp.Margin = new System.Windows.Forms.Padding(4);
            this.btHaalBroodjesOp.Name = "btHaalBroodjesOp";
            this.btHaalBroodjesOp.Size = new System.Drawing.Size(173, 46);
            this.btHaalBroodjesOp.TabIndex = 6;
            this.btHaalBroodjesOp.Text = "Haal broodjes op";
            this.btHaalBroodjesOp.UseVisualStyleBackColor = true;
            this.btHaalBroodjesOp.Click += new System.EventHandler(this.btHaalBroodjesOp_Click);
            // 
            // btSlaBroodjesOp
            // 
            this.btSlaBroodjesOp.Location = new System.Drawing.Point(561, 404);
            this.btSlaBroodjesOp.Margin = new System.Windows.Forms.Padding(4);
            this.btSlaBroodjesOp.Name = "btSlaBroodjesOp";
            this.btSlaBroodjesOp.Size = new System.Drawing.Size(173, 46);
            this.btSlaBroodjesOp.TabIndex = 5;
            this.btSlaBroodjesOp.Text = "Sla broodjes op";
            this.btSlaBroodjesOp.UseVisualStyleBackColor = true;
            this.btSlaBroodjesOp.Click += new System.EventHandler(this.btSlaBroodjesOp_Click);
            // 
            // lblBeleg
            // 
            this.lblBeleg.AutoSize = true;
            this.lblBeleg.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeleg.Location = new System.Drawing.Point(536, 105);
            this.lblBeleg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBeleg.Name = "lblBeleg";
            this.lblBeleg.Size = new System.Drawing.Size(25, 24);
            this.lblBeleg.TabIndex = 4;
            this.lblBeleg.Text = "...";
            // 
            // lblGeselecteerdBroodje
            // 
            this.lblGeselecteerdBroodje.AutoSize = true;
            this.lblGeselecteerdBroodje.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeselecteerdBroodje.Location = new System.Drawing.Point(533, 58);
            this.lblGeselecteerdBroodje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGeselecteerdBroodje.Name = "lblGeselecteerdBroodje";
            this.lblGeselecteerdBroodje.Size = new System.Drawing.Size(28, 29);
            this.lblGeselecteerdBroodje.TabIndex = 3;
            this.lblGeselecteerdBroodje.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Informatie broodje:";
            // 
            // gbToevoegen
            // 
            this.gbToevoegen.Controls.Add(this.btBroodjeKlaar);
            this.gbToevoegen.Controls.Add(this.btBelegToevoegen);
            this.gbToevoegen.Controls.Add(this.cbBeleg);
            this.gbToevoegen.Controls.Add(this.label3);
            this.gbToevoegen.Controls.Add(this.btBroodjeAanmaken);
            this.gbToevoegen.Controls.Add(this.cbBroodSoorten);
            this.gbToevoegen.Controls.Add(this.label2);
            this.gbToevoegen.Controls.Add(this.tbNaamBroodje);
            this.gbToevoegen.Controls.Add(this.label1);
            this.gbToevoegen.Location = new System.Drawing.Point(8, 23);
            this.gbToevoegen.Margin = new System.Windows.Forms.Padding(4);
            this.gbToevoegen.Name = "gbToevoegen";
            this.gbToevoegen.Padding = new System.Windows.Forms.Padding(4);
            this.gbToevoegen.Size = new System.Drawing.Size(300, 225);
            this.gbToevoegen.TabIndex = 1;
            this.gbToevoegen.TabStop = false;
            this.gbToevoegen.Text = "Broodje toevoegen";
            // 
            // btBroodjeKlaar
            // 
            this.btBroodjeKlaar.Enabled = false;
            this.btBroodjeKlaar.Location = new System.Drawing.Point(156, 185);
            this.btBroodjeKlaar.Margin = new System.Windows.Forms.Padding(4);
            this.btBroodjeKlaar.Name = "btBroodjeKlaar";
            this.btBroodjeKlaar.Size = new System.Drawing.Size(136, 28);
            this.btBroodjeKlaar.TabIndex = 8;
            this.btBroodjeKlaar.Text = "Broodje is klaar";
            this.btBroodjeKlaar.UseVisualStyleBackColor = true;
            // 
            // btBelegToevoegen
            // 
            this.btBelegToevoegen.Enabled = false;
            this.btBelegToevoegen.Location = new System.Drawing.Point(19, 185);
            this.btBelegToevoegen.Margin = new System.Windows.Forms.Padding(4);
            this.btBelegToevoegen.Name = "btBelegToevoegen";
            this.btBelegToevoegen.Size = new System.Drawing.Size(136, 28);
            this.btBelegToevoegen.TabIndex = 7;
            this.btBelegToevoegen.Text = "Beleg toevoegen";
            this.btBelegToevoegen.UseVisualStyleBackColor = true;
            // 
            // cbBeleg
            // 
            this.cbBeleg.Enabled = false;
            this.cbBeleg.FormattingEnabled = true;
            this.cbBeleg.Location = new System.Drawing.Point(103, 151);
            this.cbBeleg.Margin = new System.Windows.Forms.Padding(4);
            this.cbBeleg.Name = "cbBeleg";
            this.cbBeleg.Size = new System.Drawing.Size(173, 24);
            this.cbBeleg.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Beleg:";
            // 
            // btBroodjeAanmaken
            // 
            this.btBroodjeAanmaken.Location = new System.Drawing.Point(71, 111);
            this.btBroodjeAanmaken.Margin = new System.Windows.Forms.Padding(4);
            this.btBroodjeAanmaken.Name = "btBroodjeAanmaken";
            this.btBroodjeAanmaken.Size = new System.Drawing.Size(163, 28);
            this.btBroodjeAanmaken.TabIndex = 4;
            this.btBroodjeAanmaken.Text = "Broodje toevoegen";
            this.btBroodjeAanmaken.UseVisualStyleBackColor = true;
            // 
            // cbBroodSoorten
            // 
            this.cbBroodSoorten.FormattingEnabled = true;
            this.cbBroodSoorten.Location = new System.Drawing.Point(103, 71);
            this.cbBroodSoorten.Margin = new System.Windows.Forms.Padding(4);
            this.cbBroodSoorten.Name = "cbBroodSoorten";
            this.cbBroodSoorten.Size = new System.Drawing.Size(173, 24);
            this.cbBroodSoorten.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broodsoort:";
            // 
            // tbNaamBroodje
            // 
            this.tbNaamBroodje.Location = new System.Drawing.Point(103, 34);
            this.tbNaamBroodje.Margin = new System.Windows.Forms.Padding(4);
            this.tbNaamBroodje.Name = "tbNaamBroodje";
            this.tbNaamBroodje.Size = new System.Drawing.Size(173, 22);
            this.tbNaamBroodje.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam:";
            // 
            // lbBroodjes
            // 
            this.lbBroodjes.FormattingEnabled = true;
            this.lbBroodjes.ItemHeight = 16;
            this.lbBroodjes.Location = new System.Drawing.Point(316, 30);
            this.lbBroodjes.Margin = new System.Windows.Forms.Padding(4);
            this.lbBroodjes.Name = "lbBroodjes";
            this.lbBroodjes.Size = new System.Drawing.Size(212, 420);
            this.lbBroodjes.TabIndex = 0;
            // 
            // bakkerijForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 549);
            this.Controls.Add(this.gbBroodjes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "bakkerijForm";
            this.Text = "Bakkerij GoedGeSpelt";
            this.Load += new System.EventHandler(this.bakkerijForm_Load);
            this.gbBroodjes.ResumeLayout(false);
            this.gbBroodjes.PerformLayout();
            this.gbToevoegen.ResumeLayout(false);
            this.gbToevoegen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBroodjes;
        private System.Windows.Forms.GroupBox gbToevoegen;
        private System.Windows.Forms.Button btBelegToevoegen;
        private System.Windows.Forms.ComboBox cbBeleg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btBroodjeAanmaken;
        private System.Windows.Forms.ComboBox cbBroodSoorten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNaamBroodje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbBroodjes;
        private System.Windows.Forms.Button btBroodjeKlaar;
        private System.Windows.Forms.Label lblBeleg;
        private System.Windows.Forms.Label lblGeselecteerdBroodje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btMaakPrijsLijst;
        private System.Windows.Forms.Button btHaalBroodjesOp;
        private System.Windows.Forms.Button btSlaBroodjesOp;
    }
}

