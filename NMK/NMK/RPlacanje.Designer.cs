namespace NMK
{
    partial class RPlacanje
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
            this.id = new System.Windows.Forms.Label();
            this.idnumber = new System.Windows.Forms.TextBox();
            this.pregledi = new System.Windows.Forms.GroupBox();
            this.checkup = new System.Windows.Forms.RichTextBox();
            this.iznosR = new System.Windows.Forms.Label();
            this.IznosUplate = new System.Windows.Forms.TextBox();
            this.Preostalo = new System.Windows.Forms.Label();
            this.ostatak = new System.Windows.Forms.TextBox();
            this.Uplata = new System.Windows.Forms.Label();
            this.UplataRacuna = new System.Windows.Forms.TextBox();
            this.Potvrda = new System.Windows.Forms.Button();
            this.Potvrdi = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.pregledi.SuspendLayout();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(40, 39);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(37, 13);
            this.id.TabIndex = 0;
            this.id.Text = "Vas Id";
            // 
            // idnumber
            // 
            this.idnumber.Location = new System.Drawing.Point(83, 32);
            this.idnumber.Name = "idnumber";
            this.idnumber.Size = new System.Drawing.Size(110, 20);
            this.idnumber.TabIndex = 1;
            this.idnumber.TextChanged += new System.EventHandler(this.idnumber_TextChanged);
            // 
            // pregledi
            // 
            this.pregledi.Controls.Add(this.checkup);
            this.pregledi.Location = new System.Drawing.Point(15, 84);
            this.pregledi.Name = "pregledi";
            this.pregledi.Size = new System.Drawing.Size(200, 262);
            this.pregledi.TabIndex = 2;
            this.pregledi.TabStop = false;
            this.pregledi.Text = "Pregledi";
            // 
            // checkup
            // 
            this.checkup.Location = new System.Drawing.Point(6, 19);
            this.checkup.Name = "checkup";
            this.checkup.Size = new System.Drawing.Size(186, 236);
            this.checkup.TabIndex = 0;
            this.checkup.Text = "";
            this.checkup.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // iznosR
            // 
            this.iznosR.AutoSize = true;
            this.iznosR.Location = new System.Drawing.Point(273, 165);
            this.iznosR.Name = "iznosR";
            this.iznosR.Size = new System.Drawing.Size(73, 13);
            this.iznosR.TabIndex = 3;
            this.iznosR.Text = "Iznos Racuna";
            // 
            // IznosUplate
            // 
            this.IznosUplate.Location = new System.Drawing.Point(380, 158);
            this.IznosUplate.Name = "IznosUplate";
            this.IznosUplate.Size = new System.Drawing.Size(121, 20);
            this.IznosUplate.TabIndex = 4;
            this.IznosUplate.TextChanged += new System.EventHandler(this.iznosUplate_TextChanged);
            // 
            // Preostalo
            // 
            this.Preostalo.AutoSize = true;
            this.Preostalo.Location = new System.Drawing.Point(273, 202);
            this.Preostalo.Name = "Preostalo";
            this.Preostalo.Size = new System.Drawing.Size(97, 13);
            this.Preostalo.TabIndex = 5;
            this.Preostalo.Text = "Preostalo za uplatu";
            // 
            // ostatak
            // 
            this.ostatak.Location = new System.Drawing.Point(380, 195);
            this.ostatak.Name = "ostatak";
            this.ostatak.Size = new System.Drawing.Size(121, 20);
            this.ostatak.TabIndex = 6;
            // 
            // Uplata
            // 
            this.Uplata.AutoSize = true;
            this.Uplata.Location = new System.Drawing.Point(273, 240);
            this.Uplata.Name = "Uplata";
            this.Uplata.Size = new System.Drawing.Size(38, 13);
            this.Uplata.TabIndex = 7;
            this.Uplata.Text = "Uplata";
            // 
            // UplataRacuna
            // 
            this.UplataRacuna.Location = new System.Drawing.Point(380, 233);
            this.UplataRacuna.Name = "UplataRacuna";
            this.UplataRacuna.Size = new System.Drawing.Size(121, 20);
            this.UplataRacuna.TabIndex = 8;
            // 
            // Potvrda
            // 
            this.Potvrda.Location = new System.Drawing.Point(384, 276);
            this.Potvrda.Name = "Potvrda";
            this.Potvrda.Size = new System.Drawing.Size(117, 28);
            this.Potvrda.TabIndex = 9;
            this.Potvrda.Text = "Potvrdi Uplatu";
            this.Potvrda.UseVisualStyleBackColor = true;
            this.Potvrda.Click += new System.EventHandler(this.Potvrda_Click);
            // 
            // Potvrdi
            // 
            this.Potvrdi.Location = new System.Drawing.Point(83, 58);
            this.Potvrdi.Name = "Potvrdi";
            this.Potvrdi.Size = new System.Drawing.Size(108, 20);
            this.Potvrdi.TabIndex = 10;
            this.Potvrdi.Text = "Potvdi";
            this.Potvrdi.UseVisualStyleBackColor = true;
            this.Potvrdi.Click += new System.EventHandler(this.Potvrdi_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(384, 319);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(117, 27);
            this.Back.TabIndex = 11;
            this.Back.Text = "Nazad";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // RPlacanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 351);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Potvrdi);
            this.Controls.Add(this.Potvrda);
            this.Controls.Add(this.UplataRacuna);
            this.Controls.Add(this.Uplata);
            this.Controls.Add(this.ostatak);
            this.Controls.Add(this.Preostalo);
            this.Controls.Add(this.IznosUplate);
            this.Controls.Add(this.iznosR);
            this.Controls.Add(this.pregledi);
            this.Controls.Add(this.idnumber);
            this.Controls.Add(this.id);
            this.Name = "RPlacanje";
            this.Text = "RPlacanje";
            this.Load += new System.EventHandler(this.RPlacanje_Load);
            this.pregledi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox idnumber;
        private System.Windows.Forms.GroupBox pregledi;
        private System.Windows.Forms.RichTextBox checkup;
        private System.Windows.Forms.Label iznosR;
        private System.Windows.Forms.TextBox IznosUplate;
        private System.Windows.Forms.Label Preostalo;
        private System.Windows.Forms.TextBox ostatak;
        private System.Windows.Forms.Label Uplata;
        private System.Windows.Forms.TextBox UplataRacuna;
        private System.Windows.Forms.Button Potvrda;
        private System.Windows.Forms.Button Potvrdi;
        private System.Windows.Forms.Button Back;
    }
}