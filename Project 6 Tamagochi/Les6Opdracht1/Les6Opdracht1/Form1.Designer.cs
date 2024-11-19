namespace Les6Opdracht1
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
            this.timerForLus = new System.Windows.Forms.Timer(this.components);
            this.pbScore = new System.Windows.Forms.ProgressBar();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timerForLus
            // 
            this.timerForLus.Tick += new System.EventHandler(this.timerForLus_Tick_1);
            // 
            // pbScore
            // 
            this.pbScore.Location = new System.Drawing.Point(69, 12);
            this.pbScore.Name = "pbScore";
            this.pbScore.Size = new System.Drawing.Size(654, 83);
            this.pbScore.TabIndex = 0;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(215, 126);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(349, 22);
            this.txtScore.TabIndex = 1;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(215, 215);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(363, 79);
            this.btnBereken.TabIndex = 2;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.pbScore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerForLus;
        private System.Windows.Forms.ProgressBar pbScore;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnBereken;
    }
}

