namespace Les2Opdracht2
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
            this.lbxOverzicht = new System.Windows.Forms.ListBox();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxOverzicht
            // 
            this.lbxOverzicht.FormattingEnabled = true;
            this.lbxOverzicht.ItemHeight = 16;
            this.lbxOverzicht.Location = new System.Drawing.Point(55, 12);
            this.lbxOverzicht.Name = "lbxOverzicht";
            this.lbxOverzicht.Size = new System.Drawing.Size(666, 308);
            this.lbxOverzicht.TabIndex = 0;
            this.lbxOverzicht.SelectedIndexChanged += new System.EventHandler(this.lbxOverzicht_SelectedIndexChanged);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(458, 342);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(288, 64);
            this.btnVerwijder.TabIndex = 1;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.lbxOverzicht);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxOverzicht;
        private System.Windows.Forms.Button btnVerwijder;
    }
}

