namespace Practico_5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LFechaNacimiento = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.LApellido = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.TxtFoto = new System.Windows.Forms.TextBox();
            this.BFoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEliminar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::Practico_5.Properties.Resources.floppy;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(182, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImage = global::Practico_5.Properties.Resources.images;
            this.panel1.Controls.Add(this.LFechaNacimiento);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.TBApellido);
            this.panel1.Controls.Add(this.TBNombre);
            this.panel1.Controls.Add(this.LApellido);
            this.panel1.Controls.Add(this.LNombre);
            this.panel1.Controls.Add(this.TxtFoto);
            this.panel1.Controls.Add(this.BFoto);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(42, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 267);
            this.panel1.TabIndex = 0;
            // 
            // LFechaNacimiento
            // 
            this.LFechaNacimiento.AutoSize = true;
            this.LFechaNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.LFechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.LFechaNacimiento.Location = new System.Drawing.Point(23, 116);
            this.LFechaNacimiento.Name = "LFechaNacimiento";
            this.LFechaNacimiento.Size = new System.Drawing.Size(184, 33);
            this.LFechaNacimiento.TabIndex = 8;
            this.LFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(213, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(80, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // TBApellido
            // 
            this.TBApellido.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBApellido.Location = new System.Drawing.Point(125, 84);
            this.TBApellido.Multiline = true;
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(207, 20);
            this.TBApellido.TabIndex = 7;
            this.TBApellido.TextChanged += new System.EventHandler(this.TBApellido_TextChanged);
            this.TBApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBApellido_KeyPress);
            // 
            // TBNombre
            // 
            this.TBNombre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombre.Location = new System.Drawing.Point(125, 34);
            this.TBNombre.Multiline = true;
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(207, 20);
            this.TBNombre.TabIndex = 6;
            this.TBNombre.TextChanged += new System.EventHandler(this.TBNombre_TextChanged);
            this.TBNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNombre_KeyPress);
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.BackColor = System.Drawing.Color.Transparent;
            this.LApellido.ForeColor = System.Drawing.Color.White;
            this.LApellido.Location = new System.Drawing.Point(23, 76);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(102, 33);
            this.LApellido.TabIndex = 5;
            this.LApellido.Text = "Apellido: ";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.BackColor = System.Drawing.Color.Transparent;
            this.LNombre.ForeColor = System.Drawing.Color.White;
            this.LNombre.Location = new System.Drawing.Point(23, 26);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(96, 33);
            this.LNombre.TabIndex = 4;
            this.LNombre.Text = "Nombre: ";
            // 
            // TxtFoto
            // 
            this.TxtFoto.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFoto.Location = new System.Drawing.Point(125, 178);
            this.TxtFoto.Multiline = true;
            this.TxtFoto.Name = "TxtFoto";
            this.TxtFoto.Size = new System.Drawing.Size(207, 20);
            this.TxtFoto.TabIndex = 3;
            // 
            // BFoto
            // 
            this.BFoto.Font = new System.Drawing.Font("Arial", 8.25F);
            this.BFoto.ForeColor = System.Drawing.Color.Black;
            this.BFoto.Location = new System.Drawing.Point(29, 177);
            this.BFoto.Name = "BFoto";
            this.BFoto.Size = new System.Drawing.Size(75, 23);
            this.BFoto.TabIndex = 2;
            this.BFoto.Text = "Foto";
            this.BFoto.UseVisualStyleBackColor = true;
            this.BFoto.Click += new System.EventHandler(this.BFoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Practico_5.Properties.Resources.avatar;
            this.pictureBox1.Location = new System.Drawing.Point(587, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 121);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNombre,
            this.CApellido,
            this.CSexo,
            this.CFechaNacimiento,
            this.CEliminar,
            this.CSaldo,
            this.CFoto,
            this.CRuta});
            this.dataGridView1.Location = new System.Drawing.Point(12, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(830, 124);
            this.dataGridView1.TabIndex = 4;
            // 
            // CNombre
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Papyrus", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.CNombre.DefaultCellStyle = dataGridViewCellStyle1;
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.Name = "CNombre";
            // 
            // CApellido
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Papyrus", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.CApellido.DefaultCellStyle = dataGridViewCellStyle2;
            this.CApellido.HeaderText = "Apellido";
            this.CApellido.Name = "CApellido";
            // 
            // CSexo
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.CSexo.DefaultCellStyle = dataGridViewCellStyle3;
            this.CSexo.HeaderText = "Sexo";
            this.CSexo.Name = "CSexo";
            // 
            // CFechaNacimiento
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.CFechaNacimiento.DefaultCellStyle = dataGridViewCellStyle4;
            this.CFechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.CFechaNacimiento.Name = "CFechaNacimiento";
            // 
            // CEliminar
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.CEliminar.DefaultCellStyle = dataGridViewCellStyle5;
            this.CEliminar.HeaderText = "Eliminar";
            this.CEliminar.Name = "CEliminar";
            // 
            // CSaldo
            // 
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.CSaldo.DefaultCellStyle = dataGridViewCellStyle6;
            this.CSaldo.HeaderText = "Saldo";
            this.CSaldo.Name = "CSaldo";
            // 
            // CFoto
            // 
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.CFoto.DefaultCellStyle = dataGridViewCellStyle7;
            this.CFoto.HeaderText = "Foto";
            this.CFoto.Name = "CFoto";
            // 
            // CRuta
            // 
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.CRuta.DefaultCellStyle = dataGridViewCellStyle8;
            this.CRuta.HeaderText = "Ruta";
            this.CRuta.Name = "CRuta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Practico_5.Properties.Resources.cuadros_negros;
            this.ClientSize = new System.Drawing.Size(854, 431);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Formulario con Grid";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox TxtFoto;
        private System.Windows.Forms.Button BFoto;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LFechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRuta;
    }
}

