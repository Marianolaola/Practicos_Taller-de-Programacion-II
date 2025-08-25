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
    }
}
