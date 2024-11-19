namespace Project_dierenarts
{
    partial class TonenBehandelingen
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
            this.lbxBehandelingen = new System.Windows.Forms.ListBox();
            this.pbxBehandelingen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBehandelingen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTerug
            // 
            this.btnTerug.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerug.Location = new System.Drawing.Point(228, 331);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(350, 96);
            this.btnTerug.TabIndex = 0;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // lbxBehandelingen
            // 
            this.lbxBehandelingen.BackColor = System.Drawing.SystemColors.Menu;
            this.lbxBehandelingen.FormattingEnabled = true;
            this.lbxBehandelingen.ItemHeight = 16;
            this.lbxBehandelingen.Location = new System.Drawing.Point(12, 12);
            this.lbxBehandelingen.Name = "lbxBehandelingen";
            this.lbxBehandelingen.Size = new System.Drawing.Size(402, 292);
            this.lbxBehandelingen.TabIndex = 1;
            // 
            // pbxBehandelingen
            // 
            this.pbxBehandelingen.Image = global::Project_dierenarts.Properties.Resources.Dierenarts_Behandelingen;
            this.pbxBehandelingen.Location = new System.Drawing.Point(441, 26);
            this.pbxBehandelingen.Name = "pbxBehandelingen";
            this.pbxBehandelingen.Size = new System.Drawing.Size(345, 277);
            this.pbxBehandelingen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBehandelingen.TabIndex = 2;
            this.pbxBehandelingen.TabStop = false;
            // 
            // TonenBehandelingen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxBehandelingen);
            this.Controls.Add(this.lbxBehandelingen);
            this.Controls.Add(this.btnTerug);
            this.Name = "TonenBehandelingen";
            this.Text = "TonenBehandelingen";
            this.Load += new System.EventHandler(this.TonenBehandelingen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBehandelingen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.ListBox lbxBehandelingen;
        private System.Windows.Forms.PictureBox pbxBehandelingen;
    }
}