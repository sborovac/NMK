namespace NMK
{
    partial class Naplata
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
            this.Back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gotovina = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Back);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.gotovina);
            this.groupBox1.Location = new System.Drawing.Point(73, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Naplata";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(27, 198);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(233, 54);
            this.Back.TabIndex = 2;
            this.Back.Text = "Nazad";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Plačanje na rate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gotovina
            // 
            this.gotovina.Location = new System.Drawing.Point(27, 37);
            this.gotovina.Name = "gotovina";
            this.gotovina.Size = new System.Drawing.Size(233, 54);
            this.gotovina.TabIndex = 0;
            this.gotovina.Text = "Gotovinsko Plačanje";
            this.gotovina.UseVisualStyleBackColor = true;
            this.gotovina.Click += new System.EventHandler(this.gotovina_Click);
            // 
            // Naplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 346);
            this.Controls.Add(this.groupBox1);
            this.Name = "Naplata";
            this.Text = "NMK";
            this.Load += new System.EventHandler(this.Naplata_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button gotovina;
        private System.Windows.Forms.Button Back;
    }
}