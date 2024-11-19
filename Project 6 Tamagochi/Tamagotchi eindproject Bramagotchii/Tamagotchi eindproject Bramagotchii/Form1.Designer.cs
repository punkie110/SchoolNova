namespace Tamagotchi_eindproject_Bramagotchii
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
            this.pbGezondheid = new System.Windows.Forms.ProgressBar();
            this.pbEten = new System.Windows.Forms.ProgressBar();
            this.pbDrinken = new System.Windows.Forms.ProgressBar();
            this.btnEten = new System.Windows.Forms.Button();
            this.btnDrinken = new System.Windows.Forms.Button();
            this.tmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.lblEten = new System.Windows.Forms.Label();
            this.lblDrinken = new System.Windows.Forms.Label();
            this.lblGezondheid = new System.Windows.Forms.Label();
            this.pnlTuto1 = new System.Windows.Forms.Panel();
            this.pnlTuto2 = new System.Windows.Forms.Panel();
            this.lblTuto1 = new System.Windows.Forms.Label();
            this.lblTuto2 = new System.Windows.Forms.Label();
            this.lblPunten = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.pnlBegin = new System.Windows.Forms.Panel();
            this.pbxBegin = new System.Windows.Forms.PictureBox();
            this.pbxBram = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlTuto1.SuspendLayout();
            this.pnlTuto2.SuspendLayout();
            this.pnlBegin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBegin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBram)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGezondheid
            // 
            this.pbGezondheid.Location = new System.Drawing.Point(188, 36);
            this.pbGezondheid.Name = "pbGezondheid";
            this.pbGezondheid.Size = new System.Drawing.Size(409, 48);
            this.pbGezondheid.TabIndex = 0;
            // 
            // pbEten
            // 
            this.pbEten.Location = new System.Drawing.Point(12, 114);
            this.pbEten.Name = "pbEten";
            this.pbEten.Size = new System.Drawing.Size(263, 43);
            this.pbEten.TabIndex = 2;
            // 
            // pbDrinken
            // 
            this.pbDrinken.Location = new System.Drawing.Point(525, 114);
            this.pbDrinken.Name = "pbDrinken";
            this.pbDrinken.Size = new System.Drawing.Size(263, 43);
            this.pbDrinken.TabIndex = 3;
            // 
            // btnEten
            // 
            this.btnEten.Location = new System.Drawing.Point(55, 195);
            this.btnEten.Name = "btnEten";
            this.btnEten.Size = new System.Drawing.Size(171, 112);
            this.btnEten.TabIndex = 4;
            this.btnEten.Text = "Geef Voedsel";
            this.btnEten.UseVisualStyleBackColor = true;
            this.btnEten.Click += new System.EventHandler(this.btnEten_Click);
            // 
            // btnDrinken
            // 
            this.btnDrinken.Location = new System.Drawing.Point(581, 195);
            this.btnDrinken.Name = "btnDrinken";
            this.btnDrinken.Size = new System.Drawing.Size(171, 112);
            this.btnDrinken.TabIndex = 5;
            this.btnDrinken.Text = "Geef Drinken";
            this.btnDrinken.UseVisualStyleBackColor = true;
            this.btnDrinken.Click += new System.EventHandler(this.btnDrinken_Click);
            // 
            // tmrCountdown
            // 
            this.tmrCountdown.Tick += new System.EventHandler(this.tmrCountdown_Tick);
            // 
            // lblEten
            // 
            this.lblEten.AutoSize = true;
            this.lblEten.Location = new System.Drawing.Point(124, 176);
            this.lblEten.Name = "lblEten";
            this.lblEten.Size = new System.Drawing.Size(34, 16);
            this.lblEten.TabIndex = 6;
            this.lblEten.Text = "Eten";
            // 
            // lblDrinken
            // 
            this.lblDrinken.AutoSize = true;
            this.lblDrinken.Location = new System.Drawing.Point(642, 176);
            this.lblDrinken.Name = "lblDrinken";
            this.lblDrinken.Size = new System.Drawing.Size(53, 16);
            this.lblDrinken.TabIndex = 7;
            this.lblDrinken.Text = "Drinken";
            // 
            // lblGezondheid
            // 
            this.lblGezondheid.AutoSize = true;
            this.lblGezondheid.Location = new System.Drawing.Point(354, 87);
            this.lblGezondheid.Name = "lblGezondheid";
            this.lblGezondheid.Size = new System.Drawing.Size(78, 16);
            this.lblGezondheid.TabIndex = 8;
            this.lblGezondheid.Text = "gezondheid";
            // 
            // pnlTuto1
            // 
            this.pnlTuto1.Controls.Add(this.lblTuto1);
            this.pnlTuto1.Location = new System.Drawing.Point(45, 314);
            this.pnlTuto1.Name = "pnlTuto1";
            this.pnlTuto1.Size = new System.Drawing.Size(181, 124);
            this.pnlTuto1.TabIndex = 11;
            // 
            // pnlTuto2
            // 
            this.pnlTuto2.Controls.Add(this.lblTuto2);
            this.pnlTuto2.Location = new System.Drawing.Point(581, 310);
            this.pnlTuto2.Name = "pnlTuto2";
            this.pnlTuto2.Size = new System.Drawing.Size(207, 128);
            this.pnlTuto2.TabIndex = 12;
            // 
            // lblTuto1
            // 
            this.lblTuto1.AutoSize = true;
            this.lblTuto1.Location = new System.Drawing.Point(3, -4);
            this.lblTuto1.Name = "lblTuto1";
            this.lblTuto1.Size = new System.Drawing.Size(168, 128);
            this.lblTuto1.TabIndex = 13;
            this.lblTuto1.Text = "\r\n\r\n^^^^^^^^^\r\nHoi! Ik ben Bram!\r\n Je kan hier drukken om mij\r\n eten te geven!\r\n " +
    "of aan de andere kant om \r\ndrinken te geven!";
            // 
            // lblTuto2
            // 
            this.lblTuto2.AutoSize = true;
            this.lblTuto2.Location = new System.Drawing.Point(3, 4);
            this.lblTuto2.Name = "lblTuto2";
            this.lblTuto2.Size = new System.Drawing.Size(183, 112);
            this.lblTuto2.TabIndex = 0;
            this.lblTuto2.Text = "Hieronder staan je punten!\r\nZorg dat je zo veel mogelijk\r\n punten krijgt!\r\nAls mi" +
    "jn gezondheidsbalk\r\n helemaal\r\nleeg is dan verlies je het spel!\r\nvvvvvvvvvvvvv";
            // 
            // lblPunten
            // 
            this.lblPunten.AutoSize = true;
            this.lblPunten.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunten.Location = new System.Drawing.Point(630, 459);
            this.lblPunten.Name = "lblPunten";
            this.lblPunten.Size = new System.Drawing.Size(104, 31);
            this.lblPunten.TabIndex = 13;
            this.lblPunten.Text = "Punten:";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(677, 502);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(28, 31);
            this.lblPoints.TabIndex = 14;
            this.lblPoints.Text = "0";
            // 
            // pnlBegin
            // 
            this.pnlBegin.Controls.Add(this.btnStart);
            this.pnlBegin.Controls.Add(this.pbxBegin);
            this.pnlBegin.Location = new System.Drawing.Point(-1, 0);
            this.pnlBegin.Name = "pnlBegin";
            this.pnlBegin.Size = new System.Drawing.Size(806, 551);
            this.pnlBegin.TabIndex = 15;
            // 
            // pbxBegin
            // 
            this.pbxBegin.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbxBegin.Image = global::Tamagotchi_eindproject_Bramagotchii.Properties.Resources.Bramagotchi;
            this.pbxBegin.Location = new System.Drawing.Point(-6, 16);
            this.pbxBegin.Name = "pbxBegin";
            this.pbxBegin.Size = new System.Drawing.Size(809, 534);
            this.pbxBegin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBegin.TabIndex = 0;
            this.pbxBegin.TabStop = false;
            // 
            // pbxBram
            // 
            this.pbxBram.Image = global::Tamagotchi_eindproject_Bramagotchii.Properties.Resources.BramEureka;
            this.pbxBram.Location = new System.Drawing.Point(243, 163);
            this.pbxBram.Name = "pbxBram";
            this.pbxBram.Size = new System.Drawing.Size(332, 275);
            this.pbxBram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBram.TabIndex = 9;
            this.pbxBram.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.GhostWhite;
            this.btnStart.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnStart.Location = new System.Drawing.Point(184, 379);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(462, 153);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.pnlBegin);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblPunten);
            this.Controls.Add(this.pnlTuto2);
            this.Controls.Add(this.pnlTuto1);
            this.Controls.Add(this.pbxBram);
            this.Controls.Add(this.lblGezondheid);
            this.Controls.Add(this.lblDrinken);
            this.Controls.Add(this.lblEten);
            this.Controls.Add(this.btnDrinken);
            this.Controls.Add(this.btnEten);
            this.Controls.Add(this.pbDrinken);
            this.Controls.Add(this.pbEten);
            this.Controls.Add(this.pbGezondheid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlTuto1.ResumeLayout(false);
            this.pnlTuto1.PerformLayout();
            this.pnlTuto2.ResumeLayout(false);
            this.pnlTuto2.PerformLayout();
            this.pnlBegin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBegin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbGezondheid;
        private System.Windows.Forms.ProgressBar pbEten;
        private System.Windows.Forms.ProgressBar pbDrinken;
        private System.Windows.Forms.Button btnEten;
        private System.Windows.Forms.Button btnDrinken;
        private System.Windows.Forms.Timer tmrCountdown;
        private System.Windows.Forms.Label lblEten;
        private System.Windows.Forms.Label lblDrinken;
        private System.Windows.Forms.Label lblGezondheid;
        private System.Windows.Forms.PictureBox pbxBram;
        private System.Windows.Forms.Panel pnlTuto1;
        private System.Windows.Forms.Panel pnlTuto2;
        private System.Windows.Forms.Label lblTuto1;
        private System.Windows.Forms.Label lblTuto2;
        private System.Windows.Forms.Label lblPunten;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Panel pnlBegin;
        private System.Windows.Forms.PictureBox pbxBegin;
        private System.Windows.Forms.Button btnStart;
    }
}

