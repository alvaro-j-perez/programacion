using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_progra
{
    public partial class CALCULADORA : Form
    {
        double primero;
        double segundo;
        double resultado;
        string operacion;

        public CALCULADORA()
        {
            InitializeComponent();
        }

        private void CALCULADORA_Load(object sender, EventArgs e)
        {

        }

        private void LIMPIAR_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btncero_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ".";
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "*";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btndivison_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btnmodulo_Click(object sender, EventArgs e)
        {
            operacion = "%";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(pantalla.Text);

            switch(operacion){

                case "+":
                    resultado = primero + segundo;
                    pantalla.Text = resultado.ToString();
                    break;

                case "-":
                    resultado = primero - segundo;
                    pantalla.Text = resultado.ToString();
                    break;

                case "*":
                    resultado = primero * segundo;
                    pantalla.Text = resultado.ToString();
                    break;

                case "/":
                    resultado = primero / segundo;
                    pantalla.Text = resultado.ToString();
                    break;

                case "%":
                    resultado = primero % segundo;
                    pantalla.Text = resultado.ToString();
                    break;
            }
        }
    }
}
