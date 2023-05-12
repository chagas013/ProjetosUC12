namespace PrjSalario
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
            bruto = new TextBox();
            label1 = new Label();
            vt = new CheckBox();
            cm = new CheckBox();
            label2 = new Label();
            liqui = new TextBox();
            calcular = new Button();
            SuspendLayout();
            // 
            // bruto
            // 
            bruto.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            bruto.Location = new Point(408, 91);
            bruto.Name = "bruto";
            bruto.PlaceholderText = "Valor do salário bruto";
            bruto.Size = new Size(287, 38);
            bruto.TabIndex = 0;
            bruto.TextChanged += bruto_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Haettenschweiler", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Aquamarine;
            label1.Location = new Point(158, 91);
            label1.Name = "label1";
            label1.Size = new Size(244, 28);
            label1.TabIndex = 5;
            label1.Text = "DIGITE O SALÁRIO BRUTO (R$):";
            // 
            // vt
            // 
            vt.AutoSize = true;
            vt.Font = new Font("Haettenschweiler", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            vt.ForeColor = Color.Aquamarine;
            vt.Location = new Point(144, 165);
            vt.Name = "vt";
            vt.Size = new Size(201, 27);
            vt.TabIndex = 1;
            vt.Text = "RECEBO VALE TRANSAPORTE";
            vt.UseVisualStyleBackColor = true;
            // 
            // cm
            // 
            cm.AutoSize = true;
            cm.Font = new Font("Haettenschweiler", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cm.ForeColor = Color.Aquamarine;
            cm.Location = new Point(446, 165);
            cm.Name = "cm";
            cm.Size = new Size(188, 27);
            cm.TabIndex = 2;
            cm.Text = "RECEBO CONVÊNIO MÉDICO";
            cm.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Haettenschweiler", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Aquamarine;
            label2.Location = new Point(191, 371);
            label2.Name = "label2";
            label2.Size = new Size(186, 28);
            label2.TabIndex = 5;
            label2.Text = "SALÁRIO LÍQUIDO (R$):";
            // 
            // liqui
            // 
            liqui.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            liqui.Location = new Point(383, 363);
            liqui.Name = "liqui";
            liqui.PlaceholderText = "Valor do salário líquido";
            liqui.Size = new Size(312, 38);
            liqui.TabIndex = 4;
            // 
            // calcular
            // 
            calcular.BackColor = Color.FromArgb(192, 255, 255);
            calcular.Font = new Font("Haettenschweiler", 18F, FontStyle.Regular, GraphicsUnit.Point);
            calcular.ForeColor = Color.Indigo;
            calcular.Location = new Point(306, 264);
            calcular.Name = "calcular";
            calcular.Size = new Size(182, 41);
            calcular.TabIndex = 3;
            calcular.Text = "CALCULAR";
            calcular.UseVisualStyleBackColor = false;
            calcular.Click += calcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(800, 450);
            Controls.Add(calcular);
            Controls.Add(liqui);
            Controls.Add(label2);
            Controls.Add(cm);
            Controls.Add(vt);
            Controls.Add(label1);
            Controls.Add(bruto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox bruto;
        private Label label1;
        private CheckBox vt;
        private CheckBox cm;
        private Label label2;
        private TextBox liqui;
        private Button calcular;
    }
}