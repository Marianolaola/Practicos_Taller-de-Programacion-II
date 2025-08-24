using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctico_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtDesdeKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten números enteros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtHastaKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten números enteros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnGenerarFuncion_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtDesde.Text) || string.IsNullOrEmpty(txtHasta.Text)){

                MessageBox.Show("Por favor, complete ambos campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int desde = int.Parse(txtDesde.Text);
            int hasta = int.Parse(txtHasta.Text);

            if (desde > hasta)
            {
                MessageBox.Show("El valor de inicio debe ser mayor que el valor final", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = desde; i <= hasta; i++)
            {
                lista_Numeros.Items.Add(i);
            }
        }
    }
}
