namespace OOP_Atleten
{
    partial class AtleetForm
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
            this.btnSchoenen = new System.Windows.Forms.Button();
            this.BtnBlessure = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cbSorteerTraining = new System.Windows.Forms.ComboBox();
            this.btnSorteer = new System.Windows.Forms.Button();
            this.btnTraining = new System.Windows.Forms.Button();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSchoenen
            // 
            this.btnSchoenen.Location = new System.Drawing.Point(12, 12);
            this.btnSchoenen.Name = "btnSchoenen";
            this.btnSchoenen.Size = new System.Drawing.Size(102, 53);
            this.btnSchoenen.TabIndex = 0;
            this.btnSchoenen.Text = "Schoenen";
            this.btnSchoenen.UseVisualStyleBackColor = true;
            this.btnSchoenen.Click += new System.EventHandler(this.btnSchoenen_Click);
            // 
            // BtnBlessure
            // 
            this.BtnBlessure.Location = new System.Drawing.Point(120, 12);
            this.BtnBlessure.Name = "BtnBlessure";
            this.BtnBlessure.Size = new System.Drawing.Size(97, 56);
            this.BtnBlessure.TabIndex = 1;
            this.BtnBlessure.Text = "Blessure";
            this.BtnBlessure.UseVisualStyleBackColor = true;
            this.BtnBlessure.Click += new System.EventHandler(this.BtnBlessure_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(223, 9);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(422, 340);
            this.listBox1.TabIndex = 2;
            // 
            // cbSorteerTraining
            // 
            this.cbSorteerTraining.FormattingEnabled = true;
            this.cbSorteerTraining.Items.AddRange(new object[] {
            "Datum",
            "Intensiteit en duur"});
            this.cbSorteerTraining.Location = new System.Drawing.Point(12, 74);
            this.cbSorteerTraining.Name = "cbSorteerTraining";
            this.cbSorteerTraining.Size = new System.Drawing.Size(102, 24);
            this.cbSorteerTraining.TabIndex = 3;
            // 
            // btnSorteer
            // 
            this.btnSorteer.Location = new System.Drawing.Point(120, 74);
            this.btnSorteer.Name = "btnSorteer";
            this.btnSorteer.Size = new System.Drawing.Size(97, 56);
            this.btnSorteer.TabIndex = 4;
            this.btnSorteer.Text = "Soorteer";
            this.btnSorteer.UseVisualStyleBackColor = true;
            this.btnSorteer.Click += new System.EventHandler(this.btnSorteer_Click);
            // 
            // btnTraining
            // 
            this.btnTraining.Location = new System.Drawing.Point(120, 136);
            this.btnTraining.Name = "btnTraining";
            this.btnTraining.Size = new System.Drawing.Size(97, 50);
            this.btnTraining.TabIndex = 5;
            this.btnTraining.Text = "Training Toevoegen";
            this.btnTraining.UseVisualStyleBackColor = true;
            this.btnTraining.Click += new System.EventHandler(this.btnTraining_Click);
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(120, 192);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(97, 47);
            this.btnOpslaan.TabIndex = 6;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // AtleetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 361);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.btnTraining);
            this.Controls.Add(this.btnSorteer);
            this.Controls.Add(this.cbSorteerTraining);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnBlessure);
            this.Controls.Add(this.btnSchoenen);
            this.Name = "AtleetForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSchoenen;
        private System.Windows.Forms.Button BtnBlessure;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cbSorteerTraining;
        private System.Windows.Forms.Button btnSorteer;
        private System.Windows.Forms.Button btnTraining;
        private System.Windows.Forms.Button btnOpslaan;
    }
}

