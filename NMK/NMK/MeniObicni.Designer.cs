namespace NMK
{
    partial class MeniObicni
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
            this.registrujPacijenta = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.naplata = new System.Windows.Forms.Button();
            this.kreirajKarton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.registrujPacijenta);
            this.groupBox1.Controls.Add(this.exit);
            this.groupBox1.Controls.Add(this.naplata);
            this.groupBox1.Controls.Add(this.kreirajKarton);
            this.groupBox1.Location = new System.Drawing.Point(100, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meni";
            // 
            // registrujPacijenta
            // 
            this.registrujPacijenta.Location = new System.Drawing.Point(29, 37);
            this.registrujPacijenta.Name = "registrujPacijenta";
            this.registrujPacijenta.Size = new System.Drawing.Size(217, 35);
            this.registrujPacijenta.TabIndex = 0;
            this.registrujPacijenta.Text = "Registruj Pacijenta";
            this.registrujPacijenta.UseVisualStyleBackColor = true;
            this.registrujPacijenta.Click += new System.EventHandler(this.registrujPacijenta_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(29, 212);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(217, 35);
            this.exit.TabIndex = 3;
            this.exit.Text = "Izlaz";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // naplata
            // 
            this.naplata.Location = new System.Drawing.Point(29, 155);
            this.naplata.Name = "naplata";
            this.naplata.Size = new System.Drawing.Size(217, 35);
            this.naplata.TabIndex = 2;
            this.naplata.Text = "Naplata";
            this.naplata.UseVisualStyleBackColor = true;
            this.naplata.Click += new System.EventHandler(this.naplata_Click);
            // 
            // kreirajKarton
            // 
            this.kreirajKarton.Location = new System.Drawing.Point(29, 94);
            this.kreirajKarton.Name = "kreirajKarton";
            this.kreirajKarton.Size = new System.Drawing.Size(217, 35);
            this.kreirajKarton.TabIndex = 1;
            this.kreirajKarton.Text = "Kreiraj karton pacijenta";
            this.kreirajKarton.UseVisualStyleBackColor = true;
            this.kreirajKarton.Click += new System.EventHandler(this.kreirajKarton_Click);
            // 
            // MeniObicni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 345);
            this.Controls.Add(this.groupBox1);
            this.Name = "MeniObicni";
            this.Text = "NMK";
            this.Load += new System.EventHandler(this.MeniObicni_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button naplata;
        private System.Windows.Forms.Button kreirajKarton;
        private System.Windows.Forms.Button registrujPacijenta;
    }
}