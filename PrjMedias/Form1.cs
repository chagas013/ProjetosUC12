namespace PrjMedias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mensagem;
            decimal nt1, nt2, nt3, faltas, media;
            faltas = decimal.Parse(falta.Text);
            nt1 = decimal.Parse(nota1.Text);
            nt2 = decimal.Parse(nota2.Text);
            nt3 = decimal.Parse(nota3.Text);


            media = (nt1 + nt2 + nt3) / 3;

            if (faltas > 12)
            {
                MessageBox.Show(mensagem = "ALUNO REPROVADO POR FALTAS!", "ATEN플O");
                nota1.Clear();
                nota2.Clear();
                nota3.Clear();
                falta.Clear();
                nota1.Focus();
            }

            if (media < 4)
            {
                MessageBox.Show(mensagem = "ALUNO REPROVADO POR NOTA = " + media.ToString("n2"), "ATEN플O");
                nota1.Clear();
                nota2.Clear();
                nota3.Clear();
                falta.Clear();
                nota1.Focus();
            }

            if (media > 4 && media < 5.5m)
            {
                MessageBox.Show(mensagem = "ALUNO EM RECUPERA플O = " + media.ToString("n2"), "ATEN플O");
                nota1.Clear();
                nota2.Clear();
                nota3.Clear();
                falta.Clear();
                nota1.Focus();
            }

            if (media > 5.5m && faltas < 12)
            {
                MessageBox.Show(mensagem = "ALUNO APROVADO = " + media.ToString("n2"), "ATEN플O");
                nota1.Clear();
                nota2.Clear();
                nota3.Clear();
                falta.Clear();
                nota1.Focus();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void nota3_Click(object sender, EventArgs e)
        {

        }
    }
}