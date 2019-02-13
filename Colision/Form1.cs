using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colision
{
    public partial class Form1 : Form
    {

        private bool seMueve = false;
        private int ofsetx;
        private int ofsety;

        public Form1()
        {
            InitializeComponent();
        }
        

        private void moverArriba(object sender, MouseEventArgs e)
        {
            seMueve = true;
        }


        private void moverIzq(object sender, MouseEventArgs e)
        {
            seMueve = true;
        }

        private void moverDer(object sender, MouseEventArgs e)
        {
            seMueve = true;
        }

        private void imgMoverMouse(object sender, MouseEventArgs e)
        {
            Control ctr = sender as Control;
            if (seMueve)
            {
                Point P1 = ctr.PointToScreen(e.Location);
                Point P2 = ctr.Parent.PointToClient(P1);
                ctr.Location = P2;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            seMueve = true;
            ofsetx = e.X;
            ofsety = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (seMueve)
            {
                pictureBox1.Left += e.X - ofsetx;
                pictureBox1.Top += e.Y - ofsety;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            int locX = 0;
            int locy = 0;

            int loc2x = 0;
            int loc2y = 0;

            if (e.Button == MouseButtons.Left) {
                seMueve = false;

                locX = pictureBox1.Location.X + pictureBox1.Width;
                locy = pictureBox1.Location.Y + pictureBox1.Height;

                loc2x = pictureBox1.Location.X + pictureBox2.Width;
                loc2y = pictureBox1.Location.Y + pictureBox2.Height;

                if (locX < loc2X) {
                     }

            }
        }
    }
}
