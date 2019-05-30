namespace NMK
{
    partial class MeniPacient
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Naplata = new System.Windows.Forms.Button();
            this.PregledPregledaPacijenta = new System.Windows.Forms.Button();
            this.PretragaKartonaPacijenta = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Back);
            this.groupBox1.Controls.Add(this.Naplata);
            this.groupBox1.Controls.Add(this.PregledPregledaPacijenta);
            this.groupBox1.Controls.Add(this.PretragaKartonaPacijenta);
            this.groupBox1.Location = new System.Drawing.Point(64, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meni";
            // 
            // Naplata
            // 
            this.Naplata.Location = new System.Drawing.Point(20, 137);
            this.Naplata.Name = "Naplata";
            this.Naplata.Size = new System.Drawing.Size(231, 53);
            this.Naplata.TabIndex = 2;
            this.Naplata.Text = "Naplata";
            this.Naplata.UseVisualStyleBackColor = true;
            this.Naplata.Click += new System.EventHandler(this.Naplata_Click);
            // 
            // PregledPregledaPacijenta
            // 
            this.PregledPregledaPacijenta.Location = new System.Drawing.Point(20, 78);
            this.PregledPregledaPacijenta.Name = "PregledPregledaPacijenta";
            this.PregledPregledaPacijenta.Size = new System.Drawing.Size(231, 53);
            this.PregledPregledaPacijenta.TabIndex = 1;
            this.PregledPregledaPacijenta.Text = "Pregled pregleda pacijenta";
            this.PregledPregledaPacijenta.UseVisualStyleBackColor = true;
            // 
            // PretragaKartonaPacijenta
            // 
            this.PretragaKartonaPacijenta.Location = new System.Drawing.Point(20, 19);
            this.PretragaKartonaPacijenta.Name = "PretragaKartonaPacijenta";
            this.PretragaKartonaPacijenta.Size = new System.Drawing.Size(231, 53);
            this.PretragaKartonaPacijenta.TabIndex = 0;
            this.PretragaKartonaPacijenta.Text = "Pretraga kartona pacijenta";
            this.PretragaKartonaPacijenta.UseVisualStyleBackColor = true;
            this.PretragaKartonaPacijenta.Click += new System.EventHandler(this.PretragaKartonaPacijenta_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(20, 196);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(231, 53);
            this.Back.TabIndex = 3;
            this.Back.Text = "Izlaz";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // MeniPacient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 344);
            this.Controls.Add(this.groupBox1);
            this.Name = "MeniPacient";
            this.Text = "NMK";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button PregledPregledaPacijenta;
        private System.Windows.Forms.Button PretragaKartonaPacijenta;
        private System.Windows.Forms.Button Naplata;
        private System.Windows.Forms.Button Back;
    }
}