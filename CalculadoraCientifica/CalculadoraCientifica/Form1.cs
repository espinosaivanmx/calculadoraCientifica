using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCientifica
{
    public partial class Form1 : Form
    {
        double cantidad1;
        double cantidad2;
        double resultado;
        double memoria;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button37_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text = ".";
            btnPunto.Enabled = false;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            operador = "+";
            cantidad1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            operador = "-";
            cantidad1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operador = "*";
            cantidad1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            cantidad1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            cantidad2 = double.Parse(textBox1.Text);
            switch (operador)
            {
                case "+":
                    resultado = cantidad1 + cantidad2;
                    textBox1.Text = resultado.ToString();
                break;

                case "-":
                    resultado = cantidad1 - cantidad2;
                textBox1.Text = resultado.ToString();
                break;

                case "*":
                    resultado = cantidad1 * cantidad2;
                textBox1.Text = resultado.ToString();
                break;

                case "/":
                    resultado = cantidad1 / cantidad2;
                textBox1.Text = resultado.ToString();
                break;
            }
        }

        private void Raiz_Click(object sender, EventArgs e)
        {
            cantidad1 = double.Parse(textBox1.Text);
            resultado = cantidad1;
            textBox1.Text = Math.Sqrt(cantidad1).ToString();
        }

        private void btnCubo_Click(object sender, EventArgs e)
        {
            cantidad1 = double.Parse(textBox1.Text);
            resultado = cantidad1;
            textBox1.Text = Math.Pow(cantidad1,3).ToString();
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            cantidad1 = double.Parse(textBox1.Text);
            resultado = cantidad1;
            textBox1.Text = Math.Pow(cantidad1,2).ToString();
        }

        private void btnMenosUno_Click(object sender, EventArgs e)
        {
            cantidad1 = double.Parse(textBox1.Text);
            resultado = cantidad1;
            textBox1.Text = Math.Pow(cantidad1,-1).ToString();
        }

        private void btn10x_Click(object sender, EventArgs e)
        {
            cantidad1 = double.Parse(textBox1.Text);
            resultado = cantidad1;
            textBox1.Text = Math.Pow(10,cantidad1).ToString();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            cantidad1 = double.Parse(textBox1.Text);
            resultado = cantidad1;
            textBox1.Text = Math.Sin(cantidad1).ToString();
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            cantidad1 = double.Parse(textBox1.Text);
            resultado = cantidad1;
            textBox1.Text = Math.Sinh(cantidad1).ToString();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            cantidad1 = double.Parse(textBox1.Text);
            resultado = cantidad1;
            textBox1.Text = Math.Cos(cantidad1).ToString();
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            cantidad1 = double.Parse(textBox1.Text);
            resultado = cantidad1;
            textBox1.Text = Math.Cosh(cantidad1).ToString();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            cantidad1 = double.Parse(textBox1.Text);
            resultado = cantidad1;
            textBox1.Text = Math.Tan(cantidad1).ToString();
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            cantidad1 = double.Parse(textBox1.Text);
            resultado = cantidad1;
            textBox1.Text = Math.Tanh(cantidad1).ToString();
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            cantidad1 = double.Parse(textBox1.Text);
            resultado = cantidad1;
            textBox1.Text = Math.Exp(cantidad1).ToString();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            cantidad1 = double.Parse(textBox1.Text);
            resultado = cantidad1;
            textBox1.Text = Math.Log(cantidad1).ToString();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btnMMenos_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            operador = "%";
            cantidad2 = double.Parse(textBox1.Text);
            resultado = cantidad1 + cantidad2;
            textBox1.Text = Convert.ToString((cantidad1 * cantidad2) / 100);
        }

        private void btnLenght_Click(object sender, EventArgs e)
        {
           
        }
    }
}
