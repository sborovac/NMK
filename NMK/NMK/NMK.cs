using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMK
{
    public partial class NMK : Form
    {
        public NMK()
        {
            InitializeComponent();
            this.Width = 500;
            this.Height = 500;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (username.Text[0] == 'D')
            {
                this.Hide();
                MeniDoc md = new MeniDoc();
                md.ShowDialog();
            }
            else if (username.Text[0] == 'P')
            {
                this.Hide();
                MeniPacient mp = new MeniPacient();
                mp.ShowDialog();
            }
            else if (username.Text[0] == 'O')
            {
                this.Hide();
                MeniObicni mo = new MeniObicni();
                mo.ShowDialog();
            }
            else MessageBox.Show("Greska pri unosu!");
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void NMK_Load(object sender, EventArgs e)
        {

        }

        private void NMK_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.DarkRed);
            Brush myBrush = new SolidBrush(Color.CornflowerBlue);
            Rectangle rect = new Rectangle(0, 0, 500,100);
            g.FillRectangle(myBrush, rect);
            Image newImage = Image.FromFile("../../Slika/img2.png");

            
            int x = 0;
            int y = 0;

            
            e.Graphics.DrawImage(newImage, x, y);

        }
    }
}
