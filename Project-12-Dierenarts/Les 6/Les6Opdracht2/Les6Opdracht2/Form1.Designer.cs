namespace Les6Opdracht2
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
            this.btnBevestig = new System.Windows.Forms.Button();
            this.lblReceptNaam = new System.Windows.Forms.Label();
            this.lblIngredienten = new System.Windows.Forms.Label();
            this.lblPersonen = new System.Windows.Forms.Label();
            this.lblBereidingstijd = new System.Windows.Forms.Label();
            this.lblCategorieId = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtIngredienten = new System.Windows.Forms.TextBox();
            this.txtHoeveel = new System.Windows.Forms.TextBox();
            this.txtCategorie = new System.Windows.Forms.TextBox();
            this.txtBereidingstijd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBevestig
            // 
            this.btnBevestig.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBevestig.Location = new System.Drawing.Point(498, 357);
            this.btnBevestig.Name = "btnBevestig";
            this.btnBevestig.Size = new System.Drawing.Size(303, 96);
            this.btnBevestig.TabIndex = 0;
            this.btnBevestig.Text = "Bevestig";
            this.btnBevestig.UseVisualStyleBackColor = true;
            this.btnBevestig.Click += new System.EventHandler(this.btnBevestig_Click);
            // 
            // lblReceptNaam
            // 
            this.lblReceptNaam.AutoSize = true;
            this.lblReceptNaam.Location = new System.Drawing.Point(130, 49);
            this.lblReceptNaam.Name = "lblReceptNaam";
            this.lblReceptNaam.Size = new System.Drawing.Size(85, 16);
            this.lblReceptNaam.TabIndex = 1;
            this.lblReceptNaam.Text = "naam recept:";
            // 
            // lblIngredienten
            // 
            this.lblIngredienten.AutoSize = true;
            this.lblIngredienten.Location = new System.Drawing.Point(130, 270);
            this.lblIngredienten.Name = "lblIngredienten";
            this.lblIngredienten.Size = new System.Drawing.Size(84, 16);
            this.lblIngredienten.TabIndex = 2;
            this.lblIngredienten.Text = "Ingredienten:";
            // 
            // lblPersonen
            // 
            this.lblPersonen.AutoSize = true;
            this.lblPersonen.Location = new System.Drawing.Point(130, 203);
            this.lblPersonen.Name = "lblPersonen";
            this.lblPersonen.Size = new System.Drawing.Size(123, 16);
            this.lblPersonen.TabIndex = 3;
            this.lblPersonen.Text = "Hoeveel Personen:";
            // 
            // lblBereidingstijd
            // 
            this.lblBereidingstijd.AutoSize = true;
            this.lblBereidingstijd.Location = new System.Drawing.Point(131, 152);
            this.lblBereidingstijd.Name = "lblBereidingstijd";
            this.lblBereidingstijd.Size = new System.Drawing.Size(92, 16);
            this.lblBereidingstijd.TabIndex = 4;
            this.lblBereidingstijd.Text = "Bereidingstijd:";
            // 
            // lblCategorieId
            // 
            this.lblCategorieId.AutoSize = true;
            this.lblCategorieId.Location = new System.Drawing.Point(131, 101);
            this.lblCategorieId.Name = "lblCategorieId";
            this.lblCategorieId.Size = new System.Drawing.Size(83, 16);
            this.lblCategorieId.TabIndex = 5;
            this.lblCategorieId.Text = "categorie ID:";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(154, 68);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(256, 22);
            this.txtNaam.TabIndex = 6;
            // 
            // txtIngredienten
            // 
            this.txtIngredienten.Location = new System.Drawing.Point(154, 308);
            this.txtIngredienten.Name = "txtIngredienten";
            this.txtIngredienten.Size = new System.Drawing.Size(256, 22);
            this.txtIngredienten.TabIndex = 8;
            // 
            // txtHoeveel
            // 
            this.txtHoeveel.Location = new System.Drawing.Point(154, 232);
            this.txtHoeveel.Name = "txtHoeveel";
            this.txtHoeveel.Size = new System.Drawing.Size(256, 22);
            this.txtHoeveel.TabIndex = 9;
            // 
            // txtCategorie
            // 
            this.txtCategorie.Location = new System.Drawing.Point(154, 127);
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.Size = new System.Drawing.Size(256, 22);
            this.txtCategorie.TabIndex = 10;
            // 
            // txtBereidingstijd
            // 
            this.txtBereidingstijd.Location = new System.Drawing.Point(154, 178);
            this.txtBereidingstijd.Name = "txtBereidingstijd";
            this.txtBereidingstijd.Size = new System.Drawing.Size(256, 22);
            this.txtBereidingstijd.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBereidingstijd);
            this.Controls.Add(this.txtCategorie);
            this.Controls.Add(this.txtHoeveel);
            this.Controls.Add(this.txtIngredienten);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.lblCategorieId);
            this.Controls.Add(this.lblBereidingstijd);
            this.Controls.Add(this.lblPersonen);
            this.Controls.Add(this.lblIngredienten);
            this.Controls.Add(this.lblReceptNaam);
            this.Controls.Add(this.btnBevestig);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBevestig;
        private System.Windows.Forms.Label lblReceptNaam;
        private System.Windows.Forms.Label lblIngredienten;
        private System.Windows.Forms.Label lblPersonen;
        private System.Windows.Forms.Label lblBereidingstijd;
        private System.Windows.Forms.Label lblCategorieId;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtIngredienten;
        private System.Windows.Forms.TextBox txtHoeveel;
        private System.Windows.Forms.TextBox txtCategorie;
        private System.Windows.Forms.TextBox txtBereidingstijd;
    }
}

