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
            this.components = new System.ComponentModel.Container();
            this.pbxDobbel = new System.Windows.Forms.PictureBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbDobbel = new Les5Opdracht2.CustomProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDobbel)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxDobbel
            // 
            this.pbxDobbel.Image = global::Les5Opdracht2.Properties.Resources.Dobbelsteen_6;
            this.pbxDobbel.Location = new System.Drawing.Point(269, 127);
            this.pbxDobbel.Name = "pbxDobbel";
            this.pbxDobbel.Size = new System.Drawing.Size(250, 250);
            this.pbxDobbel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDobbel.TabIndex = 1;
            this.pbxDobbel.TabStop = false;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(253, 393);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(300, 45);
            this.btnBereken.TabIndex = 2;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbDobbel
            // 
            this.pbDobbel.Location = new System.Drawing.Point(131, 31);
            this.pbDobbel.Maximum = 6;
            this.pbDobbel.Name = "pbDobbel";
            this.pbDobbel.Size = new System.Drawing.Size(530, 90);
            this.pbDobbel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.pbxDobbel);
            this.Controls.Add(this.pbDobbel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxDobbel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Les5Opdracht2.CustomProgressBar pbDobbel;
        private System.Windows.Forms.PictureBox pbxDobbel;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Timer timer1;
    }
}

