using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelmaBorovac17813
{
    public partial class NMK : Form
    {
        public NMK()
        {
            InitializeComponent();
            this.Height = 400;
            this.Width = 400;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (username.Text[0] == 'D')
            {
                MeniDoc md = new MeniDoc();
                md.ShowDialog();
            }
            else if (username.Text[0] == 'P')
            {
                MeniPacient mp = new MeniPacient();
                mp.ShowDialog();
            }
            else if (username.Text[0] == 'O')
            {
                MeniObicni mo = new MeniObicni();
                mo.ShowDialog();
            }
            else
                MessageBox.Show("Neispravan username ili password");
           // Registracija forma = new Registracija();
           // forma.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void NMK_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.DarkRed);
            Brush myBrush = new SolidBrush(Color.CornflowerBlue);
           // g.DrawLine(myPen, 0, 100, 400, 100);
            Rectangle rect = new Rectangle(0, 0, 400, 100);
            g.FillRectangle(myBrush, rect);
            Image newImage = Image.FromFile();

            // Create coordinates for upper-left corner of image.
            int x = 0;
            int y = 0;

            // Draw image to screen.
            e.Graphics.DrawImage(newImage, x, y);
        }
    }
}
