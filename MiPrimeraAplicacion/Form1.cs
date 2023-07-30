using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraAplicacion
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }

        private void Formulario_FormClosed (object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau chau...");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparo el evento Click", "Atención");
            //this.BackColor = Color.LightGoldenrodYellow;
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el botón Izquierdo", "Atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el Botón Derecho", "Atención");
            else
            if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el botón del Medio", "Atención");
        }

        private void lbl1_MouseMove(object sender, MouseEventArgs e)
        {
            lbl1.BackColor= Color.Cyan;
            lbl1.Cursor = Cursors.Hand;
        }

        private void lbl1_MouseLeave(object sender, EventArgs e)
        {
            lbl1.BackColor = System.Drawing.SystemColors.Control;
            lbl1.Cursor = Cursors.Arrow;
        }
    }
}
