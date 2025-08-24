namespace Práctico_4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnGenerarFuncion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.lista_Numeros = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPares = new System.Windows.Forms.Button();
            this.btnImpares = new System.Windows.Forms.Button();
            this.btnPrimos = new System.Windows.Forms.Button();
            this.chartNumeros = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartNumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerarFuncion
            // 
            this.btnGenerarFuncion.Location = new System.Drawing.Point(56, 170);
            this.btnGenerarFuncion.Name = "btnGenerarFuncion";
            this.btnGenerarFuncion.Size = new System.Drawing.Size(109, 23);
            this.btnGenerarFuncion.TabIndex = 0;
            this.btnGenerarFuncion.Text = "Generar Función";
            this.btnGenerarFuncion.UseVisualStyleBackColor = true;
            this.btnGenerarFuncion.Click += new System.EventHandler(this.btnGenerarFuncion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta";
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(56, 96);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(129, 20);
            this.txtDesde.TabIndex = 3;
            this.txtDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(56, 122);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(129, 20);
            this.txtHasta.TabIndex = 4;
            this.txtHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // lista_Numeros
            // 
            this.lista_Numeros.FormattingEnabled = true;
            this.lista_Numeros.Location = new System.Drawing.Point(218, 96);
            this.lista_Numeros.Name = "lista_Numeros";
            this.lista_Numeros.Size = new System.Drawing.Size(247, 199);
            this.lista_Numeros.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lista de números";
            // 
            // btnPares
            // 
            this.btnPares.Location = new System.Drawing.Point(56, 199);
            this.btnPares.Name = "btnPares";
            this.btnPares.Size = new System.Drawing.Size(111, 23);
            this.btnPares.TabIndex = 9;
            this.btnPares.Text = "Números Pares";
            this.btnPares.UseVisualStyleBackColor = true;
            this.btnPares.Click += new System.EventHandler(this.btnPares_Click);
            // 
            // btnImpares
            // 
            this.btnImpares.Location = new System.Drawing.Point(56, 228);
            this.btnImpares.Name = "btnImpares";
            this.btnImpares.Size = new System.Drawing.Size(111, 23);
            this.btnImpares.TabIndex = 10;
            this.btnImpares.Text = "Números Impares";
            this.btnImpares.UseVisualStyleBackColor = true;
            this.btnImpares.Click += new System.EventHandler(this.btnImpares_Click);
            // 
            // btnPrimos
            // 
            this.btnPrimos.Location = new System.Drawing.Point(56, 257);
            this.btnPrimos.Name = "btnPrimos";
            this.btnPrimos.Size = new System.Drawing.Size(111, 23);
            this.btnPrimos.TabIndex = 11;
            this.btnPrimos.Text = "Números Primos";
            this.btnPrimos.UseVisualStyleBackColor = true;
            this.btnPrimos.Click += new System.EventHandler(this.btnPrimos_Click);
            // 
            // chartNumeros
            // 
            chartArea1.Name = "ChartArea1";
            this.chartNumeros.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartNumeros.Legends.Add(legend1);
            this.chartNumeros.Location = new System.Drawing.Point(524, 48);
            this.chartNumeros.Name = "chartNumeros";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartNumeros.Series.Add(series1);
            this.chartNumeros.Size = new System.Drawing.Size(300, 300);
            this.chartNumeros.TabIndex = 12;
            this.chartNumeros.Text = "chartnumeros";
            this.chartNumeros.Click += new System.EventHandler(this.chartNumeros_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 373);
            this.Controls.Add(this.chartNumeros);
            this.Controls.Add(this.btnPrimos);
            this.Controls.Add(this.btnImpares);
            this.Controls.Add(this.btnPares);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lista_Numeros);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerarFuncion);
            this.Name = "Form1";
            this.Text = "Formulario4";
            ((System.ComponentModel.ISupportInitialize)(this.chartNumeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarFuncion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.ListBox lista_Numeros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPares;
        private System.Windows.Forms.Button btnImpares;
        private System.Windows.Forms.Button btnPrimos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNumeros;
    }
}

