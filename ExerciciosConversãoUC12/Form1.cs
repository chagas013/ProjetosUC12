using System.Drawing;

namespace ExerciciosConversãoUC12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        decimal valor1, valor2;

        private void conversao_Click(object sender, EventArgs e)
        {
            decimal valor1;
            valor1 = decimal.Parse(valorConverter.Text);



            if (euro.Checked == true)
            {
                valor2 = valor1 / 5.47m;
                valorConvertido.Text = "Valor convertido = " + valor2.ToString("n2");
            }
            else
            {
                valor2 = valor1 / 4.99m;
                valorConvertido.Text = "Valor convertido = " + valor2.ToString("n2");
            }
        }
    }
}