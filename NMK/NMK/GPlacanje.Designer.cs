namespace NMK
{
    partial class GPlacanje
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
            this.pregledi = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.IznosRacuna = new System.Windows.Forms.Label();
            this.IznosUplate = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Potvrdi = new System.Windows.Forms.Button();
            this.ostatak = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pregledi);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pregledi";
            // 
            // pregledi
            // 
            this.pregledi.Location = new System.Drawing.Point(6, 20);
            this.pregledi.Name = "pregledi";
            this.pregledi.Size = new System.Drawing.Size(204, 258);
            this.pregledi.TabIndex = 0;
            this.pregledi.Text = "";
            this.pregledi.TextChanged += new System.EventHandler(this.pregledi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vaš račun iznosi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Uplatite vaš račun";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(360, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "Potvrdi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IznosRacuna
            // 
            this.IznosRacuna.AutoSize = true;
            this.IznosRacuna.Location = new System.Drawing.Point(367, 108);
            this.IznosRacuna.Name = "IznosRacuna";
            this.IznosRacuna.Size = new System.Drawing.Size(0, 13);
            this.IznosRacuna.TabIndex = 6;
            // 
            // IznosUplate
            // 
            this.IznosUplate.Location = new System.Drawing.Point(360, 101);
            this.IznosUplate.Name = "IznosUplate";
            this.IznosUplate.Size = new System.Drawing.Size(100, 20);
            this.IznosUplate.TabIndex = 7;
            this.IznosUplate.TextChanged += new System.EventHandler(this.IznosUplate_TextChanged);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(15, 29);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(37, 13);
            this.id.TabIndex = 8;
            this.id.Text = "Vaš Id";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 9;
            // 
            // Potvrdi
            // 
            this.Potvrdi.Location = new System.Drawing.Point(75, 48);
            this.Potvrdi.Name = "Potvrdi";
            this.Potvrdi.Size = new System.Drawing.Size(115, 22);
            this.Potvrdi.TabIndex = 10;
            this.Potvrdi.Text = "Potvrdi";
            this.Potvrdi.UseVisualStyleBackColor = true;
            this.Potvrdi.Click += new System.EventHandler(this.Potvrdi_Click);
            // 
            // ostatak
            // 
            this.ostatak.AutoSize = true;
            this.ostatak.Location = new System.Drawing.Point(253, 143);
            this.ostatak.Name = "ostatak";
            this.ostatak.Size = new System.Drawing.Size(103, 13);
            this.ostatak.TabIndex = 11;
            this.ostatak.Text = "Preostalo da uplatite";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(363, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(96, 20);
            this.textBox3.TabIndex = 12;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(385, 304);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(98, 22);
            this.Back.TabIndex = 13;
            this.Back.Text = "Nazad";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // GPlaćanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 338);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.ostatak);
            this.Controls.Add(this.Potvrdi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.IznosUplate);
            this.Controls.Add(this.IznosRacuna);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "GPlaćanje";
            this.Text = "NMK";
            this.Load += new System.EventHandler(this.Gotovina_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox pregledi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label IznosRacuna;
        private System.Windows.Forms.TextBox IznosUplate;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Potvrdi;
        private System.Windows.Forms.Label ostatak;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Back;
    }
}