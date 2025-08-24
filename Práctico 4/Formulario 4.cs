using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Práctico_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten números enteros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void GenerarNúmeros(string tipo)
        {
            lista_Numeros.Items.Clear();
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
                switch (tipo)
                {
                    case "Todos":
                        lista_Numeros.Items.Add(i);
                        break;
                    case "Pares":
                        if (i % 2 == 0)
                        {
                            lista_Numeros.Items.Add(i);
                        }
                        break;
                    case "Impares":
                        if (i% 2 != 0)
                        {
                            lista_Numeros.Items.Add(i);
                        }
                        break;
                    case "Primos":
                        if (esPrimo(i))
                        {
                            lista_Numeros.Items.Add(i);
                        }
                        break;
                }
                
            }
        }

        private bool esPrimo(int n)
        {
            if (n < 2) return false;
            for (int j = 2; j <= Math.Sqrt(n); j++)
            {
                if (n % j == 0) return false;
            }
            return true;
        }

        private void btnPares_Click(object sender, EventArgs e)
        {
            GenerarNúmeros("Pares");
        }

        private void btnImpares_Click(object sender, EventArgs e)
        {
            GenerarNúmeros("Impares");
        }

        private void btnPrimos_Click(object sender, EventArgs e)
        {
            GenerarNúmeros("Primos");
        }

        private void btnGenerarFuncion_Click(object sender, EventArgs e)
        {
            GenerarNúmeros("Todos");
        }

        private void chartNumeros_Click(object sender, EventArgs e)
        {
            chartNumeros.Series.Clear();

            Series serie = new Series("Números");
            serie.ChartType = SeriesChartType.Column;
            foreach (var item in lista_Numeros.Items)
            {
                int valor = int.Parse(item.ToString());
                serie.Points.AddY(valor);
            }
            chartNumeros.Series.Add(serie);
        }
    }
}
