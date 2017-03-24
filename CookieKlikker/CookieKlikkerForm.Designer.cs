namespace CookieKlikker
{
    partial class CookieKlikkerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CookieKlikkerForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblKPS = new System.Windows.Forms.Label();
            this.lblKoekjes = new System.Windows.Forms.Label();
            this.gbUpgrades = new System.Windows.Forms.GroupBox();
            this.lblDeegroller = new System.Windows.Forms.Label();
            this.lblOven = new System.Windows.Forms.Label();
            this.lblBakker = new System.Windows.Forms.Label();
            this.btnDeegroller = new System.Windows.Forms.Button();
            this.btnOven = new System.Windows.Forms.Button();
            this.btnBakker = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbUpgrades.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(508, 436);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // lblKPS
            // 
            this.lblKPS.AutoSize = true;
            this.lblKPS.Location = new System.Drawing.Point(555, 36);
            this.lblKPS.Name = "lblKPS";
            this.lblKPS.Size = new System.Drawing.Size(48, 17);
            this.lblKPS.TabIndex = 1;
            this.lblKPS.Text = "Kps: 0";
            // 
            // lblKoekjes
            // 
            this.lblKoekjes.AutoSize = true;
            this.lblKoekjes.Location = new System.Drawing.Point(558, 57);
            this.lblKoekjes.Name = "lblKoekjes";
            this.lblKoekjes.Size = new System.Drawing.Size(78, 17);
            this.lblKoekjes.TabIndex = 2;
            this.lblKoekjes.Text = "Koekjes: 0 ";
            // 
            // gbUpgrades
            // 
            this.gbUpgrades.Controls.Add(this.lblDeegroller);
            this.gbUpgrades.Controls.Add(this.lblOven);
            this.gbUpgrades.Controls.Add(this.lblBakker);
            this.gbUpgrades.Controls.Add(this.btnDeegroller);
            this.gbUpgrades.Controls.Add(this.btnOven);
            this.gbUpgrades.Controls.Add(this.btnBakker);
            this.gbUpgrades.Location = new System.Drawing.Point(561, 92);
            this.gbUpgrades.Name = "gbUpgrades";
            this.gbUpgrades.Size = new System.Drawing.Size(281, 213);
            this.gbUpgrades.TabIndex = 3;
            this.gbUpgrades.TabStop = false;
            this.gbUpgrades.Text = "Upgrades";
            // 
            // lblDeegroller
            // 
            this.lblDeegroller.AutoSize = true;
            this.lblDeegroller.Location = new System.Drawing.Point(145, 122);
            this.lblDeegroller.Name = "lblDeegroller";
            this.lblDeegroller.Size = new System.Drawing.Size(85, 17);
            this.lblDeegroller.TabIndex = 5;
            this.lblDeegroller.Text = "+ 10 per klik";
            // 
            // lblOven
            // 
            this.lblOven.AutoSize = true;
            this.lblOven.Location = new System.Drawing.Point(145, 75);
            this.lblOven.Name = "lblOven";
            this.lblOven.Size = new System.Drawing.Size(67, 17);
            this.lblOven.TabIndex = 4;
            this.lblOven.Text = "+ 50 KPS";
            // 
            // lblBakker
            // 
            this.lblBakker.AutoSize = true;
            this.lblBakker.Location = new System.Drawing.Point(145, 31);
            this.lblBakker.Name = "lblBakker";
            this.lblBakker.Size = new System.Drawing.Size(67, 17);
            this.lblBakker.TabIndex = 3;
            this.lblBakker.Text = "+ 10 KPS";
            // 
            // btnDeegroller
            // 
            this.btnDeegroller.Location = new System.Drawing.Point(7, 110);
            this.btnDeegroller.Name = "btnDeegroller";
            this.btnDeegroller.Size = new System.Drawing.Size(132, 41);
            this.btnDeegroller.TabIndex = 2;
            this.btnDeegroller.Text = "Deegroller(3500)";
            this.btnDeegroller.UseVisualStyleBackColor = true;
            this.btnDeegroller.Click += new System.EventHandler(this.btnDeegroller_Click);
            // 
            // btnOven
            // 
            this.btnOven.Location = new System.Drawing.Point(7, 63);
            this.btnOven.Name = "btnOven";
            this.btnOven.Size = new System.Drawing.Size(132, 41);
            this.btnOven.TabIndex = 1;
            this.btnOven.Text = "Oven(2000)";
            this.btnOven.UseVisualStyleBackColor = true;
            this.btnOven.Click += new System.EventHandler(this.btnOven_Click);
            // 
            // btnBakker
            // 
            this.btnBakker.Location = new System.Drawing.Point(7, 22);
            this.btnBakker.Name = "btnBakker";
            this.btnBakker.Size = new System.Drawing.Size(132, 35);
            this.btnBakker.TabIndex = 0;
            this.btnBakker.Text = "Bakker(100)";
            this.btnBakker.UseVisualStyleBackColor = true;
            this.btnBakker.Click += new System.EventHandler(this.btnBakker_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 513);
            this.Controls.Add(this.gbUpgrades);
            this.Controls.Add(this.lblKoekjes);
            this.Controls.Add(this.lblKPS);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbUpgrades.ResumeLayout(false);
            this.gbUpgrades.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblKPS;
        private System.Windows.Forms.Label lblKoekjes;
        private System.Windows.Forms.GroupBox gbUpgrades;
        private System.Windows.Forms.Label lblDeegroller;
        private System.Windows.Forms.Label lblOven;
        private System.Windows.Forms.Label lblBakker;
        private System.Windows.Forms.Button btnDeegroller;
        private System.Windows.Forms.Button btnOven;
        private System.Windows.Forms.Button btnBakker;
        private System.Windows.Forms.Timer timer1;
    }
}

