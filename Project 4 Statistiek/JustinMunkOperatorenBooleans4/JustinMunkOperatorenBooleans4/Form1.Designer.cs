namespace JustinMunkOperatorenBooleans4
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
            this.btnForLus = new System.Windows.Forms.Button();
            this.btnWhileLus = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblAantal = new System.Windows.Forms.Label();
            this.txtAantal = new System.Windows.Forms.TextBox();
            this.pbxDobbelsteen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDobbelsteen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnForLus
            // 
            this.btnForLus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnForLus.ForeColor = System.Drawing.Color.Black;
            this.btnForLus.Location = new System.Drawing.Point(12, 163);
            this.btnForLus.Name = "btnForLus";
            this.btnForLus.Size = new System.Drawing.Size(236, 42);
            this.btnForLus.TabIndex = 0;
            this.btnForLus.Text = "Gooi For Lus";
            this.btnForLus.UseVisualStyleBackColor = false;
            this.btnForLus.Click += new System.EventHandler(this.btnForLus_Click);
            // 
            // btnWhileLus
            // 
            this.btnWhileLus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnWhileLus.Location = new System.Drawing.Point(254, 163);
            this.btnWhileLus.Name = "btnWhileLus";
            this.btnWhileLus.Size = new System.Drawing.Size(236, 42);
            this.btnWhileLus.TabIndex = 1;
            this.btnWhileLus.Text = "Gooi While Lus";
            this.btnWhileLus.UseVisualStyleBackColor = false;
            this.btnWhileLus.Click += new System.EventHandler(this.btnWhileLus_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReset.Location = new System.Drawing.Point(496, 163);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(236, 42);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblAantal
            // 
            this.lblAantal.AutoSize = true;
            this.lblAantal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAantal.Location = new System.Drawing.Point(248, 115);
            this.lblAantal.Name = "lblAantal";
            this.lblAantal.Size = new System.Drawing.Size(111, 32);
            this.lblAantal.TabIndex = 3;
            this.lblAantal.Text = "Aantal:";
            // 
            // txtAantal
            // 
            this.txtAantal.Location = new System.Drawing.Point(365, 125);
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.Size = new System.Drawing.Size(163, 22);
            this.txtAantal.TabIndex = 4;
            // 
            // pbxDobbelsteen
            // 
            this.pbxDobbelsteen.Image = global::JustinMunkOperatorenBooleans4.Properties.Resources.dobbelsteen;
            this.pbxDobbelsteen.Location = new System.Drawing.Point(297, -58);
            this.pbxDobbelsteen.Name = "pbxDobbelsteen";
            this.pbxDobbelsteen.Size = new System.Drawing.Size(231, 177);
            this.pbxDobbelsteen.TabIndex = 5;
            this.pbxDobbelsteen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 217);
            this.Controls.Add(this.pbxDobbelsteen);
            this.Controls.Add(this.txtAantal);
            this.Controls.Add(this.lblAantal);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnWhileLus);
            this.Controls.Add(this.btnForLus);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxDobbelsteen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnForLus;
        private System.Windows.Forms.Button btnWhileLus;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblAantal;
        private System.Windows.Forms.TextBox txtAantal;
        private System.Windows.Forms.PictureBox pbxDobbelsteen;
    }
}

