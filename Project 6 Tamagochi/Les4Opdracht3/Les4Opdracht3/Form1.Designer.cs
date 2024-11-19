namespace Les4Opdracht3
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
            this.components = new System.ComponentModel.Container();
            this.btnBereken = new System.Windows.Forms.Button();
            this.lblReeks1 = new System.Windows.Forms.Label();
            this.lblReeks2 = new System.Windows.Forms.Label();
            this.lblReeks3 = new System.Windows.Forms.Label();
            this.lblReeks4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbReeks4 = new Les4Opdracht3.CustomProgressBar();
            this.pbReeks3 = new Les4Opdracht3.CustomProgressBar();
            this.pbReeks2 = new Les4Opdracht3.CustomProgressBar();
            this.pbReeks1 = new Les4Opdracht3.CustomProgressBar();
            this.SuspendLayout();
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(232, 360);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(378, 63);
            this.btnBereken.TabIndex = 4;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // lblReeks1
            // 
            this.lblReeks1.AutoSize = true;
            this.lblReeks1.Location = new System.Drawing.Point(39, 33);
            this.lblReeks1.Name = "lblReeks1";
            this.lblReeks1.Size = new System.Drawing.Size(57, 16);
            this.lblReeks1.TabIndex = 5;
            this.lblReeks1.Text = "Reeks 1";
            // 
            // lblReeks2
            // 
            this.lblReeks2.AutoSize = true;
            this.lblReeks2.Location = new System.Drawing.Point(39, 128);
            this.lblReeks2.Name = "lblReeks2";
            this.lblReeks2.Size = new System.Drawing.Size(57, 16);
            this.lblReeks2.TabIndex = 6;
            this.lblReeks2.Text = "Reeks 2";
            // 
            // lblReeks3
            // 
            this.lblReeks3.AutoSize = true;
            this.lblReeks3.Location = new System.Drawing.Point(39, 217);
            this.lblReeks3.Name = "lblReeks3";
            this.lblReeks3.Size = new System.Drawing.Size(57, 16);
            this.lblReeks3.TabIndex = 7;
            this.lblReeks3.Text = "Reeks 3";
            // 
            // lblReeks4
            // 
            this.lblReeks4.AutoSize = true;
            this.lblReeks4.Location = new System.Drawing.Point(39, 299);
            this.lblReeks4.Name = "lblReeks4";
            this.lblReeks4.Size = new System.Drawing.Size(57, 16);
            this.lblReeks4.TabIndex = 8;
            this.lblReeks4.Text = "Reeks 4";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbReeks4
            // 
            this.pbReeks4.Location = new System.Drawing.Point(157, 266);
            this.pbReeks4.Maximum = 10;
            this.pbReeks4.Name = "pbReeks4";
            this.pbReeks4.Size = new System.Drawing.Size(524, 58);
            this.pbReeks4.TabIndex = 3;
            // 
            // pbReeks3
            // 
            this.pbReeks3.Location = new System.Drawing.Point(157, 186);
            this.pbReeks3.Maximum = 10;
            this.pbReeks3.Name = "pbReeks3";
            this.pbReeks3.Size = new System.Drawing.Size(524, 58);
            this.pbReeks3.TabIndex = 2;
            // 
            // pbReeks2
            // 
            this.pbReeks2.Location = new System.Drawing.Point(157, 98);
            this.pbReeks2.Maximum = 10;
            this.pbReeks2.Name = "pbReeks2";
            this.pbReeks2.Size = new System.Drawing.Size(524, 60);
            this.pbReeks2.TabIndex = 1;
            // 
            // pbReeks1
            // 
            this.pbReeks1.Location = new System.Drawing.Point(157, 12);
            this.pbReeks1.Maximum = 10;
            this.pbReeks1.Name = "pbReeks1";
            this.pbReeks1.Size = new System.Drawing.Size(524, 62);
            this.pbReeks1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblReeks4);
            this.Controls.Add(this.lblReeks3);
            this.Controls.Add(this.lblReeks2);
            this.Controls.Add(this.lblReeks1);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.pbReeks4);
            this.Controls.Add(this.pbReeks3);
            this.Controls.Add(this.pbReeks2);
            this.Controls.Add(this.pbReeks1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label lblReeks1;
        private System.Windows.Forms.Label lblReeks2;
        private System.Windows.Forms.Label lblReeks3;
        private System.Windows.Forms.Label lblReeks4;
        private CustomProgressBar pbReeks1;
        private CustomProgressBar pbReeks2;
        private CustomProgressBar pbReeks3;
        private CustomProgressBar pbReeks4;
        private System.Windows.Forms.Timer timer1;
    }
}

