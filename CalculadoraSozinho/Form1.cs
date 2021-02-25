using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSozinho
{
    public partial class Form1 : Form
    {
        public int valor1, valor2, resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt32(txtValor1.Text);
            valor2 = Convert.ToInt32(txtValor2.Text);

            resultado = valor1 + valor2;
            lblResultado.Text = resultado.ToString($"Resultado: {resultado}");
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt32(txtValor1.Text);
            valor2 = Convert.ToInt32(txtValor2.Text);


            resultado = valor1 - valor2;
            lblResultado.Text = resultado.ToString($"Resultado: {resultado}");

        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt32(txtValor1.Text);
            valor2 = Convert.ToInt32(txtValor2.Text);

            resultado = valor1 * valor2;

            lblResultado.Text = resultado.ToString($"Resultado: {resultado}");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt32(txtValor1.Text);
            valor2 = Convert.ToInt32(txtValor2.Text);

            resultado = valor1 / valor2;

            lblResultado.Text = resultado.ToString($"Resultado: {resultado}");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Text = " ";
            txtValor2.Text = " ";
            lblResultado.Text = "Resultado: ";
        }
    }

}