namespace Les5Opdracht2
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
            this.txtCategorieen = new System.Windows.Forms.TextBox();
            this.txtBereidingstijd = new System.Windows.Forms.TextBox();
            this.txtRecepten = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCategorieen
            // 
            this.txtCategorieen.Location = new System.Drawing.Point(56, 50);
            this.txtCategorieen.Name = "txtCategorieen";
            this.txtCategorieen.Size = new System.Drawing.Size(285, 22);
            this.txtCategorieen.TabIndex = 0;
            this.txtCategorieen.TextChanged += new System.EventHandler(this.txtCategorieen_TextChanged);
            // 
            // txtBereidingstijd
            // 
            this.txtBereidingstijd.Location = new System.Drawing.Point(56, 187);
            this.txtBereidingstijd.Name = "txtBereidingstijd";
            this.txtBereidingstijd.Size = new System.Drawing.Size(285, 22);
            this.txtBereidingstijd.TabIndex = 1;
            // 
            // txtRecepten
            // 
            this.txtRecepten.Location = new System.Drawing.Point(56, 123);
            this.txtRecepten.Name = "txtRecepten";
            this.txtRecepten.Size = new System.Drawing.Size(285, 22);
            this.txtRecepten.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 298);
            this.Controls.Add(this.txtRecepten);
            this.Controls.Add(this.txtBereidingstijd);
            this.Controls.Add(this.txtCategorieen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCategorieen;
        private System.Windows.Forms.TextBox txtBereidingstijd;
        private System.Windows.Forms.TextBox txtRecepten;
    }
}

