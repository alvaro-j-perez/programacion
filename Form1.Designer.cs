namespace calculadora_progra
{
    partial class CALCULADORA
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
            this.pantalla = new System.Windows.Forms.TextBox();
            this.LIMPIAR = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btncero = new System.Windows.Forms.Button();
            this.btndivison = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnmultiplicacion = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnpunto = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnmodulo = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pantalla
            // 
            this.pantalla.Location = new System.Drawing.Point(24, 12);
            this.pantalla.Name = "pantalla";
            this.pantalla.ReadOnly = true;
            this.pantalla.Size = new System.Drawing.Size(205, 20);
            this.pantalla.TabIndex = 0;
            this.pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pantalla.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LIMPIAR
            // 
            this.LIMPIAR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LIMPIAR.Location = new System.Drawing.Point(23, 51);
            this.LIMPIAR.Name = "LIMPIAR";
            this.LIMPIAR.Size = new System.Drawing.Size(47, 44);
            this.LIMPIAR.TabIndex = 1;
            this.LIMPIAR.Text = "CE";
            this.LIMPIAR.UseVisualStyleBackColor = true;
            this.LIMPIAR.Click += new System.EventHandler(this.LIMPIAR_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(23, 101);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(47, 44);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(23, 151);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(47, 44);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(23, 201);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(47, 44);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btncero
            // 
            this.btncero.Location = new System.Drawing.Point(23, 251);
            this.btncero.Name = "btncero";
            this.btncero.Size = new System.Drawing.Size(100, 44);
            this.btncero.TabIndex = 1;
            this.btncero.Text = "0";
            this.btncero.UseVisualStyleBackColor = true;
            this.btncero.Click += new System.EventHandler(this.btncero_Click);
            // 
            // btndivison
            // 
            this.btndivison.Location = new System.Drawing.Point(76, 51);
            this.btndivison.Name = "btndivison";
            this.btndivison.Size = new System.Drawing.Size(47, 44);
            this.btndivison.TabIndex = 1;
            this.btndivison.Text = "/";
            this.btndivison.UseVisualStyleBackColor = true;
            this.btndivison.Click += new System.EventHandler(this.btndivison_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(76, 101);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(47, 44);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(76, 151);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(47, 44);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(76, 201);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(47, 44);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnmultiplicacion
            // 
            this.btnmultiplicacion.Location = new System.Drawing.Point(129, 51);
            this.btnmultiplicacion.Name = "btnmultiplicacion";
            this.btnmultiplicacion.Size = new System.Drawing.Size(47, 44);
            this.btnmultiplicacion.TabIndex = 1;
            this.btnmultiplicacion.Text = "*";
            this.btnmultiplicacion.UseVisualStyleBackColor = true;
            this.btnmultiplicacion.Click += new System.EventHandler(this.btnmultiplicacion_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(129, 101);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(47, 44);
            this.btn9.TabIndex = 1;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(129, 151);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(47, 44);
            this.btn6.TabIndex = 1;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(129, 201);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(47, 44);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnpunto
            // 
            this.btnpunto.Location = new System.Drawing.Point(129, 251);
            this.btnpunto.Name = "btnpunto";
            this.btnpunto.Size = new System.Drawing.Size(47, 44);
            this.btnpunto.TabIndex = 1;
            this.btnpunto.Text = ".";
            this.btnpunto.UseVisualStyleBackColor = true;
            this.btnpunto.Click += new System.EventHandler(this.btnpunto_Click);
            // 
            // btnresta
            // 
            this.btnresta.Location = new System.Drawing.Point(182, 51);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(47, 44);
            this.btnresta.TabIndex = 1;
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.btnresta_Click);
            // 
            // btnsuma
            // 
            this.btnsuma.Location = new System.Drawing.Point(182, 101);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(47, 44);
            this.btnsuma.TabIndex = 1;
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click);
            // 
            // btnmodulo
            // 
            this.btnmodulo.Location = new System.Drawing.Point(182, 151);
            this.btnmodulo.Name = "btnmodulo";
            this.btnmodulo.Size = new System.Drawing.Size(47, 44);
            this.btnmodulo.TabIndex = 1;
            this.btnmodulo.Text = "%";
            this.btnmodulo.UseVisualStyleBackColor = true;
            this.btnmodulo.Click += new System.EventHandler(this.btnmodulo_Click);
            // 
            // btnigual
            // 
            this.btnigual.Location = new System.Drawing.Point(182, 201);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(47, 94);
            this.btnigual.TabIndex = 1;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = true;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // CALCULADORA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(257, 320);
            this.Controls.Add(this.btnigual);
            this.Controls.Add(this.btnpunto);
            this.Controls.Add(this.btncero);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnmodulo);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnmultiplicacion);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btndivison);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.LIMPIAR);
            this.Controls.Add(this.pantalla);
            this.Name = "CALCULADORA";
            this.Text = "CALCULADORA";
            this.Load += new System.EventHandler(this.CALCULADORA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pantalla;
        private System.Windows.Forms.Button LIMPIAR;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btncero;
        private System.Windows.Forms.Button btndivison;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnmultiplicacion;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnpunto;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btnmodulo;
        private System.Windows.Forms.Button btnigual;
    }
}

