namespace SpaceMan
{
    partial class SpaceManForm
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
            this.gbSpaceMan = new System.Windows.Forms.GroupBox();
            this.btHaalPlaneten = new System.Windows.Forms.Button();
            this.lbPlaneten = new System.Windows.Forms.ListBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.btnPlaneten = new System.Windows.Forms.Button();
            this.gbSpaceMan.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSpaceMan
            // 
            this.gbSpaceMan.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gbSpaceMan.Controls.Add(this.btnPlaneten);
            this.gbSpaceMan.Controls.Add(this.btHaalPlaneten);
            this.gbSpaceMan.Controls.Add(this.lbPlaneten);
            this.gbSpaceMan.Controls.Add(this.lblNaam);
            this.gbSpaceMan.Location = new System.Drawing.Point(31, 26);
            this.gbSpaceMan.Margin = new System.Windows.Forms.Padding(4);
            this.gbSpaceMan.Name = "gbSpaceMan";
            this.gbSpaceMan.Padding = new System.Windows.Forms.Padding(4);
            this.gbSpaceMan.Size = new System.Drawing.Size(516, 561);
            this.gbSpaceMan.TabIndex = 0;
            this.gbSpaceMan.TabStop = false;
            this.gbSpaceMan.Text = "SpaceMan";
            // 
            // btHaalPlaneten
            // 
            this.btHaalPlaneten.Location = new System.Drawing.Point(28, 94);
            this.btHaalPlaneten.Margin = new System.Windows.Forms.Padding(4);
            this.btHaalPlaneten.Name = "btHaalPlaneten";
            this.btHaalPlaneten.Size = new System.Drawing.Size(455, 28);
            this.btHaalPlaneten.TabIndex = 2;
            this.btHaalPlaneten.Text = "Bezochte bewoonde planeten";
            this.btHaalPlaneten.UseVisualStyleBackColor = true;
            this.btHaalPlaneten.Click += new System.EventHandler(this.btHaalPlaneten_Click);
            // 
            // lbPlaneten
            // 
            this.lbPlaneten.FormattingEnabled = true;
            this.lbPlaneten.ItemHeight = 16;
            this.lbPlaneten.Location = new System.Drawing.Point(28, 129);
            this.lbPlaneten.Margin = new System.Windows.Forms.Padding(4);
            this.lbPlaneten.Name = "lbPlaneten";
            this.lbPlaneten.Size = new System.Drawing.Size(453, 404);
            this.lbPlaneten.TabIndex = 1;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaam.Location = new System.Drawing.Point(21, 41);
            this.lblNaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(39, 36);
            this.lblNaam.TabIndex = 0;
            this.lblNaam.Text = "...";
            // 
            // btnPlaneten
            // 
            this.btnPlaneten.Location = new System.Drawing.Point(303, 41);
            this.btnPlaneten.Name = "btnPlaneten";
            this.btnPlaneten.Size = new System.Drawing.Size(143, 46);
            this.btnPlaneten.TabIndex = 3;
            this.btnPlaneten.Text = "Planeten komen overeen";
            this.btnPlaneten.UseVisualStyleBackColor = true;
            this.btnPlaneten.Click += new System.EventHandler(this.btnPlaneten_Click);
            // 
            // SpaceManForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceMan.Properties.Resources.deepSpace;
            this.ClientSize = new System.Drawing.Size(983, 619);
            this.Controls.Add(this.gbSpaceMan);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SpaceManForm";
            this.Text = "Where did SpaceMan Go?";
            this.gbSpaceMan.ResumeLayout(false);
            this.gbSpaceMan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSpaceMan;
        private System.Windows.Forms.Button btHaalPlaneten;
        private System.Windows.Forms.ListBox lbPlaneten;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Button btnPlaneten;
    }
}

