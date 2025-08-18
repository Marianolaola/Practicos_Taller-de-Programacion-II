namespace Practico_2
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
            this.tEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.tApellido = new System.Windows.Forms.TextBox();
            this.LNya = new System.Windows.Forms.Label();
            this.LModificar = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.TDni = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LTarjeta = new System.Windows.Forms.Label();
            this.CBMastercard = new System.Windows.Forms.CheckBox();
            this.CBVisa = new System.Windows.Forms.CheckBox();
            this.CBNaranja = new System.Windows.Forms.CheckBox();
            this.TTelefono = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.LNuevocliente = new System.Windows.Forms.Label();
            this.RBVaron = new System.Windows.Forms.RadioButton();
            this.RBMujer = new System.Windows.Forms.RadioButton();
            this.BSalir = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tEliminar
            // 
            this.tEliminar.Image = global::Practico_2.Properties.Resources.delete_delete_deleteusers_delete_male_user_maleclient_2348_1_;
            this.tEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tEliminar.Location = new System.Drawing.Point(168, 397);
            this.tEliminar.Name = "tEliminar";
            this.tEliminar.Size = new System.Drawing.Size(104, 56);
            this.tEliminar.TabIndex = 1;
            this.tEliminar.Text = "Eliminar";
            this.tEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tEliminar.UseVisualStyleBackColor = true;
            this.tEliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(90, 93);
            this.TNombre.Multiline = true;
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(113, 22);
            this.TNombre.TabIndex = 4;
            this.TNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNombre_KeyPress);
            // 
            // tApellido
            // 
            this.tApellido.Location = new System.Drawing.Point(90, 133);
            this.tApellido.Multiline = true;
            this.tApellido.Name = "tApellido";
            this.tApellido.Size = new System.Drawing.Size(113, 22);
            this.tApellido.TabIndex = 5;
            this.tApellido.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.tApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tApellido_KeyPress);
            // 
            // LNya
            // 
            this.LNya.AutoSize = true;
            this.LNya.Location = new System.Drawing.Point(20, 21);
            this.LNya.Name = "LNya";
            this.LNya.Size = new System.Drawing.Size(95, 13);
            this.LNya.TabIndex = 7;
            this.LNya.Text = "Nombre y Apellido:";
            // 
            // LModificar
            // 
            this.LModificar.AutoSize = true;
            this.LModificar.ForeColor = System.Drawing.Color.Red;
            this.LModificar.Location = new System.Drawing.Point(137, 21);
            this.LModificar.Name = "LModificar";
            this.LModificar.Size = new System.Drawing.Size(49, 13);
            this.LModificar.TabIndex = 8;
            this.LModificar.Text = "modificar";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Location = new System.Drawing.Point(20, 60);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(26, 13);
            this.LDni.TabIndex = 9;
            this.LDni.Text = "DNI";
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(90, 57);
            this.TDni.Multiline = true;
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(113, 22);
            this.TDni.TabIndex = 10;
            this.TDni.Click += new System.EventHandler(this.TDni_Click);
            this.TDni.TextChanged += new System.EventHandler(this.TDni_TextChanged);
            this.TDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDni_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.LTarjeta);
            this.panel1.Controls.Add(this.CBMastercard);
            this.panel1.Controls.Add(this.CBVisa);
            this.panel1.Controls.Add(this.CBNaranja);
            this.panel1.Controls.Add(this.TTelefono);
            this.panel1.Controls.Add(this.LTelefono);
            this.panel1.Controls.Add(this.LNya);
            this.panel1.Controls.Add(this.TDni);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LDni);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LModificar);
            this.panel1.Controls.Add(this.TNombre);
            this.panel1.Controls.Add(this.tApellido);
            this.panel1.Location = new System.Drawing.Point(27, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 301);
            this.panel1.TabIndex = 11;
            // 
            // LTarjeta
            // 
            this.LTarjeta.AutoSize = true;
            this.LTarjeta.Location = new System.Drawing.Point(20, 220);
            this.LTarjeta.Name = "LTarjeta";
            this.LTarjeta.Size = new System.Drawing.Size(98, 13);
            this.LTarjeta.TabIndex = 16;
            this.LTarjeta.Text = "Tarjeta de creditos:";
            // 
            // CBMastercard
            // 
            this.CBMastercard.AutoSize = true;
            this.CBMastercard.Location = new System.Drawing.Point(124, 267);
            this.CBMastercard.Name = "CBMastercard";
            this.CBMastercard.Size = new System.Drawing.Size(79, 17);
            this.CBMastercard.TabIndex = 15;
            this.CBMastercard.Text = "Mastercard";
            this.CBMastercard.UseVisualStyleBackColor = true;
            // 
            // CBVisa
            // 
            this.CBVisa.AutoSize = true;
            this.CBVisa.Location = new System.Drawing.Point(124, 243);
            this.CBVisa.Name = "CBVisa";
            this.CBVisa.Size = new System.Drawing.Size(46, 17);
            this.CBVisa.TabIndex = 14;
            this.CBVisa.Text = "Visa";
            this.CBVisa.UseVisualStyleBackColor = true;
            // 
            // CBNaranja
            // 
            this.CBNaranja.AutoSize = true;
            this.CBNaranja.Location = new System.Drawing.Point(124, 220);
            this.CBNaranja.Name = "CBNaranja";
            this.CBNaranja.Size = new System.Drawing.Size(63, 17);
            this.CBNaranja.TabIndex = 13;
            this.CBNaranja.Text = "Naranja";
            this.CBNaranja.UseVisualStyleBackColor = true;
            // 
            // TTelefono
            // 
            this.TTelefono.Location = new System.Drawing.Point(90, 177);
            this.TTelefono.Multiline = true;
            this.TTelefono.Name = "TTelefono";
            this.TTelefono.Size = new System.Drawing.Size(113, 22);
            this.TTelefono.TabIndex = 12;
            this.TTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TTelefono_KeyPress);
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Location = new System.Drawing.Point(23, 180);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(49, 13);
            this.LTelefono.TabIndex = 11;
            this.LTelefono.Text = "Telefono";
            // 
            // LNuevocliente
            // 
            this.LNuevocliente.AutoSize = true;
            this.LNuevocliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNuevocliente.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LNuevocliente.Location = new System.Drawing.Point(180, 21);
            this.LNuevocliente.Name = "LNuevocliente";
            this.LNuevocliente.Size = new System.Drawing.Size(138, 22);
            this.LNuevocliente.TabIndex = 12;
            this.LNuevocliente.Text = "Nuevo Cliente";
            // 
            // RBVaron
            // 
            this.RBVaron.AutoSize = true;
            this.RBVaron.Checked = true;
            this.RBVaron.Location = new System.Drawing.Point(307, 204);
            this.RBVaron.Name = "RBVaron";
            this.RBVaron.Size = new System.Drawing.Size(53, 17);
            this.RBVaron.TabIndex = 14;
            this.RBVaron.TabStop = true;
            this.RBVaron.Text = "Varon";
            this.RBVaron.UseVisualStyleBackColor = true;
            this.RBVaron.CheckedChanged += new System.EventHandler(this.RBVaron_CheckedChanged);
            // 
            // RBMujer
            // 
            this.RBMujer.AutoSize = true;
            this.RBMujer.Location = new System.Drawing.Point(408, 203);
            this.RBMujer.Name = "RBMujer";
            this.RBMujer.Size = new System.Drawing.Size(51, 17);
            this.RBMujer.TabIndex = 15;
            this.RBMujer.Text = "Mujer";
            this.RBMujer.UseVisualStyleBackColor = true;
            this.RBMujer.CheckedChanged += new System.EventHandler(this.RBMujer_CheckedChanged);
            // 
            // BSalir
            // 
            this.BSalir.Image = global::Practico_2.Properties.Resources.Visualpharm_Must_Have_Log_Out_48;
            this.BSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSalir.Location = new System.Drawing.Point(355, 397);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(104, 56);
            this.BSalir.TabIndex = 16;
            this.BSalir.Text = "Salir";
            this.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.Image = global::Practico_2.Properties.Resources.Designcontest_Ecommerce_Business_Save_48;
            this.BGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BGuardar.Location = new System.Drawing.Point(41, 397);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(104, 56);
            this.BGuardar.TabIndex = 0;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(332, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 97);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 486);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.RBMujer);
            this.Controls.Add(this.RBVaron);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LNuevocliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tEliminar);
            this.Controls.Add(this.BGuardar);
            this.Name = "Form1";
            this.Text = "Pequeño Formulario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button tEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.TextBox tApellido;
        private System.Windows.Forms.Label LNya;
        private System.Windows.Forms.Label LModificar;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TTelefono;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.Label LNuevocliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton RBVaron;
        private System.Windows.Forms.RadioButton RBMujer;
        private System.Windows.Forms.CheckBox CBVisa;
        private System.Windows.Forms.CheckBox CBNaranja;
        private System.Windows.Forms.CheckBox CBMastercard;
        private System.Windows.Forms.Label LTarjeta;
        private System.Windows.Forms.Button BSalir;
    }
}

