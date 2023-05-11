namespace PrjMedias
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
            primeiraNota = new Label();
            segundaNota = new Label();
            terceiraNota = new Label();
            nota1 = new TextBox();
            nota2 = new TextBox();
            nota3 = new TextBox();
            numeroFaltas = new Label();
            falta = new TextBox();
            enter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(340, 19);
            label1.Name = "label1";
            label1.Size = new Size(157, 61);
            label1.TabIndex = 0;
            label1.Text = "Médias";
            // 
            // primeiraNota
            // 
            primeiraNota.AutoSize = true;
            primeiraNota.Font = new Font("Franklin Gothic Medium Cond", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            primeiraNota.ForeColor = Color.Transparent;
            primeiraNota.Location = new Point(136, 110);
            primeiraNota.Name = "primeiraNota";
            primeiraNota.Size = new Size(151, 34);
            primeiraNota.TabIndex = 1;
            primeiraNota.Text = "Primeira nota:";
            // 
            // segundaNota
            // 
            segundaNota.AutoSize = true;
            segundaNota.Font = new Font("Franklin Gothic Medium Cond", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            segundaNota.ForeColor = Color.Transparent;
            segundaNota.Location = new Point(131, 165);
            segundaNota.Name = "segundaNota";
            segundaNota.Size = new Size(156, 34);
            segundaNota.TabIndex = 2;
            segundaNota.Text = "Segunda nota:";
            // 
            // terceiraNota
            // 
            terceiraNota.AutoSize = true;
            terceiraNota.Font = new Font("Franklin Gothic Medium Cond", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            terceiraNota.ForeColor = Color.Transparent;
            terceiraNota.Location = new Point(141, 216);
            terceiraNota.Name = "terceiraNota";
            terceiraNota.Size = new Size(146, 34);
            terceiraNota.TabIndex = 3;
            terceiraNota.Text = "Terceira nota:";
            terceiraNota.Click += nota3_Click;
            // 
            // nota1
            // 
            nota1.Location = new Point(312, 121);
            nota1.Name = "nota1";
            nota1.PlaceholderText = "Digite a 1ª nota";
            nota1.Size = new Size(283, 23);
            nota1.TabIndex = 0;
            // 
            // nota2
            // 
            nota2.Location = new Point(312, 176);
            nota2.Name = "nota2";
            nota2.PlaceholderText = "Digite a 2ª nota";
            nota2.Size = new Size(283, 23);
            nota2.TabIndex = 1;
            // 
            // nota3
            // 
            nota3.Location = new Point(312, 227);
            nota3.Name = "nota3";
            nota3.PlaceholderText = "Digite a 3ª nota";
            nota3.Size = new Size(283, 23);
            nota3.TabIndex = 2;
            nota3.TextChanged += textBox3_TextChanged;
            // 
            // numeroFaltas
            // 
            numeroFaltas.AutoSize = true;
            numeroFaltas.Font = new Font("Franklin Gothic Medium Cond", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            numeroFaltas.ForeColor = Color.Transparent;
            numeroFaltas.Location = new Point(99, 266);
            numeroFaltas.Name = "numeroFaltas";
            numeroFaltas.Size = new Size(188, 34);
            numeroFaltas.TabIndex = 7;
            numeroFaltas.Text = "Número de faltas:";
            numeroFaltas.Click += label5_Click;
            // 
            // falta
            // 
            falta.Location = new Point(312, 277);
            falta.Name = "falta";
            falta.PlaceholderText = "Digite o número de faltas";
            falta.Size = new Size(283, 23);
            falta.TabIndex = 3;
            // 
            // enter
            // 
            enter.Font = new Font("Franklin Gothic Heavy", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            enter.ForeColor = Color.DarkSlateGray;
            enter.Location = new Point(539, 323);
            enter.Name = "enter";
            enter.Size = new Size(137, 66);
            enter.TabIndex = 4;
            enter.Text = "VERIFICAR";
            enter.UseVisualStyleBackColor = true;
            enter.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(enter);
            Controls.Add(falta);
            Controls.Add(numeroFaltas);
            Controls.Add(nota3);
            Controls.Add(nota2);
            Controls.Add(nota1);
            Controls.Add(terceiraNota);
            Controls.Add(segundaNota);
            Controls.Add(primeiraNota);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label primeiraNota;
        private Label segundaNota;
        private Label terceiraNota;
        private TextBox nota1;
        private TextBox nota2;
        private TextBox nota3;
        private Label numeroFaltas;
        private TextBox falta;
        private Button enter;
    }
}