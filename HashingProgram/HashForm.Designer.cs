namespace HashingProgram
{
    partial class HashForm
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
            this.tbEncrypt = new System.Windows.Forms.TextBox();
            this.tbDecrypt = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lblEncrypt = new System.Windows.Forms.Label();
            this.lblDecrypt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbEncrypt
            // 
            this.tbEncrypt.Location = new System.Drawing.Point(12, 54);
            this.tbEncrypt.Multiline = true;
            this.tbEncrypt.Name = "tbEncrypt";
            this.tbEncrypt.Size = new System.Drawing.Size(307, 144);
            this.tbEncrypt.TabIndex = 0;
            // 
            // tbDecrypt
            // 
            this.tbDecrypt.Location = new System.Drawing.Point(12, 235);
            this.tbDecrypt.Multiline = true;
            this.tbDecrypt.Name = "tbDecrypt";
            this.tbDecrypt.Size = new System.Drawing.Size(307, 144);
            this.tbDecrypt.TabIndex = 1;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(325, 250);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 39);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(325, 295);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 39);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lblEncrypt
            // 
            this.lblEncrypt.AutoSize = true;
            this.lblEncrypt.Location = new System.Drawing.Point(13, 13);
            this.lblEncrypt.Name = "lblEncrypt";
            this.lblEncrypt.Size = new System.Drawing.Size(56, 17);
            this.lblEncrypt.TabIndex = 4;
            this.lblEncrypt.Text = "Encrypt";
            // 
            // lblDecrypt
            // 
            this.lblDecrypt.AutoSize = true;
            this.lblDecrypt.Location = new System.Drawing.Point(13, 215);
            this.lblDecrypt.Name = "lblDecrypt";
            this.lblDecrypt.Size = new System.Drawing.Size(57, 17);
            this.lblDecrypt.TabIndex = 5;
            this.lblDecrypt.Text = "Decrypt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 406);
            this.Controls.Add(this.lblDecrypt);
            this.Controls.Add(this.lblEncrypt);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.tbDecrypt);
            this.Controls.Add(this.tbEncrypt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEncrypt;
        private System.Windows.Forms.TextBox tbDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lblEncrypt;
        private System.Windows.Forms.Label lblDecrypt;
    }
}

