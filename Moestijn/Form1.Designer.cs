namespace Moestijn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbGroente = new System.Windows.Forms.ListBox();
            this.btnZoek = new System.Windows.Forms.Button();
            this.cbZaaitijd = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKiesGroente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbGroente);
            this.groupBox1.Controls.Add(this.btnZoek);
            this.groupBox1.Controls.Add(this.cbZaaitijd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbKiesGroente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 408);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kies Groente";
            // 
            // lbGroente
            // 
            this.lbGroente.FormattingEnabled = true;
            this.lbGroente.ItemHeight = 16;
            this.lbGroente.Location = new System.Drawing.Point(9, 122);
            this.lbGroente.Name = "lbGroente";
            this.lbGroente.Size = new System.Drawing.Size(377, 276);
            this.lbGroente.TabIndex = 5;
            // 
            // btnZoek
            // 
            this.btnZoek.Location = new System.Drawing.Point(311, 79);
            this.btnZoek.Name = "btnZoek";
            this.btnZoek.Size = new System.Drawing.Size(75, 29);
            this.btnZoek.TabIndex = 4;
            this.btnZoek.Text = "Zoek";
            this.btnZoek.UseVisualStyleBackColor = true;
            // 
            // cbZaaitijd
            // 
            this.cbZaaitijd.FormattingEnabled = true;
            this.cbZaaitijd.Location = new System.Drawing.Point(112, 79);
            this.cbZaaitijd.Name = "cbZaaitijd";
            this.cbZaaitijd.Size = new System.Drawing.Size(179, 24);
            this.cbZaaitijd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zaaitijd:";
            // 
            // cbKiesGroente
            // 
            this.cbKiesGroente.FormattingEnabled = true;
            this.cbKiesGroente.Location = new System.Drawing.Point(112, 28);
            this.cbKiesGroente.Name = "cbKiesGroente";
            this.cbKiesGroente.Size = new System.Drawing.Size(179, 24);
            this.cbKiesGroente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Groente:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(464, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(601, 202);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 432);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Moestijn App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbGroente;
        private System.Windows.Forms.Button btnZoek;
        private System.Windows.Forms.ComboBox cbZaaitijd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKiesGroente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

