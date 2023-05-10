namespace ExerciciosConversãoUC12
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            euro = new RadioButton();
            dolar = new RadioButton();
            label2 = new Label();
            conversao = new Button();
            valorConvertido = new Label();
            valorConverter = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Heavy", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(240, 48);
            label1.Name = "label1";
            label1.Size = new Size(317, 34);
            label1.TabIndex = 0;
            label1.Text = "TABELA DE CONVERSÃO";
            // 
            // euro
            // 
            euro.AutoSize = true;
            euro.Font = new Font("Franklin Gothic Book", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            euro.ForeColor = Color.White;
            euro.Location = new Point(159, 230);
            euro.Name = "euro";
            euro.Size = new Size(125, 30);
            euro.TabIndex = 1;
            euro.Text = "EURO(ES)";
            euro.UseVisualStyleBackColor = true;
            euro.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // dolar
            // 
            dolar.AutoSize = true;
            dolar.Font = new Font("Franklin Gothic Book", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dolar.ForeColor = Color.White;
            dolar.Location = new Point(506, 230);
            dolar.Name = "dolar";
            dolar.Size = new Size(137, 30);
            dolar.TabIndex = 2;
            dolar.Text = "DOLAR(US)";
            dolar.UseVisualStyleBackColor = true;
            dolar.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(50, 136);
            label2.Name = "label2";
            label2.Size = new Size(375, 21);
            label2.TabIndex = 3;
            label2.Text = "DIGITE O VALOR QUE DESEJA CONVERTER (RS):";
            // 
            // conversao
            // 
            conversao.Font = new Font("Franklin Gothic Book", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            conversao.ForeColor = Color.Navy;
            conversao.Location = new Point(312, 306);
            conversao.Name = "conversao";
            conversao.Size = new Size(145, 48);
            conversao.TabIndex = 5;
            conversao.Text = "CONVERTER";
            conversao.UseVisualStyleBackColor = true;
            conversao.Click += conversao_Click;
            // 
            // valorConvertido
            // 
            valorConvertido.AutoSize = true;
            valorConvertido.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Bold, GraphicsUnit.Point);
            valorConvertido.ForeColor = Color.Gold;
            valorConvertido.Location = new Point(449, 174);
            valorConvertido.Name = "valorConvertido";
            valorConvertido.Size = new Size(0, 21);
            valorConvertido.TabIndex = 6;
            // 
            // valorConverter
            // 
            valorConverter.Location = new Point(449, 134);
            valorConverter.Name = "valorConverter";
            valorConverter.PlaceholderText = "Valor a converter";
            valorConverter.Size = new Size(230, 23);
            valorConverter.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(valorConverter);
            Controls.Add(valorConvertido);
            Controls.Add(conversao);
            Controls.Add(label2);
            Controls.Add(dolar);
            Controls.Add(euro);
            Controls.Add(label1);
            ForeColor = Color.PeachPuff;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton euro;
        private RadioButton dolar;
        private Label label2;
        private Button conversao;
        private Label valorConvertido;
        private TextBox valorConverter;
    }
}