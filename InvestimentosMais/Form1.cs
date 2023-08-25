using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestimentosMais
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float number1 = float.Parse(txbNumber1.Text);
            float number2 = float.Parse(txbNumber2.Text);
            
            float sum = number1 + number2;
            string text = "Somar " + number1 +
                          " com " + number2 +
                          " é igual a " + sum;
            MessageBox.Show(text,
                            "RESULTADO",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            float number1 = float.Parse(txbNumber1.Text);
            float number2 = float.Parse(txbNumber2.Text);

            float sub = number1 - number2;
            string text = "Subtrair " + number1 +
                          " de " + number2 +
                          " é igual a " + sub;
            MessageBox.Show(text,
                            "RESULTADO",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            float number1 = float.Parse(txbNumber1.Text);
            float number2 = float.Parse(txbNumber2.Text);

            float mult = number1 * number2;
            string text = "Multiplicar " + number1 +
                          " com " + number2 +
                          " é igual a " + mult;
            MessageBox.Show(text,
                            "RESULTADO",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            float number1 = float.Parse(txbNumber1.Text);
            float number2 = float.Parse(txbNumber2.Text);


            float div = number1 / number2;
            string text = "Dividir " + number1 +
                          " por " + number2 +
                          " é igual a " + div;
            MessageBox.Show(text,
                            "RESULTADO",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txbCalculatorField.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txbCalculatorField.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txbCalculatorField.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbCalculatorField.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbCalculatorField.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbCalculatorField.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txbCalculatorField.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txbCalculatorField.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbCalculatorField.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txbCalculatorField.Text += "9";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txbCalculatorField.Text = String.Empty;
        }
    }
}
