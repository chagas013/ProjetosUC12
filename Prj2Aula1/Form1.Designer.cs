namespace Prj2Aula1
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
            label2 = new Label();
            label3 = new Label();
            op1 = new TextBox();
            op2 = new TextBox();
            mais = new RadioButton();
            menos = new RadioButton();
            mult = new RadioButton();
            divisao = new RadioButton();
            calcular = new Button();
            resultado = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Haettenschweiler", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LemonChiffon;
            label1.Location = new Point(286, 30);
            label1.Name = "label1";
            label1.Size = new Size(225, 50);
            label1.TabIndex = 0;
            label1.Text = "CALCULADORA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Haettenschweiler", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.LemonChiffon;
            label2.Location = new Point(163, 110);
            label2.Name = "label2";
            label2.Size = new Size(159, 26);
            label2.TabIndex = 1;
            label2.Text = "PRIMEIRO OPERANDO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Haettenschweiler", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.LemonChiffon;
            label3.Location = new Point(163, 169);
            label3.Name = "label3";
            label3.Size = new Size(156, 26);
            label3.TabIndex = 2;
            label3.Text = "SEGUNDO OPERANDO:";
            label3.Click += label3_Click;
            // 
            // op1
            // 
            op1.Location = new Point(354, 110);
            op1.Name = "op1";
            op1.PlaceholderText = "Digite o primeiro número aqui";
            op1.Size = new Size(232, 23);
            op1.TabIndex = 3;
            // 
            // op2
            // 
            op2.Location = new Point(354, 169);
            op2.Name = "op2";
            op2.PlaceholderText = "Digite o segundo número aqui";
            op2.Size = new Size(232, 23);
            op2.TabIndex = 4;
            // 
            // mais
            // 
            mais.AutoSize = true;
            mais.Font = new Font("Haettenschweiler", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            mais.ForeColor = Color.LemonChiffon;
            mais.Location = new Point(202, 229);
            mais.Name = "mais";
            mais.Size = new Size(40, 32);
            mais.TabIndex = 5;
            mais.TabStop = true;
            mais.Text = "+";
            mais.UseVisualStyleBackColor = true;
            mais.CheckedChanged += mais_CheckedChanged;
            // 
            // menos
            // 
            menos.AutoSize = true;
            menos.Font = new Font("Haettenschweiler", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            menos.ForeColor = Color.LemonChiffon;
            menos.Location = new Point(316, 229);
            menos.Name = "menos";
            menos.Size = new Size(36, 32);
            menos.TabIndex = 7;
            menos.TabStop = true;
            menos.Text = "-";
            menos.UseVisualStyleBackColor = true;
            menos.CheckedChanged += menos_CheckedChanged;
            // 
            // mult
            // 
            mult.AutoSize = true;
            mult.Font = new Font("Haettenschweiler", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            mult.ForeColor = Color.LemonChiffon;
            mult.Location = new Point(431, 229);
            mult.Name = "mult";
            mult.Size = new Size(41, 32);
            mult.TabIndex = 8;
            mult.TabStop = true;
            mult.Text = "x";
            mult.UseVisualStyleBackColor = true;
            mult.CheckedChanged += mult_CheckedChanged;
            // 
            // divisao
            // 
            divisao.AutoSize = true;
            divisao.Font = new Font("Haettenschweiler", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            divisao.ForeColor = Color.LemonChiffon;
            divisao.Location = new Point(547, 229);
            divisao.Name = "divisao";
            divisao.Size = new Size(39, 32);
            divisao.TabIndex = 9;
            divisao.TabStop = true;
            divisao.Text = "/";
            divisao.UseVisualStyleBackColor = true;
            divisao.CheckedChanged += divisao_CheckedChanged;
            // 
            // calcular
            // 
            calcular.Font = new Font("Haettenschweiler", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            calcular.ForeColor = Color.Maroon;
            calcular.Location = new Point(316, 283);
            calcular.Name = "calcular";
            calcular.Size = new Size(167, 50);
            calcular.TabIndex = 10;
            calcular.Text = "CALCULAR";
            calcular.UseVisualStyleBackColor = true;
            calcular.Click += calcular_Click;
            // 
            // resultado
            // 
            resultado.Location = new Point(396, 375);
            resultado.Name = "resultado";
            resultado.PlaceholderText = "Total";
            resultado.Size = new Size(157, 23);
            resultado.TabIndex = 11;
            resultado.TextChanged += resultado_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Haettenschweiler", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.LemonChiffon;
            label4.Location = new Point(266, 372);
            label4.Name = "label4";
            label4.Size = new Size(95, 26);
            label4.TabIndex = 12;
            label4.Text = "RESULTADO:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(resultado);
            Controls.Add(calcular);
            Controls.Add(divisao);
            Controls.Add(mult);
            Controls.Add(menos);
            Controls.Add(mais);
            Controls.Add(op2);
            Controls.Add(op1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox op1;
        private TextBox op2;
        private RadioButton mais;
        private RadioButton menos;
        private RadioButton mult;
        private RadioButton divisao;
        private Button calcular;
        private TextBox resultado;
        private Label label4;
    }
}