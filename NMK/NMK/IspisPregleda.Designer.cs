namespace NMK
{
    partial class IspisPregleda
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
            this.PreglediPacijenta = new System.Windows.Forms.RichTextBox();
            this.Nazad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.idPacijenta = new System.Windows.Forms.TextBox();
            this.Potvrdi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PreglediPacijenta);
            this.groupBox1.Location = new System.Drawing.Point(184, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pregledi";
            // 
            // PreglediPacijenta
            // 
            this.PreglediPacijenta.Location = new System.Drawing.Point(14, 22);
            this.PreglediPacijenta.Name = "PreglediPacijenta";
            this.PreglediPacijenta.Size = new System.Drawing.Size(241, 248);
            this.PreglediPacijenta.TabIndex = 0;
            this.PreglediPacijenta.Text = "";
            // 
            // Nazad
            // 
            this.Nazad.Location = new System.Drawing.Point(328, 288);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(123, 32);
            this.Nazad.TabIndex = 1;
            this.Nazad.Text = "Nazad";
            this.Nazad.UseVisualStyleBackColor = true;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vas ID";
            // 
            // idPacijenta
            // 
            this.idPacijenta.Location = new System.Drawing.Point(71, 43);
            this.idPacijenta.Name = "idPacijenta";
            this.idPacijenta.Size = new System.Drawing.Size(95, 20);
            this.idPacijenta.TabIndex = 3;
            // 
            // Potvrdi
            // 
            this.Potvrdi.Location = new System.Drawing.Point(71, 69);
            this.Potvrdi.Name = "Potvrdi";
            this.Potvrdi.Size = new System.Drawing.Size(94, 20);
            this.Potvrdi.TabIndex = 4;
            this.Potvrdi.Text = "Potvrdi";
            this.Potvrdi.UseVisualStyleBackColor = true;
            this.Potvrdi.Click += new System.EventHandler(this.Potvrdi_Click);
            // 
            // IspisPregleda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 331);
            this.Controls.Add(this.Potvrdi);
            this.Controls.Add(this.idPacijenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.groupBox1);
            this.Name = "IspisPregleda";
            this.Text = "IspisPregleda";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox PreglediPacijenta;
        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idPacijenta;
        private System.Windows.Forms.Button Potvrdi;
    }
}