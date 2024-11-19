namespace Project_dierenarts
{
    partial class ToonAlleBehandelingen
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
            this.btnTerug = new System.Windows.Forms.Button();
            this.pbxAlleBehandelingen = new System.Windows.Forms.PictureBox();
            this.lbxAlleBehandelingen = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlleBehandelingen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTerug
            // 
            this.btnTerug.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerug.Location = new System.Drawing.Point(133, 318);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(551, 106);
            this.btnTerug.TabIndex = 0;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // pbxAlleBehandelingen
            // 
            this.pbxAlleBehandelingen.Image = global::Project_dierenarts.Properties.Resources.KattenBehandeling;
            this.pbxAlleBehandelingen.Location = new System.Drawing.Point(10, 50);
            this.pbxAlleBehandelingen.Name = "pbxAlleBehandelingen";
            this.pbxAlleBehandelingen.Size = new System.Drawing.Size(330, 239);
            this.pbxAlleBehandelingen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAlleBehandelingen.TabIndex = 1;
            this.pbxAlleBehandelingen.TabStop = false;
            // 
            // lbxAlleBehandelingen
            // 
            this.lbxAlleBehandelingen.FormattingEnabled = true;
            this.lbxAlleBehandelingen.ItemHeight = 16;
            this.lbxAlleBehandelingen.Location = new System.Drawing.Point(385, 57);
            this.lbxAlleBehandelingen.Name = "lbxAlleBehandelingen";
            this.lbxAlleBehandelingen.Size = new System.Drawing.Size(377, 228);
            this.lbxAlleBehandelingen.TabIndex = 2;
            // 
            // ToonAlleBehandelingen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxAlleBehandelingen);
            this.Controls.Add(this.pbxAlleBehandelingen);
            this.Controls.Add(this.btnTerug);
            this.Name = "ToonAlleBehandelingen";
            this.Text = "ToonAlleBehandelingen";
            this.Load += new System.EventHandler(this.ToonAlleBehandelingen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlleBehandelingen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.PictureBox pbxAlleBehandelingen;
        private System.Windows.Forms.ListBox lbxAlleBehandelingen;
    }
}