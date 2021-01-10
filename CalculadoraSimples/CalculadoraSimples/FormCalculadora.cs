using System;
using System.Windows.Forms;
using CalculadoraLibrary;

namespace CalculadoraSimples
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }
        private void buttonSoma_Click(object sender, EventArgs e)
        {
            try
            {
                string valor1 = textBoxNum1.Text.Trim();
                string valor2 = textBoxNum2.Text.Trim();

                string validacao = Operacoes.ValidacaoNums(valor1, valor2);
                if (validacao != "Valores válidos")
                {
                    throw new Exception(validacao);
                }            

                double resultado = Operacoes.Somar(double.Parse(valor1), double.Parse(valor2));

                textBoxResultado.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonSub_Click(object sender, EventArgs e)
        {
            try
            {
                string valor1 = textBoxNum1.Text.Trim();
                string valor2 = textBoxNum2.Text.Trim();

                string validacao = Operacoes.ValidacaoNums(valor1, valor2);
                if (validacao != "Valores válidos")
                {
                    throw new Exception(validacao);
                }

                double resultado = Operacoes.Subtrair(double.Parse(valor1), double.Parse(valor2));

                textBoxResultado.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonMult_Click(object sender, EventArgs e)
        {
            try
            {
                string valor1 = textBoxNum1.Text.Trim();
                string valor2 = textBoxNum2.Text.Trim();

                string validacao = Operacoes.ValidacaoNums(valor1, valor2);
                if (validacao != "Valores válidos")
                {
                    throw new Exception(validacao);
                }

                double resultado = Operacoes.Multiplicar(double.Parse(valor1), double.Parse(valor2));

                textBoxResultado.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonDiv_Click(object sender, EventArgs e)
        {
            try
            {
                string valor1 = textBoxNum1.Text.Trim();
                string valor2 = textBoxNum2.Text.Trim();

                string validacao = Operacoes.ValidacaoNums(valor1, valor2);
                if (validacao != "Valores válidos")
                {
                    throw new Exception(validacao);
                }

                if (double.Parse(valor2) == 0)
                {
                    throw new Exception("Não é possivel dividir por 0");
                }

                double resultado = Operacoes.Dividir(double.Parse(valor1), double.Parse(valor2));

                textBoxResultado.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }           
    }
}
