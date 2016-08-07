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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
          
        }

        

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            juego ventanaEmpezar = new juego();

            ventanaEmpezar.Show();
        }
    }
}
