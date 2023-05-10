using System.Diagnostics.Eventing.Reader;
using System.Drawing;

namespace Prj2Aula1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void calcular_Click(object sender, EventArgs e)
        {
            decimal valorOp1, valorOp2, total;
            string mensagem;
            valorOp1 = decimal.Parse(op1.Text);
            valorOp2 = decimal.Parse(op2.Text);


            if (mais.Checked == true)
            {
                total = valorOp1 + valorOp2;
                resultado.Text = total.ToString();

            }

            else if (menos.Checked == true)
            {
                total = valorOp1 - valorOp2;
                resultado.Text = total.ToString();
            }

            else if (mult.Checked == true)
            {
                total = valorOp1 * valorOp2;
                resultado.Text = total.ToString();
            }

            else
            {
                if (valorOp2 == 0)
                {
                    resultado.Clear();
                    MessageBox.Show(mensagem = "0 Não pode ser dividido!", "Atenção!");
                    op2.Clear();
                    op2.Focus();
                    
                }

                else
                {
                    total = valorOp1 / valorOp2;
                    resultado.Text = total.ToString();                    
                }


            }
        }

        private void mais_CheckedChanged(object sender, EventArgs e)
        {
            resultado.Clear();
        }

        private void menos_CheckedChanged(object sender, EventArgs e)
        {
            resultado.Clear();
        }

        private void mult_CheckedChanged(object sender, EventArgs e)
        {
            resultado.Clear();
        }

        private void divisao_CheckedChanged(object sender, EventArgs e)
        {
            resultado.Clear();
        }
    }
}