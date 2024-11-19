namespace JLes2Opdracht1
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
            this.btnInvoer = new System.Windows.Forms.Button();
            this.txtAantal = new System.Windows.Forms.TextBox();
            this.lblAantalStudenten = new System.Windows.Forms.Label();
            this.lbxOverzicht = new System.Windows.Forms.ListBox();
            this.btnOverzicht = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInvoer
            // 
            this.btnInvoer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoer.Location = new System.Drawing.Point(597, 238);
            this.btnInvoer.Name = "btnInvoer";
            this.btnInvoer.Size = new System.Drawing.Size(180, 173);
            this.btnInvoer.TabIndex = 13;
            this.btnInvoer.Text = "Invoeren";
            this.btnInvoer.UseVisualStyleBackColor = true;
            this.btnInvoer.Click += new System.EventHandler(this.btnInvoer_Click);
            // 
            // txtAantal
            // 
            this.txtAantal.Location = new System.Drawing.Point(129, 392);
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.ReadOnly = true;
            this.txtAantal.Size = new System.Drawing.Size(361, 22);
            this.txtAantal.TabIndex = 12;
            this.txtAantal.TextChanged += new System.EventHandler(this.txtAantal_TextChanged);
            // 
            // lblAantalStudenten
            // 
            this.lblAantalStudenten.AutoSize = true;
            this.lblAantalStudenten.Location = new System.Drawing.Point(12, 395);
            this.lblAantalStudenten.Name = "lblAantalStudenten";
            this.lblAantalStudenten.Size = new System.Drawing.Size(111, 16);
            this.lblAantalStudenten.TabIndex = 11;
            this.lblAantalStudenten.Text = "Aantal Studenten:";
            this.lblAantalStudenten.Click += new System.EventHandler(this.lblAantalStudenten_Click);
            // 
            // lbxOverzicht
            // 
            this.lbxOverzicht.FormattingEnabled = true;
            this.lbxOverzicht.ItemHeight = 16;
            this.lbxOverzicht.Location = new System.Drawing.Point(12, 37);
            this.lbxOverzicht.Name = "lbxOverzicht";
            this.lbxOverzicht.Size = new System.Drawing.Size(534, 340);
            this.lbxOverzicht.TabIndex = 10;
            this.lbxOverzicht.SelectedIndexChanged += new System.EventHandler(this.lbxOverzicht_SelectedIndexChanged);
            // 
            // btnOverzicht
            // 
            this.btnOverzicht.Location = new System.Drawing.Point(574, 46);
            this.btnOverzicht.Name = "btnOverzicht";
            this.btnOverzicht.Size = new System.Drawing.Size(214, 46);
            this.btnOverzicht.TabIndex = 9;
            this.btnOverzicht.Text = "Overzicht Studenten";
            this.btnOverzicht.UseVisualStyleBackColor = true;
            this.btnOverzicht.Click += new System.EventHandler(this.btnOverzicht_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInvoer);
            this.Controls.Add(this.txtAantal);
            this.Controls.Add(this.lblAantalStudenten);
            this.Controls.Add(this.lbxOverzicht);
            this.Controls.Add(this.btnOverzicht);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInvoer;
        private System.Windows.Forms.TextBox txtAantal;
        private System.Windows.Forms.Label lblAantalStudenten;
        private System.Windows.Forms.ListBox lbxOverzicht;
        private System.Windows.Forms.Button btnOverzicht;
    }
}

