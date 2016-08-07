using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Loteria
{
    public partial class juego : Form
    {
        public juego()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("volteada.jpg");
            pictureBox2.Image = Image.FromFile("2.jpg");
            pictureBox3.Image = Image.FromFile("2.jpg");
            pictureBox4.Image = Image.FromFile("6.jpg");
            pictureBox5.Image = Image.FromFile("26.jpg");
            pictureBox6.Image = Image.FromFile("29.jpg");
            pictureBox34.Image = Image.FromFile("30.jpg");
            pictureBox33.Image = Image.FromFile("32.jpg");
            pictureBox32.Image = Image.FromFile("33.jpg");
            pictureBox31.Image = Image.FromFile("34.jpg");
        }

        private void juego_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
