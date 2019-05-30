namespace SelmaBorovac17813
{
    partial class NMK
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
            this.un = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.registracija = new System.Windows.Forms.GroupBox();
            this.password = new System.Windows.Forms.TextBox();
            this.pw = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Button();
            this.registracija.SuspendLayout();
            this.SuspendLayout();
            // 
            // un
            // 
            this.un.AutoSize = true;
            this.un.BackColor = System.Drawing.Color.Transparent;
            this.un.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.un.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.un.Location = new System.Drawing.Point(19, 40);
            this.un.Name = "un";
            this.un.Size = new System.Drawing.Size(63, 17);
            this.un.TabIndex = 0;
            this.un.Text = "Username";
            this.un.Click += new System.EventHandler(this.label1_Click);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.username.Location = new System.Drawing.Point(88, 40);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(162, 20);
            this.username.TabIndex = 1;
            this.username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // registracija
            // 
            this.registracija.BackColor = System.Drawing.Color.Transparent;
            this.registracija.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.registracija.Controls.Add(this.password);
            this.registracija.Controls.Add(this.pw);
            this.registracija.Controls.Add(this.username);
            this.registracija.Controls.Add(this.un);
            this.registracija.ForeColor = System.Drawing.Color.Black;
            this.registracija.Location = new System.Drawing.Point(65, 132);
            this.registracija.Name = "registracija";
            this.registracija.Size = new System.Drawing.Size(266, 133);
            this.registracija.TabIndex = 2;
            this.registracija.TabStop = false;
            this.registracija.Text = "Registracija";
            this.registracija.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.password.Location = new System.Drawing.Point(88, 80);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(162, 20);
            this.password.TabIndex = 3;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // pw
            // 
            this.pw.AutoSize = true;
            this.pw.BackColor = System.Drawing.Color.Transparent;
            this.pw.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pw.Location = new System.Drawing.Point(19, 80);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(60, 17);
            this.pw.TabIndex = 2;
            this.pw.Text = "Password";
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.White;
            this.register.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.register.Location = new System.Drawing.Point(128, 271);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(119, 26);
            this.register.TabIndex = 4;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // NMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(420, 321);
            this.Controls.Add(this.register);
            this.Controls.Add(this.registracija);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Name = "NMK";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "NMK";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.NMK_Paint);
            this.registracija.ResumeLayout(false);
            this.registracija.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label un;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.GroupBox registracija;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label pw;
    }
}

