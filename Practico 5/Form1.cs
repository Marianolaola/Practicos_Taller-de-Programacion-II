using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            dataGridView1.Columns.Add("CApellido", "Apellido");
            dataGridView1.Columns.Add("CNombre", "Nombre");
            dataGridView1.Columns.Add("CFechaNacimiento", "Fecha Nacimiento");
            dataGridView1.Columns.Add("CSexo", "Sexo");
            dataGridView1.Columns.Add("CSaldo", "Saldo");
            dataGridView1.Columns.Add("CFoto", "Foto");
            dataGridView1.Columns.Add("CRuta", "Ruta");

            DataGridViewButtonColumn colBtn = new DataGridViewButtonColumn();
            colBtn.Name = "BEliminar";
            colBtn.HeaderText = "Acción";
            colBtn.Text = "Borrar";
            colBtn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(colBtn);

            dataGridView1.Columns["CApellido"].DefaultCellStyle.Font = new Font("papyrus", 8, FontStyle.Regular);
            dataGridView1.Columns["CNombre"].DefaultCellStyle.Font = new Font("papyrus", 8, FontStyle.Regular);
        }

      

        private void InitCustomLabelFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            int fontlength = Properties.Resources.papyrus.Length;
            byte[] fontdata = Properties.Resources.papyrus;
            System.IntPtr data = Marshal.AllocCoTaskMem(fontlength);
            Marshal.Copy(fontdata, 0, data, fontlength);
            pfc.AddMemoryFont(data, fontlength);
        }

        private void BFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = getImage.FileName;
                TxtFoto.Text = getImage.FileName;
            } else
            {
                MessageBox.Show("No se selecciono ninguna imagen", "Sin seleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TBNombre_TextChanged(object sender, EventArgs e)
        {
            
       
        }

        private void TBNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            } else {
                TextBox tb = sender as TextBox;

                if (tb.Text.Length == 0)
                {
                    e.KeyChar = char.ToUpper(e.KeyChar);
                }
                else
                {
                    e.KeyChar = char.ToLower(e.KeyChar); 
                }
            }
        }

        private void TBApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            } else {
                TextBox tb = sender as TextBox;

                if (tb.Text.Length == 0)
                {
                    e.KeyChar = char.ToUpper(e.KeyChar);
                } else {
                    e.KeyChar = char.ToLower(e.KeyChar);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();

            dataGridView1.Rows[n].Cells[0].Value = TBApellido.Text;
            dataGridView1.Rows[n].Cells[1].Value = TBNombre.Text;
            if (RBHombre.Checked)
            {
                dataGridView1.Rows[n].Cells[2].Value = RBHombre.Text;
            }
            else
            {
                if(RBMujer.Checked)
                {
                    dataGridView1.Rows[n].Cells[2].Value = RBMujer.Text;
                }
            }
            dataGridView1.Rows[n].Cells[3].Value = dateTimePicker1.Text;


            dataGridView1.Rows[n].Cells[4].Value = TBSueldo.Text;

            dataGridView1.Rows[n].Cells[5].Value = pictureBox1.ImageLocation;
            dataGridView1.Rows[n].Cells[6].Value = TxtFoto.Text;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["BEliminar"].Index)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
