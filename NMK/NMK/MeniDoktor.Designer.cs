namespace NMK
{
    partial class MeniDoc
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.RegistracijaNovogKartona = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.RegistracijaNovogKartona);
            this.groupBox1.Location = new System.Drawing.Point(94, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meni";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "Izlaz";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Pretraga kartona pacijenta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RegistracijaNovogKartona
            // 
            this.RegistracijaNovogKartona.Location = new System.Drawing.Point(17, 120);
            this.RegistracijaNovogKartona.Name = "RegistracijaNovogKartona";
            this.RegistracijaNovogKartona.Size = new System.Drawing.Size(240, 42);
            this.RegistracijaNovogKartona.TabIndex = 0;
            this.RegistracijaNovogKartona.Text = "Registruj novi pregled";
            this.RegistracijaNovogKartona.UseVisualStyleBackColor = true;
            this.RegistracijaNovogKartona.Click += new System.EventHandler(this.RegistracijaNovogKartona_Click);
            // 
            // MeniDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 349);
            this.Controls.Add(this.groupBox1);
            this.Name = "MeniDoc";
            this.Text = "NMK";
            this.Load += new System.EventHandler(this.MeniDoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button RegistracijaNovogKartona;
        private System.Windows.Forms.Button button3;
    }
}