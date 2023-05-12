namespace PrjSalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            decimal vlBruto, vlLiquido, descontoVt = 0, descontoCm = 0, desconto, imposto;


            if (decimal.TryParse(bruto.Text, out decimal res) == true)
            {

                vlBruto = decimal.Parse(bruto.Text);

                if (vt.Checked == true)
                {
                    descontoVt = (vlBruto / 100) * 6;
                }

                if (cm.Checked == true)
                {
                    descontoCm = 20.00m;

                }


                if (vlBruto < 980.00m)
                {
                    imposto = (vlBruto / 100) * 8;
                    desconto = descontoVt + descontoCm + imposto;
                    vlLiquido = vlBruto - desconto;
                    liqui.Text = vlLiquido.ToString();
                    bruto.Clear();
                    liqui.Clear();
                    bruto.Focus();
                }

                if (vlBruto > 980.00m && vlBruto < 1499.99m)
                {
                    imposto = (vlBruto / 100) * 9;
                    desconto = descontoVt + descontoCm + imposto;
                    vlLiquido = vlBruto - desconto;
                    liqui.Text = vlLiquido.ToString();
                    bruto.Clear();
                    liqui.Clear();
                    bruto.Focus();

                }

                if (vlBruto > 1450.00m && vlBruto < 2119.99m)
                {
                    imposto = (vlBruto / 100) * 10;
                    desconto = descontoVt + descontoCm + imposto;
                    vlLiquido = vlBruto - desconto;
                    liqui.Text = vlLiquido.ToString();
                    bruto.Clear();
                    liqui.Clear();
                    bruto.Focus();
                }

                if (vlBruto > 2119.99m)
                {
                    imposto = (vlBruto / 100) * 11;
                    desconto = descontoVt + descontoCm + imposto;
                    vlLiquido = vlBruto - desconto;
                    liqui.Text = vlLiquido.ToString();
                    bruto.Clear();
                    liqui.Clear();
                    bruto.Focus();
                }
            }
            else
            {
                MessageBox.Show("Não é número, por favor inserir valor numérico: " + bruto.Text);
                bruto.Clear();
                bruto.Focus();
            }


        }

        private void bruto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}